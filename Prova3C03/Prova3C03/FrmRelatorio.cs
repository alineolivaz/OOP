using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Prova3C03
{
    public partial class FrmRelatorio : Form
    {
        BLL_CD bll_cd = new BLL_CD();

        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, System.EventArgs e)
        {
            BLL_CD idcd = new BLL_CD();
            cmbCD.DataSource = idcd.ListarCDs();
            cmbCD.DisplayMember = "nomeCD";
            cmbCD.ValueMember = "idCD";
        }

        private void btnExibir_Click(object sender, System.EventArgs e)
        {
            gridMusicas.DataSource = bll_cd.ListarPorCD(Convert.ToInt32(cmbCD.SelectedValue));
        }

        private void cmbCD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
