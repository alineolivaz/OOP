using System;
using BLL;
using DTO;

namespace Prj_mural
{
    public partial class NovoRecado : System.Web.UI.Page
    {
        DTO_Aluno alunologado;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["alunologado"] == null)
                Response.Redirect("login.aspx");
            else
                alunologado = (DTO_Aluno)Session["alunologado"];
            if (!IsPostBack)
            {
                Lblusuario.Text = alunologado.Nome;
            }
        }        

        protected void Btncadastrar_Click(object sender, EventArgs e)
        {
            DTO_Recado recado = new DTO_Recado();
            recado.Recado = txtrecado.Text;
            recado.Data = DateTime.Now;
            recado.Aluno = alunologado;
            new BLL_Recado().InserirRecado(recado);
            Response.Redirect("index.aspx");
            
        }
    }
}