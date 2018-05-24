using Midas.Model.Entidades;
using Midas.Model.Servico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midas.Desktop
{
    public partial class frmRelatorioNomeFornecedor : Form
    {
        public frmRelatorioNomeFornecedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && !radioButton2.Checked)
            {
                DialogResult res = MessageBox.Show("Deseja tira um relatório de fornecedores excluídos ordenado pela razão social?", "Midas - Controle Financeiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    DataTable dt = new DataTable();
                    List<Fornecedor> f = new List<Fornecedor>();
                    f = Servico.buscarFornecedor(textBox1.Text, 0);
                    dt = Servico.ToDataTable(f);
                   // Servico.GeneratePDF(dt, "Fornecedores ativos ordenados por razão social");

                }
            }
            else if (radioButton2.Checked && !radioButton1.Checked)
            {
                DialogResult res = MessageBox.Show("Deseja tira um relatório de fornecedores ativos ordenado pela razão social?", "Midas - Controle Financeiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    DataTable dt = new DataTable();
                    List<Fornecedor> f = new List<Fornecedor>();
                    f = Servico.buscarFornecedor(textBox1.Text, 1);
                    dt = Servico.ToDataTable(f);
                    //Servico.GeneratePDF(dt, "Fornecedores excluídos ordenados por razão social");

                }
            }
            
        }

        private void frmRelatorioNomeFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
