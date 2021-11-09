using System;
using System.Data;
using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class BLL_Disciplinas
    {
        Conexao bd = new Conexao("bdmural");

        public DataTable ListarDisciplinas()
        {
            try
            {
                string sql = "select * from Disciplina";
                return bd.ExecutarConsulta(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<DTO_Disciplina> ListarDisciplinasPorRecado(int id)
        {
            try
            {                
                List<DTO_Disciplina> disciplinas = new List<DTO_Disciplina>();
                string sql = "SELECT * FROM recadodisciplina LEFT JOIN disciplina ON recadodisciplina.Disciplina_idDisciplina = disciplina.idDisciplina where recadodisciplina.Recado_idRecado = " + id;
                DataTable dt = bd.ExecutarConsulta(sql);
                foreach (DataRow linha in dt.Rows)
                {
                    DTO_Disciplina disciplina = new DTO_Disciplina();
                    disciplina.Id = (int)linha[2];
                    disciplina.Disciplina = linha[3].ToString();
                    disciplinas.Add(disciplina);
                }              

                return disciplinas;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void InserirDisciplina(DTO_Disciplina disciplina)
        {
            try
            {
                string sql = String.Format("INSERT INTO disciplina VALUES(NULL,'{0}')", disciplina.Disciplina);
                bd.ExecutarConsulta(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AlterarDisciplina(DTO_Disciplina disciplina)
        {
            try
            {
                string sql = String.Format("UPDATE disciplina SET Disciplina = '{1}' WHERE idDisciplina = {0}", disciplina.Id, disciplina.Disciplina);
                bd.ExecutarConsulta(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ExcluirDisciplina(DTO_Disciplina disciplina)
        {
            try
            {
                string sql = String.Format("DELETE FROM disciplina WHERE idDisciplina = {0}", disciplina.Id);
                bd.ExecutarConsulta(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}