using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGV_P.Properties;

namespace SGV_P.View
{
    public partial class Dashboard : Form
    {
        bool sBarOpen = false;
        private Form _openForm;
        
        private void abrirForm(Form child)
        {
            if (_openForm != null)
            {
                _openForm.Close();
            }
            _openForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panChildForm.Controls.Add(child);
            panChildForm.Controls.Add(Parent);
            panChildForm.Tag = child;
            child.Show();
        }
        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            abrirForm(new FrmHome());
        }

        private void panChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sBarOpen)
            {
                panSBar.Width -= 25;
                if (panSBar.Width < 125)
                {
                    btnSideB.Image = Resources.menu;
                }
                if (panSBar.Width == panSBar.MinimumSize.Width)
                {
                    sBarOpen = false;
                    timer1.Stop();
                    panChildForm.Enabled = true;
                }

            }
            else
            {
                panSBar.Width+= 25;
                if (panSBar.Width > 125)
                {
                    btnSideB.Image = Resources.fechar;
                }
                if(panSBar.Width == panSBar.MaximumSize.Width)
                {
                    sBarOpen = true;
                    timer1.Stop();
                    panChildForm.Enabled = false;
                }
            }
        }

        private void btnSideB_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        //clientes_Click
        private void Clientes_Click(object sender, EventArgs e)
        {
            if(sBarOpen)
            {
                abrirForm(new FrmCliente());
                timer1.Start();
            }
        }
        private void Funcionarios_Click(object sender, EventArgs e)
        {
            if (sBarOpen)
            {
                abrirForm(new FrmFuncs());
                timer1.Start();
            }
        }
        private void Fornecedores_Click(object sender, EventArgs e)
        {
            if (sBarOpen)
            {
                abrirForm(new FrmFornecs());
                timer1.Start();
            }
        }
        private void Vendas_Click(object sender, EventArgs e)
        {
            if (sBarOpen)
            {
                abrirForm(new FrmVendas());
                timer1.Start();
            }
        }
        private void Encomendas_Click(object sender, EventArgs e)
        {
            if (sBarOpen)
            {
                abrirForm(new FrmEncomendas());
                timer1.Start();
            }
        }
        private void Produtos_Click(object sender, EventArgs e)
        {
            if (sBarOpen)
            {
                abrirForm(new FrmProds());
                timer1.Start();
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            if (sBarOpen)
            {
                Application.Exit();
            }
        }
        private void Home_Click(object sender, EventArgs e)
        {
            if (sBarOpen)
            {
                abrirForm(new FrmHome());
                timer1.Start();
            }
        }
    }
}
