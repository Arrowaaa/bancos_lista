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

namespace Cadastro_e_Consulta_Banco_de_Dados
{
    public partial class Form1 : Form
    {
        private string cadeiaConexao = "server=localhost;user=root;password=;database=comidas";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string tipo = txtTipo.Text;
            string temperatura = txtTemperatura.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(tipo) || string.IsNullOrWhiteSpace(temperatura))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            string comando = "INSERT INTO refeicao (Nome, Tipo, Temperatura) VALUES (@Nome, @Tipo, @Temperatura)";

            string cadeiaConexao = this.cadeiaConexao;
            using (var conexao = new MySqlConnection(cadeiaConexao))
            {
                MySqlCommand cmd = new MySqlCommand(comando, conexao);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Tipo", tipo);
                cmd.Parameters.AddWithValue("@Temperatura", temperatura);

                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                }
            }
        }

        private void btnConsultar_Click_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM refeicao";

            using (MySqlConnection conexao = new MySqlConnection(cadeiaConexao))
            {
                MySqlCommand cmd = new MySqlCommand(consulta, conexao);
                try
                {
                    conexao.Open();
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dgvRefeicoes.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao consultar: " + ex.Message);
                }
            }

        }
    }
}


