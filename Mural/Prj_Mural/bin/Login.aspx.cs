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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogar_Click(object sender, EventArgs e)
        {
            DTO_Aluno alunologado = new BLL_Aluno().LoginAluno(txtemail.Text, txtsenha.Text);
            if (alunologado != null)
            {
                Session["alunologado"] = alunologado;
                Response.Write("<script>alert('usuario logado com sucesso');</script>");
            }
            else
            {
                Session.Clear();
                Response.Write("<script>alert('usuario ou senha incorreto');</script>");
            }

        }
    }
}