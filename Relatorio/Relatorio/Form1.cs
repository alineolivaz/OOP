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


namespace Relatorio
{
    public partial class Form1 : Form
    {
        BLL_Relatorios relatorios = new BLL_Relatorios();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = relatorios.ListarOSporsindico();            

            comboBox1.DataSource = relatorios.Listarservicos();
            comboBox1.DisplayMember = "descricao_servico";
            comboBox1.ValueMember = "id_servico";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = relatorios.ListarOSporsindico(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = relatorios.ListarOSporsindico(Convert.ToInt32(comboBox1.SelectedValue));
        }
    }
}
