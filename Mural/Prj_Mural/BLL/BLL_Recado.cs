using System;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Recado
    {
        Conexao bd = new Conexao("bdmural");

        public DataTable ListarRecados()
        {
            try
            {
                string sql = "select * from recado";
                return bd.ExecutarConsulta(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DTO_Recado ListarRecado(int id)
        {
            try
            {
                DTO_Recado recado = new DTO_Recado();
                string sql = "select * from recado where idRecado = " + id;
                DataTable dt = bd.ExecutarConsulta(sql);
                recado.Id = (int)dt.Rows[0][0];
                recado.Recado = dt.Rows[0][1].ToString();
                recado.Data = (DateTime)dt.Rows[0][2];
                //recado.Aluno = new BLL_Aluno().ListarAluno((int)dt.Rows[0][3]);                
                recado.Disciplinas = new BLL_Disciplinas().ListarDisciplinasPorRecado((int)dt.Rows[0][0]);
                return recado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InserirRecado(DTO_Recado recado)
        {
            try
            {
                string sql = String.Format("INSERT INTO recado VALUES(NULL,'{0}',CURRENT_TIMESTAMP,'{1}')", recado.Recado, recado.Aluno.Id);
                bd.ExecutarConsulta(sql);

                sql = "select max(idrecado) from recado";
                DataTable dt = bd.ExecutarConsulta(sql);

                recado.Id = Convert.ToInt32(dt.Rows[0][0]);

                foreach (var item in recado.Disciplinas)
                {
                    sql = String.Format("INSERT INTO recadodisciplina VALUES('{0}','{1}')", recado.Id, item.Id);
                    bd.ExecutarConsulta(sql);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }        
    }
}