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
        static string connectionString = "datasource=141.145.194.186;port=3306;username=root;database=SGVPP;password=7X0a2_B4Z4o!";
        
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
        
        public static void delCliente(int id)
        {
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                string Query = "DELETE FROM clientes WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
