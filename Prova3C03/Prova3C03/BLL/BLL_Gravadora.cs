using System;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Gravadora
    {
        Conexao bd = new Conexao();
        private string tabela;

        public BLL_Gravadora()
        {
            tabela = "tbl_gravadora";
        }

        public DataTable ListarGravadoras()
        {
            try
            {
                string sql = "select * from " + tabela + " ORDER BY nome";
                return bd.ExecutarConsulta(sql);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
