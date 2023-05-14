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
        static string connectionString = "datasource=localhost;port=3306;username=root;database=SGVDB";
        
        public List<Classes.Clientes> getClientes()
        {
            List<Classes.Clientes> ListCli = new List<Classes.Clientes>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string Query = "SELECT * FROM Clientes";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Classes.Clientes cli = new Classes.Clientes();
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

                string Query = "DELETE FROM Clientes WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
