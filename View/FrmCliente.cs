using SGV_P.Classes;
using SGV_P.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGV_P
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            //Listar clientes
            ListClientes();

            //Criar Cliente

            //Modificar Cliente selecionado
            
        }

        public void ListClientes()
        {
            dataGridView1.DataSource = new MySqlDAO().getClientes();
            dataGridView1.Columns["Morada"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["id"].HeaderText = "Id";
            dataGridView1.Columns["nome"].HeaderText = "Nome";
            dataGridView1.Columns["DataNasc"].HeaderText = "Data de Nascimento";
            dataGridView1.Columns["Email"].HeaderText = "E-Mail";
            dataGridView1.Columns["Telm"].HeaderText = "Nº Telemóvel";
        }
        
        private void btnCriarCliente_Click(object sender, EventArgs e)
        {
            
            SGV_P.View.FrmEditCliente frmEditCliente = new FrmEditCliente("Create");
            frmEditCliente.ShowDialog();
            
        }

        private void btnModCliente_Click(object sender, EventArgs e)
        {
            SGV_P.View.FrmEditCliente frmEditCliente = new FrmEditCliente("Mod");
            if (dataGridView1.CurrentRow.Index != null)
            {
            int rowClicked = dataGridView1.CurrentRow.Index;
            int id = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;

                List<Clientes> ListaC = new MySqlDAO().getClientes();

                foreach(Clientes Cliente in ListaC)
                {
                    if (Cliente.id == id)
                    {
                        frmEditCliente.getCliente = Cliente;
                    }
                }
            }

            frmEditCliente.ShowDialog();
        }

        private void btnDelCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != null)
            {
                int rowClicked = dataGridView1.CurrentRow.Index;
                int id = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;
                //pedir ao user se deseja apagar o Cliente
                if (MessageBox.Show("Deseja apagar o Cliente com o id " + id.ToString() + "?", "Apagar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlDAO.delCliente(id);
                    ListClientes();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FrmCliente_Activated(object sender, EventArgs e)
        {
            ListClientes();
        }
    }
}
