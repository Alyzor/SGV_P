using SGV_P.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGV_P.View
{
    public partial class FrmEditFuncs : Form
    {
        private bool modif;
        public int id;

        public FrmEditFuncs(bool mod)
        {
            InitializeComponent();
            modif = mod;
        }
        
        private void Funcionários_Load(object sender, EventArgs e)
        {
            if (modif)
            {
                labelNome.Text = "Modificar Funcionário";
                btnApply.Text = "Modificar";

                //carregar funcionário selecionado
                List<Funcs> listafuncs = new MySqlDAO().getFuncs();
                foreach (Funcs func in listafuncs)
                {
                    if (func.id == id)
                    {
                        txtNome.Text = func.Nome;
                        txtMorada.Text = func.Morada;
                        txtNIF.Text = func.NIF;
                        txtTelm.Text = func.Telem;
                        cbAdmin.Checked = func.Adm;
                    }
                }
            }
            else 
            {
                labelNome.Text = "Criar Funcionário";
                btnApply.Text = "Criar";
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Funcs novoFunc = new Funcs()
            {
                Nome = txtNome.Text,
                NIF = txtNIF.Text,
                Telem = txtTelm.Text,
                Morada = txtMorada.Text,
                Adm = cbAdmin.Checked

            };
            if (modif)
            {
                novoFunc.id = id;
                MySqlDAO.modFunc(novoFunc);
            }
            else
            {
                MySqlDAO.newFunc(novoFunc);
            }
            (System.Windows.Forms.Application.OpenForms["FrmFuncs"] as FrmFuncs).List();
            this.Close();
        }
    }
}
