using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conexao =
                "server=localhost;user=root;password=;database=comida";

            while (true)
            {
                Console.WriteLine("1-Consultar");
                Console.WriteLine("2-Criar");
                Console.WriteLine("3-Sair");
                Console.WriteLine("Escolha uma opção:");
                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    ConsultarBancoDados(conexao);
                }
                else if (escolha == "2")
                {
                    cadastrarBancoDados(conexao);
                }
                else if (escolha == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("escolha uma opção correta!");
                }


            }


            //Console.ReadKey();
        }

        private static void cadastrarBancoDados(string conexao)
        {
            using (MySqlConnection banco = new MySqlConnection(conexao))
            {
                banco.Open();
                try
                {

                    string Nome = "teste Nome";
                    string Tipo = "teste Tipo";
                    string Temperatura = "teste Temperatura";



                    //codigo bonitão..
                    banco.Open();
                    string query = "INSERT INTO comidas(Nome, Tipo, Temperatura) VALUE (@nome, @tipo, @temperatura);";

                    using (MySqlCommand comando = new MySqlCommand(query,banco)) 
                    {
                        comando.Parameters.AddWithValue("@nome", Nome);
                        comando.Parameters.AddWithValue("@tipo", Tipo);
                        comando.Parameters.AddWithValue("@Temperatura", Temperatura);

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        private static void ConsultarBancoDados(string conexao)
        {
            using (MySqlConnection banco = new MySqlConnection(conexao))
            {
                banco.Open();

                string query = "SELECT * FROM refeicao";

                using (MySqlCommand comando = new MySqlCommand(query, banco))
                {
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["id"]);
                            Console.WriteLine(reader["Nome"]);
                            Console.WriteLine(reader["Tipo"]);
                            Console.WriteLine(reader["Temperatura"]);
                        }


                    }

                }

            }
        }
    }
}