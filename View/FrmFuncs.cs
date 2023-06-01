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
    public partial class FrmFuncs : Form
    {
        public FrmFuncs()
        {
            InitializeComponent();
        }
        private void FrmFuncs_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new MySqlDAO().getFuncs();
        }

        private void btnCriarFunc_Click(object sender, EventArgs e)
        {
            FrmEditFuncs frm = new FrmEditFuncs(false);
            frm.ShowDialog();
        }

        private void btnModFunc_Click(object sender, EventArgs e)
        {
            //get selected grid item
            int rowClicked = dataGridView1.CurrentRow.Index;
            int id = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;
            FrmEditFuncs frm = new FrmEditFuncs(true);
           frm.id = id;
            frm.ShowDialog();
        }

        private void btnDelFunc_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Deseja apagar o funcionário?", "Apagar funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            { 
                int rowClicked = dataGridView1.CurrentRow.Index;
                int id = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;
                MySqlDAO.delFunc(id);
            }
        }
        public void List()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new MySqlDAO().getFuncs();
        }
        private void FrmFuncs_Activated(object sender, EventArgs e)
        {
        }
    }
}
