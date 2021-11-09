using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BLL;

namespace Prj_mural
{
    public partial class Index : System.Web.UI.Page
    {
        private void CarregarDados()
        {
            GridView1.DataSource = new BLL_Recado().ListarRecados();
            GridView1.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarDados();
            }            
        }
    }
}