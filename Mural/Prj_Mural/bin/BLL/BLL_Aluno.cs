using System;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Aluno
    {
        Conexao bd = new Conexao("bdmural");

        public DataTable ListarAlunos()
        {
            try
            {
                string sql = "select * from Aluno";
                return bd.ExecutarConsulta(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DTO_Aluno LoginAluno(string email, string senha)
        {
            try
            {
                string sql = "select * from Aluno where EmailAluno = '" + email + "' and SenhaAluno = '" + senha + "'";
                DataTable dt = bd.ExecutarConsulta(sql);
                if (dt.Rows.Count != 1)
                    return null;
                else
                {
                    DTO_Aluno aluno = new DTO_Aluno
                    {
                        Id = (int)dt.Rows[0][0],
                        Nome = dt.Rows[0][1].ToString(),
                        Email = dt.Rows[0][2].ToString(),
                        Senha = dt.Rows[0][3].ToString()
                    };
                    aluno.Turma.Id = dt.Rows[0][4].ToString();
                    return aluno;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable ListarAluno(int id)
        {
            try
            {                
                string sql = "select * from Aluno where idAluno = " + id;
                return bd.ExecutarConsulta(sql);                
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Inseriraluno(DTO_Aluno aluno)
        {
            try
            {
                string sql = String.Format("INSERT INTO aluno VALUES(NULL,'{0}','{1}','{2}','{3}')", aluno.Nome, aluno.Email, aluno.Senha, aluno.Turma.Id);
                bd.ExecutarConsulta(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Alteraraluno(DTO_Aluno aluno)
        {
            try
            {
                string sql = String.Format("UPDATE aluno SET NomeAluno = '{1}', EmailAluno = '{2}', SenhaAluno = '{3}', Turma_idTurma = '{4}' WHERE idaluno = {0}", aluno.Id, aluno.Nome, aluno.Email, aluno.Senha, aluno.Turma.Id);
                bd.ExecutarConsulta(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Excluiraluno(DTO_Aluno aluno)
        {
            try
            {
                string sql = String.Format("DELETE FROM aluno WHERE idAluno = {0}", aluno.Id);
                bd.ExecutarConsulta(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}