using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SGV_P.Classes
{
    internal class Classes
    {
        public class Clientes
        {
            public int id { get; set; }
            public string nome { get; set; }
            public DateTime DataNasc { get; set; }
            public string Email { get; set; }
            public string Telm { get; set; }
            public string NIF { get; set; }
            public string Morada { get; set; }
        }
        public class Fornecedores
        {
            public int id { get; set; }
            public string nome { get; set; }
            public string NIF { get; set; }
            public string Morada { get; set; }
        }
        public class Vendas
        {
            public int id { get; set; }
            public int idCliente { get; set; }
            public DateTime Data { get; set; }
            public decimal PrecoTotal { get; set; }
        }
        public class VendasDetalhes
        {
            public int id { get; set; }
            public int idVenda { get; set; }
            public int idProduto { get; set; }
            public int Quantidade { get; set; }

        }
        public class Encomendas
        {
            public int id { get; set; }
            public int idFornecedor { get; set; }
            public DateTime DataEncomenda { get; set; }
            public DateTime DataChegada { get; set; }
            public decimal PrecoTotal { get; set; }
        }
        public class EncomendasDetalhes
        {
            public int id { get; set; }
            public int idEncomenda { get; set; }
            public int idProduto { get; set; }
            public int Quantidade { get; set; }
        }
        public class Produtos
        {
            public int id { get; set; }
            public string Designacao { get; set; }
            public string Descricao { get; set; }
            public int Stock { get; set; }
            public decimal Preco { get; set; }
            public int idFornecedor { get; set; }
        }
    }
}
