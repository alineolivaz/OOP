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
    public partial class recado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] == null) 
                    Response.Redirect("index.aspx");                
                DTO_Recado recado = new BLL_Recado().ListarRecado(Convert.ToInt32(Request.QueryString["id"]));
                txtRecado.Text = recado.Recado;
                txtAluno.Text = recado.Aluno.Nome;
                listDisciplinas.Items.Clear();
                foreach (var disciplina in recado.Disciplinas)
                {
                    listDisciplinas.Items.Add(disciplina.Disciplina);
                }
            }
        }
    }
}