using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DTO;

namespace Prj_mural
{
    public partial class Aluno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] == null)
                    Response.Redirect("index.aspx");
                GridView1.DataSource= new BLL_Aluno().ListarAluno(Convert.ToInt32(Request.QueryString["id"]));
                GridView1.DataBind();
                        
            }
        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            DTO_Aluno aluno = new DTO_Aluno();
            aluno.Id = Convert.ToInt32(Request.QueryString["id"]);
            aluno.Nome = txtnome.Text;
            aluno.Senha = txtsenha.Text;
            aluno.Email = txtemail.Text;
            aluno.Turma.Id = ddlTurma.SelectedValue;
            new BLL_Aluno().Alteraraluno(aluno);
            Response.Write("<script>alert('Alterado com sucesso')</script>");

        }

        protected void BtnExcluir_Click(object sender, EventArgs e)
        {
            DTO_Aluno aluno = new DTO_Aluno();
            aluno.Id = Convert.ToInt32(Request.QueryString["id"]);
            new BLL_Aluno().Excluiraluno(aluno);
            //Response.Write("<script>alert('Alterado com sucesso')</script>");
            Response.Redirect("alunos.aspx");
        }
    }
}