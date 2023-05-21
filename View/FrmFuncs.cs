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
    }
}
