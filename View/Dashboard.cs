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
        
        int tick = 0;
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
            abrirForm(new FrmCliente());
        }

        private void panChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sideBar1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void sideBar1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(sBarOpen)
            {
                sideBar1.Width -= 25;
                if (sideBar1.Width == sideBar1.MinimumSize.Width)
                {
                    timer1.Stop();
                    sBarOpen = false;
                }
            }
            else
            {
                sideBar1.Width += 25;
                if (sideBar1.Width == sideBar1.MaximumSize.Width)
                {
                    timer1.Stop();
                    sBarOpen = true;
                }
            }
        }
    }
}
