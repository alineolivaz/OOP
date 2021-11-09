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
    public partial class NovoAluno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlTurma.DataSource = new BLL_Turma().ListarTurmas();
                ddlTurma.DataTextField = "idTurma";
                ddlTurma.DataValueField = "idTurma";
                ddlTurma.DataBind();
            }
        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            DTO_Aluno aluno = new DTO_Aluno();            
            aluno.Nome = txtnome.Text;
            aluno.Senha = txtsenha.Text;
            aluno.Email = txtemail.Text;
            aluno.Turma.Id = ddlTurma.SelectedValue;
            new BLL_Aluno().Inseriraluno(aluno);
            //Response.Write("<script>alert('Alterado com sucesso')</script>");
            Response.Redirect("alunos.aspx");
        }
    }
}