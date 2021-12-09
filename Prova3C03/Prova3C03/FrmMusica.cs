using System;
using System.Windows.Forms;
using BLL;
using DTO;

namespace Prova3C03
{
    public partial class FrmMusica : Form
    {
        public FrmMusica()
        {
            InitializeComponent();
        }

        BLL_Gravadora bllGravadora = new BLL_Gravadora();
        BLL_CD bllCD = new BLL_CD();
        BLL_Musica bllMusica = new BLL_Musica();
        DTO_Musica dtoMusica = new DTO_Musica();


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtIdMusica.Text = "";
            txtNomeMusica.Text = "";
            txtNomeAutor.Text = "";
            cmbGravadora.Text = "";
            cmbCD.Text = "";
        }

        private void PreencheComboGravadora()
        {
            cmbGravadora.DataSource = bllGravadora.ListarGravadoras();
            cmbGravadora.DisplayMember = "nome";
            cmbGravadora.ValueMember = "idGravadora";
        }

        private void PreencheComboCDs()
        {
            cmbCD.DataSource = bllCD.ListarCDs();
            cmbCD.DisplayMember = "nomeCD";
            cmbCD.ValueMember = "idCD";
        }

        private void PreencheGridMusicas()
        {
            gridMusicas.DataSource = bllMusica.ListarMusicas();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdMusica.Text = gridMusicas.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeMusica.Text = gridMusicas.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNomeAutor.Text = gridMusicas.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbGravadora.SelectedValue = gridMusicas.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbCD.SelectedValue = gridMusicas.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            FrmRelatorio relatorio = new FrmRelatorio();
            relatorio.ShowDialog();
        }

        private void FrmMusica_Load(object sender, EventArgs e)
        {
            PreencheComboGravadora();
            PreencheComboCDs();
            PreencheGridMusicas();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            dtoMusica.IDMUSICA = Convert.ToInt32(txtIdMusica.Text);
            dtoMusica.NOME = txtNomeMusica.Text;
            dtoMusica.NOMEAUTOR = txtNomeAutor.Text;
            dtoMusica.IDGRAVADORA = Convert.ToInt32(cmbGravadora.SelectedValue);
            dtoMusica.IDCD = Convert.ToInt32(cmbCD.SelectedValue);
            bllMusica.AlterarMusica(dtoMusica);
            gridMusicas.DataSource = bllMusica.ListarMusicas();
        }
    }
}
