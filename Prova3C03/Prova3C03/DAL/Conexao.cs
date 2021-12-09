using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    class Conexao
    {
        private string string_conexao = "persist security info=false; server=localHost; database=bd_Gravadora; uid=root; pwd=;";
        private MySqlConnection conexao;
        
        private void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Conexão não foi estabelecida. Verifique.\n" + ex.Message);
            }
        }

        public void ExecutarComandos(string sql) //INSERT, UPDATE e DELETE
        {
            try
            {
                Conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Instrução incorreta. Verifique.\n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable ExecutarConsulta(string sql) //SELECT
        {
            try
            {
                Conectar();
                MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
                DataTable dados = new DataTable();
                consulta.Fill(dados);

                return dados;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Instrução incorreta. Verifique.\n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
