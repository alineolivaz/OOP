using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    class BLL_Relatorios
    {
        Conexao bd = new Conexao("redeconservadora");
        

        public DataTable ListarOSporsindico()
        {
            try
            {
                return bd.ExecutarConsulta("SELECT * FROM tbl_os left join tbl_sindico on tbl_os.tbl_sindico_id_sindico = tbl_sindico.id_sindico");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListarOSporsindico(DateTime datainicio, DateTime datafim)
        {
            try
            {
                return bd.ExecutarConsulta("SELECT * FROM tbl_os left join tbl_sindico " +
                    "on tbl_os.tbl_sindico_id_sindico = tbl_sindico.id_sindico " +
                    "where dataabertura_os between '" + datainicio.ToString("yyyy/MM/dd") + "' and '" + datafim.ToString("yyyy/MM/dd") + "'");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable Listarservicos()
        {
            try
            {
                return bd.ExecutarConsulta("SELECT * FROM tbl_servicos");
            }
            catch (Exception)
            {
                throw;
            }
        }


        public DataTable ListarOSporsindico(int id_servico)
        {
            try
            {
                return bd.ExecutarConsulta("SELECT * FROM tbl_os left join tbl_sindico " +
                    "on tbl_os.tbl_sindico_id_sindico = tbl_sindico.id_sindico " +
                    "where 	tbl_servicos_id_servico = " + id_servico);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListarRelatorioOS(string condicao)
        {
            try
            {
                if (condicao == "")
                    return bd.ExecutarConsulta("SELECT * FROM tbl_os left join tbl_sindico " +
                    "on tbl_os.tbl_sindico_id_sindico = tbl_sindico.id_sindico ");
                else
                    return bd.ExecutarConsulta("SELECT * FROM tbl_os left join tbl_sindico " +
                    "on tbl_os.tbl_sindico_id_sindico = tbl_sindico.id_sindico " +
                    "where " + condicao	);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
