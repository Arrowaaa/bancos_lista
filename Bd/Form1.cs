using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string conexaoString = "server=localhost;user=root;password=;database=comidas;";

        public void criar(String informacao)
        {
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                string Nome = "teste Nome";
                string Tipo = "teste Tipo";
                string Temperatura = "teste Temperatura";


                conexao.Open();
                string insert_informacao = "INNSERT INTO refeicao (Nome,Tipo,Temperatura) VALUE (@Nome, @Tipo, @Temperatura)";

                using (MySqlCommand comando = new MySqlCommand(insert_informacao, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", Nome);
                    comando.Parameters.AddWithValue("@Tipo", Tipo);
                    comando.Parameters.AddWithValue("@Temperatura", Temperatura);

                    comando.ExecuteNonQuery();
                }
       
            }
            
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string nome = "", tipo = "",
                temp = "";


            nome = textBox1.Text;
            tipo = textBox2.Text;
            temp = textBox3.Text;

                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    string Nome = "teste Nome";
                    string Tipo = "teste Tipo";
                    string Temperatura = "teste Temperatura";


                    conexao.Open();
                    string insert_informacao = "INNSERT INTO refeicao (Nome,Tipo,Temperatura) VALUE (@Nome, @Tipo, @Temperatura)";

                    using (MySqlCommand comando = new MySqlCommand(insert_informacao, conexao))
                    {
                        comando.Parameters.AddWithValue("@Nome", Nome);
                        comando.Parameters.AddWithValue("@Tipo", Tipo);
                        comando.Parameters.AddWithValue("@Temperatura", Temperatura);

                        comando.ExecuteNonQuery();
                    }

                }

            }
        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                string Nome = "teste Nome";
                string Tipo = "teste Tipo";
                string Temperatura = "teste Temperatura";


                conexao.Open();
                string insert_alternativa = "INNSERT INTO refeicao (Nome,Tipo,Temperatura) VALUE (@Nome, @Tipo, @Temperatura)";

                using (MySqlCommand comando = new MySqlCommand(insert_alternativa, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", Nome);
                    comando.Parameters.AddWithValue("@Tipo", Tipo);
                    comando.Parameters.AddWithValue("@Temperatura", Temperatura);

                    comando.ExecuteNonQuery();
                }

            }
           
        }
    }
}
