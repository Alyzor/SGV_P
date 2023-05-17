using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_P.Classes
{
    internal class Produtos
    {
        public int id { get; set; }
        public string Designacao { get; set; }
        public string Descricao { get; set; }
        public int Stock { get; set; }
        public decimal Preco { get; set; }
        public int idFornecedor { get; set; }
    }
}
