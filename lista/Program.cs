using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*string[] lista = { "Erick", "Renon", "Richard", "Monique", "Samuel", "Gustavo", "Lucas", "Pedro", "Gui", "Edilson" };

            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(lista[i]);
            }

            Console.ReadLine();*/

            string conexao = "server=localhost;user=root;password=;database=comidas";

            using (MySqlConnection banco = new MySqlConnection(conexao))
            {
                banco.Open();

                string query = "SELECT * FROM refeicao";

                using (MySqlCommand comando = new MySqlCommand(query, banco))
                {
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        reader.Read();

                        Console.WriteLine(reader["ID"]);
                        Console.WriteLine(reader["Nome"]);
                        Console.WriteLine(reader["Tipo"]);
                        Console.WriteLine(reader["Temperatura"]);
                    }

                }
            }




            Console.ReadLine();
        }
    }
}
