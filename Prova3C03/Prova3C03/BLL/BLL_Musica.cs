using System;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Musica
    {
        private Conexao bd = new Conexao();
        private string tabela;

        public BLL_Musica()
        {
            tabela = "tbl_musica";
        }

        public DataTable ListarMusicas()
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

        public void AlterarMusica(DTO_Musica musica)
        {
            try
            {
                string sql = string.Format("update " + tabela + " set nome = '{0}', nomeAutor = '{1}', idGravadora = '{2}'," +
                " idCD ='{3}' where idMusica = {4}", musica.NOME, musica.NOMEAUTOR
                    , musica.IDGRAVADORA, musica.IDCD, musica.IDMUSICA);
                bd.ExecutarComandos(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
