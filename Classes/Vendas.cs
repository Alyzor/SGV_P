using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_P.Classes
{
    internal class Vendas
    {
        public int id { get; set; }
        public int idCliente { get; set; }
        public DateTime Data { get; set; }
        public decimal PrecoTotal { get; set; }
    }
}
