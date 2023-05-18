using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using SGV_P.Properties;

namespace SGV_P.View
{
    public partial class Dashboard : Form
    {
        int tick = 0;
        bool sBarOpen = false;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }

        private void panChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSideB_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(sBarOpen)
            {
                panBlur.BackColor = Color.FromArgb(tick, Color.Black);
                tick = tick -10;
                panSideB.Width -= 25;
                if(panSideB.Width <125)
                {
                    btnSideB.Image = Resources.menu;
                }    
                if (panSideB.Width == panSideB.MinimumSize.Width)
                {
                    panBlur.Visible = false;
                    panBlur.Enabled = false;
                    sBarOpen = false;
                    timer1.Stop();
                }
            }
            else
            {
                panBlur.BackColor = Color.FromArgb(tick, Color.Black);
                tick=tick+10;
                panBlur.Visible = true;
                panBlur.Enabled = true;
                panSideB.Width += 25;
                if (panSideB.Width > 125)
                {
                    btnSideB.Image = Resources.fechar;
                }
                if (panSideB.Width == panSideB.MaximumSize.Width)
                {
                    sBarOpen = true;
                    timer1.Stop();
                }
            }
        }

        private void panBlur_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
