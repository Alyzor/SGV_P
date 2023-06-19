using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_P.Classes
{
    internal class MySqlDAO
    {
        static string connectionString = "SENSITIVE INFO";


        //clientes
        public static void newCliente(Clientes NewCli)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string Query = "Insert into clientes (Nome, DataNasc, Email, Telm, NIF, Morada)";
            Query += "Values(";
            Query += "@Nome , @DataNasc , @Email , @Telm , @NIF , @Morada );";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@Nome", NewCli.nome);
            cmd.Parameters.AddWithValue("@DataNasc", NewCli.DataNasc);
            cmd.Parameters.AddWithValue("@Email", NewCli.Email);
            cmd.Parameters.AddWithValue("@Telm", NewCli.Telm);
            cmd.Parameters.AddWithValue("@NIF", NewCli.NIF);
            cmd.Parameters.AddWithValue("@Morada", NewCli.Morada);
            cmd.ExecuteNonQuery();
            connection.Close();


        }
        public List<Clientes> getClientes()
        {
            List<Clientes> ListCli = new List<Clientes>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string Query = "SELECT * FROM clientes";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Clientes cli = new Clientes();
                cli.id = Convert.ToInt32(dataReader["id"]);
                cli.nome = Convert.ToString(dataReader["nome"]);
                cli.DataNasc = Convert.ToDateTime(dataReader["DataNasc"]);
                cli.Email = Convert.ToString(dataReader["Email"]);
                cli.Telm = Convert.ToString(dataReader["Telm"]);
                cli.NIF = Convert.ToString(dataReader["NIF"]);
                cli.Morada = Convert.ToString(dataReader["Morada"]);
                ListCli.Add(cli);
            }
            connection.Close();
            return ListCli;
        }
        public static void modCliente(Clientes modCli)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string Query = "Update clientes Set ";
            Query += "Nome = @Nome , DataNasc = @DataNasc , Email = @Email , Telm = @Telm , NIF = @NIF , Morada = @Morada ";
            Query += "Where id= @id";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@id", modCli.id);
            cmd.Parameters.AddWithValue("@Nome", modCli.nome);
            cmd.Parameters.AddWithValue("@DataNasc", modCli.DataNasc);
            cmd.Parameters.AddWithValue("@Email", modCli.Email);
            cmd.Parameters.AddWithValue("@Telm", modCli.Telm);
            cmd.Parameters.AddWithValue("@NIF", modCli.NIF);
            cmd.Parameters.AddWithValue("@Morada", modCli.Morada);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public static void delCliente(int id)
        {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                string Query = "DELETE FROM clientes WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connection.Close();
        }



        //funcionários
        internal static void newFunc(Funcs novo)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string Query = "Insert into funcionarios (Nome, Telem, NIF, Morada, Adm)";
            Query += "Values(";
            Query += "@Nome , @Telem , @NIF , @Morada , @Adm );";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@Nome", novo.Nome);
            cmd.Parameters.AddWithValue("@NIF", novo.NIF);
            cmd.Parameters.AddWithValue("@Telem", novo.Telem);
            cmd.Parameters.AddWithValue("@Morada", novo.Morada);
            cmd.Parameters.AddWithValue("@Adm", novo.Adm);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public List<Funcs> getFuncs()
        {
            List<Funcs> ListFunc = new List<Funcs>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string Query = "SELECT * FROM funcionarios";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Funcs func = new Funcs();
                func.id = Convert.ToInt32(dataReader["id"]);
                func.Nome = Convert.ToString(dataReader["Nome"]);
                func.NIF = Convert.ToString(dataReader["NIF"]);
                func.Telem = Convert.ToString(dataReader["Telem"]);
                func.Morada = Convert.ToString(dataReader["Morada"]);
                func.Adm = Convert.ToBoolean(dataReader["Adm"]);
                ListFunc.Add(func);
            }
            connection.Close();
            return ListFunc;
        }
        public static void modFunc(Funcs mod)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string Query = "Update funcionarios Set ";
            Query += "Nome = @Nome, Telem = @Telem , NIF = @NIF , Morada = @Morada, Adm = @Adm ";
            Query += "Where id= @id";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@id", mod.id);
            cmd.Parameters.AddWithValue("@Nome", mod.Nome);
            cmd.Parameters.AddWithValue("@NIF", mod.NIF);
            cmd.Parameters.AddWithValue("@Telem", mod.Telem);
            cmd.Parameters.AddWithValue("@Morada", mod.Morada);
            cmd.Parameters.AddWithValue("@Adm", mod.Adm);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        internal static void delFunc(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string Query = "DELETE FROM funcionarios WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
        }



        //Fornecedores
        internal static void newFornecedor(Fornecedores novo)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string Query = "Insert into fornecedores (Nome, NIF, Morada)";
            Query += "Values(";
            Query += "@Nome , @NIF , @Morada);";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@Nome", novo.nome);
            cmd.Parameters.AddWithValue("@NIF", novo.NIF);
            cmd.Parameters.AddWithValue("@Morada", novo.Morada);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public List<Fornecedores> getFornecedores()
        {
            List<Fornecedores> List = new List<Fornecedores>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string Query = "SELECT * FROM fornecedores";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Fornecedores fornec = new Fornecedores();
                fornec.id = Convert.ToInt32(dataReader["id"]);
                fornec.nome = Convert.ToString(dataReader["Nome"]);
                fornec.NIF = Convert.ToString(dataReader["NIF"]);
                fornec.Morada = Convert.ToString(dataReader["Morada"]);
                List.Add(fornec);
            }
            connection.Close();
            return List;
        }
        public static void modFornecedor(Funcs mod)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string Query = "Update fornecedores Set ";
            Query += "Nome = @Nome, NIF = @NIF , Morada = @Morada ";
            Query += "Where id= @id";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@id", mod.id);
            cmd.Parameters.AddWithValue("@Nome", mod.Nome);
            cmd.Parameters.AddWithValue("@NIF", mod.NIF);
            cmd.Parameters.AddWithValue("@Morada", mod.Morada);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        internal static void delFornecedor(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string Query = "DELETE FROM fornecedores WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
        }


        //Produtos
        internal static void newProduto(Produtos novo)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string Query = "Insert into produtos (Designacao, Descricao, Stock, Preco, idFornecedor)";
            Query += "Values(";
            Query += "@Designacao, @Descricao, @Stock, @Preco, @idFornecedor);";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@Designacao", novo.Designacao);
            cmd.Parameters.AddWithValue("@Descricao", novo.Descricao);
            cmd.Parameters.AddWithValue("@Stock", novo.Stock);
            cmd.Parameters.AddWithValue("@Preco", novo.Preco);
            cmd.Parameters.AddWithValue("@idFornecedor", novo.idFornecedor);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public List<Produtos> getProdutos()
        {
            List<Produtos> List = new List<Produtos>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string Query = "SELECT * FROM produtos";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Produtos prod = new Produtos();
                prod.id = Convert.ToInt32(dataReader["id"]);
                prod.Designacao = Convert.ToString(dataReader["Designacao"]);
                prod.Descricao = Convert.ToString(dataReader["Descricao"]);
                prod.Stock = Convert.ToInt32(dataReader["Stock"]);
                prod.Preco = Convert.ToInt32(dataReader["Preco"]);
                prod.idFornecedor = Convert.ToInt32(dataReader["idFornecedor"]);
                List.Add(prod);
            }
            connection.Close();
            return List;
        }
        public static void modProduto(Produtos mod)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string Query = "Update produtos Set ";
            Query += "Designacao = @Designacao, Descricao = @Descricao, Stock = @Stock, Preco = @Preco, idFornecedor = @idFornecedor ";
            Query += "Where id= @id";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@id", mod.id);
            cmd.Parameters.AddWithValue("@Designacao", mod.Designacao);
            cmd.Parameters.AddWithValue("@Descricao", mod.Descricao);
            cmd.Parameters.AddWithValue("@Stock", mod.Stock);
            cmd.Parameters.AddWithValue("@Preco", mod.Preco);
            cmd.Parameters.AddWithValue("@idFornecedor", mod.idFornecedor);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        internal static void delProduto(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string Query = "DELETE FROM produtos WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
