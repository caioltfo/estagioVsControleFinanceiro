using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midas.Model.Servico;
using Midas.Model.Entidades;


namespace Midas.Desktop
{
    public partial class fornecedores : Form
    {
        Boolean add;
        String user = Program.USER;
        public fornecedores(Boolean add)
        {
            InitializeComponent();
            this.add = add;
            //this.user = adm;
        }

        private void fornecedores_Load(object sender, EventArgs e)
        {

            
            if(add == true)
            {
                tabControl1.SelectedIndex = 1;
                maskedTextBox_CNPJ.Enabled = true;
                maskedTextBox_CPF.Enabled = true;
                textBox_razao.Enabled = true;
                textBox_fantasia.Enabled = true;
                maskedTextBox_TEL.Enabled = true;
                textBox_site.Enabled = true;
                maskedTextBox_CEL.Enabled = true;
                textBox_email.Enabled = true;
                textBox_cidade.Enabled = true;
                textBox_rua.Enabled = true;
                textBox_compEnd.Enabled = true;
                textBox_numBanco.Enabled = true;
                textBox_NumAg.Enabled = true;
                textBox_NumConta.Enabled = true;
                textBox_NomeGerente.Enabled = true;
                maskedTextBox_TELFOR.Enabled = true;
                maskedTextBox_CELFOR.Enabled = true;
                textBox_Obs.Enabled = true;
                toolStripButton_salvar.Enabled = true;
                toolStripButton_excluir.Enabled = true;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            dtg_for.DataSource = Servico.buscarFornecedorPorCategoria(cmb_categoria.SelectedIndex,textBox_pesquisa.Text);

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_fantasia_TextChanged(object sender, EventArgs e)
        {
            string razao = textBox_fantasia.Text;
            if (Servico.validaFant(razao) == true)
            {
                label_fant.Text = "Fantasia Válida";
                label_fant.ForeColor = Color.Green;
                label_fant.Visible = true;
            }
            else
            {
                label_fant.Text = "Fantasia já existe";
                label_fant.ForeColor = Color.Red;
                label_fant.Visible = true;
            }
        }

        private void textBox_razao_TextChanged(object sender, EventArgs e)
        {
            string razao = textBox_razao.Text;
            if (Servico.validaRazao(razao) == true)
            {
                label_razao.Text = "Razão Válida";
                label_razao.ForeColor = Color.Green;
                label_razao.Visible = true;
            }
            else
            {
                label_razao.Text = "Razão já existe";
                label_razao.ForeColor = Color.Red;
                label_razao.Visible = true;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textbox_cpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (Servico.validaEmail(textBox_email.Text))
            {
                label_email.Text = "Email Válido";
                label_email.ForeColor = Color.Green;
                label_email.Visible = true;
            }
            else
            {
                label_email.Text = "Email Inválido";
                label_email.ForeColor = Color.Red;
                label_email.Visible = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo cadastrar um novo fornecedor?","Midas - Controle Financeiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                //frmIndex frmp = new frmIndex(user);
                //Form_autenticaForne frm = new Form_autenticaForne();
                fornecedores frm = new fornecedores(true);
                
                frm.Show();
                this.Hide();
            }else
            {

            }
        }

        private void maskedTextBox_CPF_TextChanged(object sender, EventArgs e)
        {
            if(Servico.IsCpf(maskedTextBox_CPF.Text) == true)
            {
                label_cpf.Text = "CPF Válido";
                label_cpf.ForeColor = Color.Green;
                label_cpf.Visible = true;
            }else
            {
                label_cpf.Text = "CPF Inválido";
                label_cpf.ForeColor = Color.Red;
                label_cpf.Visible = true;
            }

        }

        private void maskedTextBox_CNPJ_TextChanged(object sender, EventArgs e)
        {
            if (Servico.IsCpf(maskedTextBox_CNPJ.Text) == true)
            {
                label_cpf.Text = "CNPJ Válido";
                label_cpf.ForeColor = Color.Green;
                label_cpf.Visible = true;
            }
            else
            {
                label_cpf.Text = "CNPJ Inválido";
                label_cpf.ForeColor = Color.Red;
                label_cpf.Visible = true;
            }
        }

        private void maskedTextBox_TEL_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (Servico.validaTel(maskedTextBox_TEL.Text))
            {
                label_tel.Text = "Tel Válido";
                label_tel.ForeColor = Color.Green;
                label_tel.Visible = true;
            }
            else
            {
                label_tel.Text = "Tel Inválido";
                label_tel.ForeColor = Color.Red;
                label_tel.Visible = true;
            }
        }

        private void textBox_site_TextChanged(object sender, EventArgs e)
        {
            if(Servico.ConectarUrl(textBox_site.Text) == true)
            {
                label_site.Text = "Site Válido";
                label_site.ForeColor = Color.Green;
                label_site.Visible = true;
            }else
            {
                label_site.Text = "Site Inválido";
                label_site.ForeColor = Color.Red;
                label_site.Visible = true;
            }
        }

        private void maskedTextBox_CEL_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (Servico.validaTel(maskedTextBox_CEL.Text))
            {
                label_cel.Text = "Cel Válido";
                label_cel.ForeColor = Color.Green;
                label_cel.Visible = true;
            }
            else
            {
                label_cel.Text = "Cel Inválido";
                label_cel.ForeColor = Color.Red;
                label_cel.Visible = true;
            }
        }

        private void label_TelGer_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox_TELFOR_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (Servico.validaTel(maskedTextBox_TELFOR.Text))
            {
                label_TelGer.Text = "Tel Válido";
                label_TelGer.ForeColor = Color.Green;
                label_TelGer.Visible = true;
            }
            else
            {
                label_TelGer.Text = "Tel Inválido";
                label_TelGer.ForeColor = Color.Red;
                label_TelGer.Visible = true;
            }
        }

        private void maskedTextBox_CELFOR_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (Servico.validaTel(maskedTextBox_CELFOR.Text))
            {
                label_CelGere.Text = "Tel Válido";
                label_CelGere.ForeColor = Color.Green;
                label_CelGere.Visible = true;
            }
            else
            {
                label_CelGere.Text = "Cel Inválido";
                label_CelGere.ForeColor = Color.Red;
                label_CelGere.Visible = true;
            }
        }
    }
}
