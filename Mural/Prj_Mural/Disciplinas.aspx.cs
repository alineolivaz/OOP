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
    public partial class Disciplinas : System.Web.UI.Page
    {
        private void CarregarDados()
        {
            GridView1.DataSource = new BLL_Disciplinas().ListarDisciplinas();
            GridView1.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarDados();
            }
        }

        protected void BtnCadastrar_Click(object sender, EventArgs e)
        {
            DTO_Disciplina disciplina = new DTO_Disciplina();
            disciplina.Disciplina = txtdisciplina.Text;
            new BLL_Disciplinas().InserirDisciplina(disciplina);
            CarregarDados();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            CarregarDados();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DTO_Disciplina disciplina = new DTO_Disciplina();
            disciplina.Id = Convert.ToInt32(e.Values[0]);
            new BLL_Disciplinas().ExcluirDisciplina(disciplina);
            GridView1.EditIndex = -1;
            CarregarDados();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            DTO_Disciplina disciplina = new DTO_Disciplina();
            disciplina.Id = Convert.ToInt32(e.NewValues[0]);
            disciplina.Disciplina = e.NewValues[1].ToString();
            new BLL_Disciplinas().AlterarDisciplina(disciplina);
            GridView1.EditIndex = -1;
            CarregarDados();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            CarregarDados();
        }
    }
}