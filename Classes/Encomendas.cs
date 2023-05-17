using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_P.Classes
{
    internal class Encomendas
    {
        public int id { get; set; }
        public int idFornecedor { get; set; }
        public DateTime DataEncomenda { get; set; }
        public DateTime DataChegada { get; set; }
        public decimal PrecoTotal { get; set; }
    }
}
