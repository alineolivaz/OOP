using System;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Turma
    {
        Conexao bd = new Conexao("bdmural");

        public DataTable ListarTurmas()
        {
            try
            {
                string sql = "select * from Turma";
                return bd.ExecutarConsulta(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DTO_Turma ListarTurma(string id)
        {
            try
            {
                DTO_Turma turma = new DTO_Turma();
                string sql = "select * from Turma where idTurma = '" + id + "'";
                DataTable dt = bd.ExecutarConsulta(sql);
                turma.Id = dt.Rows[0][0].ToString();
                turma.Serie = (int)dt.Rows[0][1];
                turma.Unidade = (int)dt.Rows[0][2];              
                
                return turma;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}