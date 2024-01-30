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
                "server=localhost;user=root;password=;database=comidas";

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
                    CadastrarBancoDados(conexao);
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

        private static void CadastrarBancoDados(string conexao)
        {
            using (MySqlConnection banco = new MySqlConnection(conexao))
            {
                ;
                try
                {
                    Console.WriteLine("Nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Tipo: ");
                    string tipo = Console.ReadLine();

                    Console.WriteLine("Temperatura: ");
                    string temperatura = Console.ReadLine(); ;

                    banco.Open();
                    string query = "INSERT INTO comidas (Nome, Tipo, Temperatura) VALUE (@Nome, @Tipo, @Temperatura);";
                    using (MySqlCommand comando = new MySqlCommand(query, banco))
                    {
                        comando.Parameters.AddWithValue("@Nome", Nome);
                        comando.Parameters.AddWithValue("@Tipo", Tipo);
                        comando.Parameters.AddWithValue("@Temperatura", Temperatura);


                        comando.ExecuteNonQuery();

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
                            Console.WriteLine(reader["nome"]);
                            Console.WriteLine(reader["tipo"]);
                            Console.WriteLine(reader["temperatura"]);
                        }


                    }

                }

            }
        }
    }
}
