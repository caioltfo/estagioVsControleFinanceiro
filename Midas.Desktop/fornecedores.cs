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
        private int linhaAtual = 0;
        private string cpf, cnpj, razao, fantasia, telefone, site, celular, email, cidade, rua, Cidade, comple, numbanco, numag, numconta, nomegerente, telgerente, celgerente,obs;
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
        
        private void obtemDadosGrid()
        {
            //obtem os dados do datagridview da linha selecionada usando as posições das colunas
            //a primeira coluna é a coluna 0 a segunda é a coluna 1 , e , assim por diante
            cpf = dtg_for[1, linhaAtual].Value.ToString();
            cnpj = dtg_for[2, linhaAtual].Value.ToString();
            razao = dtg_for[3, linhaAtual].Value.ToString();
            fantasia = dtg_for[4, linhaAtual].Value.ToString();
            telefone = dtg_for[5, linhaAtual].Value.ToString();
            site = dtg_for[6, linhaAtual].Value.ToString();
            celular = dtg_for[7, linhaAtual].Value.ToString();
            email = dtg_for[8, linhaAtual].Value.ToString();
            Cidade = dtg_for[9, linhaAtual].Value.ToString();
            rua = dtg_for[10, linhaAtual].Value.ToString();
            comple = dtg_for[12, linhaAtual].Value.ToString();
            numbanco = dtg_for[13, linhaAtual].Value.ToString();
            numag = dtg_for[14, linhaAtual].Value.ToString();
            numconta = dtg_for[15, linhaAtual].Value.ToString();
            nomegerente = dtg_for[16, linhaAtual].Value.ToString();
            telgerente = dtg_for[17, linhaAtual].Value.ToString();
            celgerente = dtg_for[18, linhaAtual].Value.ToString();
            obs = dtg_for[19, linhaAtual].Value.ToString();
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            obtemDadosGrid();
            tabControl1.SelectedIndex = 1;
            maskedTextBox_CEL.Text = celular;
            maskedTextBox_CELFOR.Text = celgerente;
            maskedTextBox_CNPJ.Text = cnpj;
            maskedTextBox_CPF.Text = cpf;
            maskedTextBox_TEL.Text = telefone;
            maskedTextBox_TELFOR.Text = telgerente;
            textBox_cidade.Text = Cidade;
            textBox_compEnd.Text = comple;
            textBox_email.Text = email;
            textBox_fantasia.Text = fantasia;
            textBox_NomeGerente.Text = nomegerente;
            textBox_NumAg.Text = numag;
            textBox_numBanco.Text = numbanco;
            textBox_NumConta.Text = numconta;
            textBox_Obs.Text = obs;
            textBox_razao.Text = razao;
            textBox_rua.Text = rua;
            textBox_site.Text = site;
            DialogResult res = MessageBox.Show("Deseja editar o " + razao + "?","Midas - Controle Financeiro - Manutenção de Fornecedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                maskedTextBox_CEL.Enabled = true;
                maskedTextBox_CELFOR.Enabled = true ;
                maskedTextBox_CNPJ.Enabled = true;
                maskedTextBox_CPF.Enabled = true;
                maskedTextBox_TEL.Enabled = true;
                maskedTextBox_TELFOR.Enabled = true;
                textBox_cidade.Enabled = true;
                textBox_compEnd.Enabled = true;
                textBox_email.Enabled = true;
                textBox_fantasia.Enabled = true;
                textBox_NomeGerente.Enabled = true;
                textBox_NumAg.Enabled = true;
                textBox_numBanco.Enabled = true;
                textBox_NumConta.Enabled = true;
                textBox_Obs.Enabled = true;
                textBox_razao.Enabled = true;
                textBox_rua.Enabled = true;
                textBox_site.Enabled = true;
                toolStripButton_salvar.Enabled = true;
                toolStripButton_excluir.Enabled = true;
            }


           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            dtg_for.DataSource = Servico.buscarFornecedorPorCategoria(cmb_categoria.SelectedIndex,textBox_pesquisa.Text, 0);

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_fantasia_TextChanged(object sender, EventArgs e)
        {
            string razao = textBox_fantasia.Text;
            if (Servico.validaFant(razao) == true)
            {
                pictureBox_fant.Image = Properties.Resources.ok;
                pictureBox_fant.Visible = true;
            }
            else
            {
                pictureBox_fant.Image = Properties.Resources.erro;
                
                pictureBox_fant.Visible = true;
            }
        }

        private void textBox_razao_TextChanged(object sender, EventArgs e)
        {
            string razao = textBox_razao.Text;
            if (Servico.validaRazao(razao) == true)
            {
                pictureBox_razao.Image = Properties.Resources.ok;
                
                pictureBox_razao.Visible = true;
            }
            else
            {
                pictureBox_razao.Image = Properties.Resources.erro;
                
                pictureBox_razao.Visible = true;
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
                pictureBox_email.Image = Properties.Resources.ok;
                pictureBox_email.Visible = true;
            }
            else
            {
                pictureBox_email.Image = Properties.Resources.erro;
                
                pictureBox_email.Visible = true;
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
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.Hide();
            }else
            {

            }
        }

        private void maskedTextBox_CPF_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void maskedTextBox_CNPJ_TextChanged(object sender, EventArgs e)
        {
            if (Servico.IsCnpj(maskedTextBox_CNPJ.Text) == true)
            {
                pictureBox_cpf.Image = Properties.Resources.ok;
                
                pictureBox_cpf.Visible = true;
            }
            else
            {
                pictureBox_cpf.Image = Properties.Resources.erro;
                
                pictureBox_cpf.Visible = true;
            }
        }

        private void maskedTextBox_TEL_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (Servico.validaTel(maskedTextBox_TEL.Text))
            {
                             
                
            }
            else
            {
                
                
                
            }
        }

        private void textBox_site_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void maskedTextBox_CEL_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (Servico.validaTel(maskedTextBox_CEL.Text))
            {
                
                
                
            }
            else
            {
                
                
                           }
        }

        private void label_TelGer_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox_TELFOR_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (Servico.validaTel(maskedTextBox_TELFOR.Text))
            {
                
            }
            else
            {
                
            }
        }

        private void maskedTextBox_CELFOR_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (Servico.validaTel(maskedTextBox_CELFOR.Text))
            {
                
            }
            else
            {
                
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_site_Leave(object sender, EventArgs e)
        {
            if (Servico.ConectarUrl(textBox_site.Text) == true)
            {

                pictureBox_site.Image = Properties.Resources.ok;
                
                pictureBox_site.Visible = true;
            }
            else
            {
                pictureBox_site.Image = Properties.Resources.erro;
                
                pictureBox_site.Visible = true;
            }
        }

        private void maskedTextBox_TEL_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void maskedTextBox_CEL_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dtg_for_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            obtemDadosGrid();
            tabControl1.SelectedIndex = 1;
            maskedTextBox_CEL.Text = celular;
            maskedTextBox_CELFOR.Text = celgerente;
            maskedTextBox_CNPJ.Text = cnpj;
            maskedTextBox_CPF.Text = cpf;
            maskedTextBox_TEL.Text = telefone;
            maskedTextBox_TELFOR.Text = telgerente;
            textBox_cidade.Text = Cidade;
            textBox_compEnd.Text = comple;
            textBox_email.Text = email;
            textBox_fantasia.Text = fantasia;
            textBox_NomeGerente.Text = nomegerente;
            textBox_NumAg.Text = numag;
            textBox_numBanco.Text = numbanco;
            textBox_NumConta.Text = numconta;
            textBox_Obs.Text = obs;
            textBox_razao.Text = razao;
            textBox_rua.Text = rua;
            textBox_site.Text = site;
            DialogResult res = MessageBox.Show("Deseja editar o " + razao + "?", "Midas - Controle Financeiro - Manutenção de Fornecedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                maskedTextBox_CEL.Enabled = true;
                maskedTextBox_CELFOR.Enabled = true;
                maskedTextBox_CNPJ.Enabled = true;
                maskedTextBox_CPF.Enabled = true;
                maskedTextBox_TEL.Enabled = true;
                maskedTextBox_TELFOR.Enabled = true;
                textBox_cidade.Enabled = true;
                textBox_compEnd.Enabled = true;
                textBox_email.Enabled = true;
                textBox_fantasia.Enabled = true;
                textBox_NomeGerente.Enabled = true;
                textBox_NumAg.Enabled = true;
                textBox_numBanco.Enabled = true;
                textBox_NumConta.Enabled = true;
                textBox_Obs.Enabled = true;
                textBox_razao.Enabled = true;
                textBox_rua.Enabled = true;
                textBox_site.Enabled = true;
                toolStripButton_salvar.Enabled = true;
                toolStripButton_excluir.Enabled = true;
            }
        }

        private void toolStripButton_excluir_Click(object sender, EventArgs e)
        {

            if (!textBox_razao.Text.Length.Equals(0))
            {
                DialogResult res = MessageBox.Show("Deseja mesmo excluir o " + textBox_razao.Text + "?", "Midas -  Controle Financeiro - Exclusão de Fornecedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    
                    try
                    {
                        
                        Servico.excluir(textBox_razao.Text, Program.ID_USER);
                        MessageBox.Show("Excluído com sucesso!", "Midas - Controle Financeiro - Exclusão de Fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO - " + ex, "Midas - Controle Financeiro - Cadastro de Fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
        }

        private void maskedTextBox_CPF_Validating(object sender, CancelEventArgs e)
        {

        }

        private void maskedTextBox_CPF_Leave(object sender, EventArgs e)
        {
            if (Servico.IsCpf(maskedTextBox_CPF.Text) == true)
            {
                pictureBox_cpf.Image = Properties.Resources.ok;

                pictureBox_cpf.Visible = true;
            }
            else
            {
                pictureBox_cpf.Image = Properties.Resources.erro;

                pictureBox_cpf.Visible = true;
            }
        }

        private void maskedTextBox_TELFOR_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void maskedTextBox_CELFOR_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void maskedTextBox_CNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label_razao_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label_site_Click(object sender, EventArgs e)
        {

        }

        private void label_cel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_salvar_Click(object sender, EventArgs e)
        {
            if(pictureBox_email.Visible == true || pictureBox_site.Visible == true || pictureBox_email.Visible == true || pictureBox_cpf.Visible == true || pictureBox_fant.Visible == true)
            {
                if(!textBox_razao.Text.Length.Equals(0))
                {
                    DialogResult res = MessageBox.Show("Deseja mesmo cadastrar o " + textBox_razao.Text + " como seu fornecedor?", "Midas -  Controle Financeiro - Cadastro de Fornecedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        Fornecedor f = new Fornecedor();
                        f.Ag_bang_fornecedor = textBox_NumAg.Text;
                        f.Celular_fornecedor = Convert.ToInt64(maskedTextBox_CEL.Text.ToString().Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""));
                        f.Celular_gerente_fornecedor = Convert.ToInt64(maskedTextBox_CELFOR.Text.ToString().Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""));
                        f.Cidade_fornecedor = textBox_cidade.Text;
                        f.Cnpj_fornecedor = maskedTextBox_CNPJ.Text;
                        f.Complemento_fornecedor = textBox_compEnd.Text;
                        f.Conta_fornecedor = textBox_NumConta.Text;
                        f.Cpf_fornecedor = maskedTextBox_CPF.Text;
                        f.Email_fornecedor = textBox_email.Text;
                        f.Fantasia_fornecedor = textBox_fantasia.Text;
                        f.Gerente_fornecedor = textBox_NomeGerente.Text;
                        f.Nro_banco_fornecedor = textBox_numBanco.Text;
                        f.Obd_fornecedor = textBox_Obs.Text;
                        f.Razao_social_fornecedor = textBox_razao.Text;
                        f.Rua_fornecedor = textBox_rua.Text;
                        f.Site_fornecedor = textBox_site.Text;
                        f.Excluido = 0;
                        f.Telefone_fornecedor = Convert.ToInt64(maskedTextBox_TEL.Text.ToString().Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""));
                        f.Telefone_gerente_fornecedor = Convert.ToInt64(maskedTextBox_TELFOR.Text.ToString().Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""));
                        try
                        {
                            Servico.salvar(f, Program.ID_USER);
                            MessageBox.Show("Salvo com sucesso!", "Midas - Controle Financeiro - Cadastro de Fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERRO - " + ex, "Midas - Controle Financeiro - Cadastro de Fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if(textBox_razao.Text.Length.Equals(0))
                {
                    MessageBox.Show("Você não pode cadastrar um fornecedor sem ao menos ter digitado a Razão Social.", "Midas - Controle Financeiro - Cadastro de Fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        private void button_todos_Click(object sender, EventArgs e)
        {
            dtg_for.DataSource = Servico.buscarFornecedorPorCategoria(8, textBox_pesquisa.Text,0);
        }

        private void dtg_for_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
