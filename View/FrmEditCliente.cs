using SGV_P.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SGV_P.View
{
    public partial class FrmEditCliente : Form
    {
        private string OpType { get; set; }
        internal Clientes getCliente { get; set; }

        public FrmEditCliente(string opType)
        {
            InitializeComponent();
            this.OpType = opType;
        }

        private void FrmEditCliente_Load(object sender, EventArgs e)
        {
            switch (OpType)
            {
                case "Create":
                    setCreate();
                    break;
                case "Mod":
                    setMod();
                    break;
            }

        }

        private void setCreate()
        {
            this.Text = "Criar Cliente";
            btnApply.Text = "Criar";
            labelNome.Text = "Criar Cliente";
        }

        private void setMod()
        {

            btnApply.Text = "Modificar";
            labelNome.Text = "Modificar Cliente";
            this.Text = "Modificar Cliente";
            try
            {
                txtNome.Text = getCliente.nome;
                txtNIF.Text = getCliente.NIF;
                txtMorada.Text = getCliente.Morada;
                txtEmail.Text = getCliente.Email;
                txtTelm.Text = getCliente.Telm;
                dtpDataNasc.Value = getCliente.DataNasc;
            }
            catch
            {
                MessageBox.Show("Cliente Selecionado não carregado! Por favor, tente novamente", "Erro!");
            }


        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Clientes NovoCli = new Clientes();

            NovoCli.nome = txtNome.Text;
            NovoCli.NIF = txtNIF.Text;
            NovoCli.Email = txtEmail.Text;
            NovoCli.Morada = txtMorada.Text;
            NovoCli.Telm = txtTelm.Text;
            NovoCli.DataNasc = dtpDataNasc.Value;
                
            switch (OpType)
            {
                case "Create":
                    MySqlDAO.newCliente(NovoCli);
                    this.Close();
                    break;
                case "Mod":
                    NovoCli.id = getCliente.id;
                    MySqlDAO.modCliente(NovoCli);
                    this.Close();
                    break;

            }
        }
    }
}
