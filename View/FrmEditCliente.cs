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
    public partial class FrmEditCliente : Form
    {
        public string OpType { get; set; }
        public FrmEditCliente()
        {
            InitializeComponent();
            switch(OpType)
            {
                case "Create":
                    this.Text = "Criar Cliente";
                    break;
                case "Mod":
                    this.Text = "Modificar Cliente";
                    break;
            }
        }
    }
}
