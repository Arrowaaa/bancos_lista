namespace Cadastro_e_Consulta_Banco_de_Dados
{
    internal class MySqlConnection
    {
        private string conexaoString;

        public MySqlConnection(string conexaoString)
        {
            this.conexaoString = conexaoString;
        }
    }
}