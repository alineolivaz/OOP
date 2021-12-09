using System;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_CD
    {
        Conexao bd = new Conexao();
        private string tabela;

        public BLL_CD()
        {
            tabela = "tbl_cd";
        }
        // metodos
        public DataTable ListarCDs()
        {
            try
            {
                string sql = "select * from " + tabela;
                return bd.ExecutarConsulta(sql);

            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable ListarPorCD(int idcd)
        {
            try
            {
                return bd.ExecutarConsulta("SELECT idMusica, tbl_musica.nome, nomeAutor, tbl_gravadora.nome, precoVenda FROM tbl_musica" +
                    " join tbl_gravadora left join tbl_cd on tbl_musica.idMusica" +
                    " = tbl_cd.idCD WHERE tbl_cd.idCD = " + idcd +" " +
                    " AND tbl_gravadora.idGravadora = " + idcd);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
