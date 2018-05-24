using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midas.Model.Entidades;
using Midas.Model.Servico;

namespace Midas.Desktop
{
    public partial class frm_banco : Form
    {
        Boolean add;
        String user = Program.USER;
        private int linhaAtual = 0;
        private string nome, nro, ag, conta, gerente, tel, cel, obs, usuario, excluido;
        private int id_emp;

        public frm_banco(bool flag)
        {
            InitializeComponent();
            if(flag  ==  true)
            {
                toolStripButton2.Enabled = true;
                toolStripButton3.Enabled = true;
                tabControl1.SelectedIndex = 1;
                textBox_ag.Enabled = true;
                textBox_cel.Enabled = true;
                textBox_conta.Enabled = true;
                textBox_gerente.Enabled = true;
                textBox_nome.Enabled = true;
                textBox_nro.Enabled = true;
                textBox_obs.Enabled = true;
                textBox_tel.Enabled = true;
                comboBox_emp.Enabled = true;

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Servico.buscarBanco(0);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bancoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void frm_banco_Load(object sender, EventArgs e)
        {
            List<Empresa> em = new List<Empresa>();
            em = Servico.buscarEmpresa(0);
            foreach (Empresa emp in em)
            {
                comboBox_emp.Items.Add(emp.Nome_empresa);
                

            }



        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            if(comboBox_filtro.SelectedIndex.Equals(0))
            {
                dataGridView1.DataSource = Servico.buscarEmpresa(textBox_pesquisa.Text);
            }else if(comboBox_filtro.SelectedIndex.Equals(1))
            {
                dataGridView1.DataSource = Servico.buscarEmpresaPorNum(Convert.ToInt64(textBox_pesquisa.Text));
            }else if(comboBox_filtro.SelectedIndex.Equals(2))
            {
                dataGridView1.DataSource = Servico.buscarEmpresaPorAg(textBox_pesquisa.Text);
            }else if(comboBox_filtro.SelectedIndex.Equals(3))
            {
                dataGridView1.DataSource = Servico.buscarEmpresaPorConta(textBox_pesquisa.Text);

            }
        }

        private void comboBox_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo cadastrar uma novo banco?", "Midas - Controle Financeiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //frmIndex frmp = new frmIndex(user);
                //Form_autenticaForne frm = new Form_autenticaForne();
                frm_banco frm = new frm_banco(true);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (!textBox_nome.Text.Length.Equals(0))
            {
                DialogResult res = MessageBox.Show("Deseja mesmo cadastrar a " + textBox_nome.Text + " como seu banco?", "Midas -  Controle Financeiro - Cadastro de bancos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    try { 
                    Banco f = new Banco();
                    f.Nome_banco = textBox_nome.Text;
                    f.Nro_banco = Convert.ToInt64(textBox_nro.Text);
                    f.Obs_banco = textBox_obs.Text;
                    f.Telefone_gerente_banco = Convert.ToInt64(textBox_tel.Text);
                    f.Ag_banco = textBox_ag.Text;
                    f.Celular_gerente_banco = Convert.ToInt64(textBox_cel.Text);
                    f.Conta_banco = textBox_conta.Text;
                    Empresa emp = new Empresa();
                    emp.Nome_empresa = comboBox_emp.SelectedItem.ToString();
                    emp.Id_empresa = Servico.buscarIdEmpresaPorNomeEmpresa(comboBox_emp.SelectedItem.ToString(),0);
                    emp.Excluido = 0;
                    f.Empresa = emp;
                    f.Gerente_banco = textBox_gerente.Text;
                    f.Excluido = 0;
                    
                        Servico.salvar(f, Program.ID_USER);
                        MessageBox.Show("Salva com sucesso!", "Midas - Controle Financeiro - Cadastro de Bancos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO - " + ex, "Midas - Controle Financeiro - Cadastro de Bancos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (textBox_nome.Text.Length.Equals(0))
            {
                MessageBox.Show("Você não pode cadastrar um banco sem ao menos ter digitado o nome.", "Midas - Controle Financeiro - Cadastro de Bancos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox_tel_TextChanged(object sender, EventArgs e)
        {
                    }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox_nro_TextChanged(object sender, EventArgs e)
        {
            if(Servico.validaNumBanco(Convert.ToInt64(textBox_nro.Text)) == false)
            {
                pictureBox_nurBanco.Image = Properties.Resources.ok;

                pictureBox_nurBanco.Visible = true;
            }
            else
            {
                pictureBox_nurBanco.Image = Properties.Resources.erro;

                pictureBox_nurBanco.Visible = true;
            }
        
        }

        private void textBox_conta_TextChanged(object sender, EventArgs e)
        {
            if (Servico.validaConta(textBox_nro.Text) == false)
            {
                pictureBox_Conta.Image = Properties.Resources.ok;

                pictureBox_Conta.Visible = true;
            }
            else
            {
                pictureBox_Conta.Image = Properties.Resources.erro;

                pictureBox_Conta.Visible = true;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (!textBox_nome.Text.Length.Equals(0))
            {
                DialogResult res = MessageBox.Show("Deseja mesmo excluir o " + textBox_nome.Text + "?", "Midas -  Controle Financeiro - Exclusão de Banco", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {

                    try
                    {

                        Servico.excluirBanco(textBox_nome.Text);
                        MessageBox.Show("Excluído com sucesso!", "Midas - Controle Financeiro - Exclusão de banco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO - " + ex, "Midas - Controle Financeiro - Exclusão de Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void obtemDadosGrid()
        {
            //obtem os dados do datagridview da linha selecionada usando as posições das colunas
            //a primeira coluna é a coluna 0 a segunda é a coluna 1 , e , assim por diante
            nome = dataGridView1[2, linhaAtual].Value.ToString();
            nro = dataGridView1[3, linhaAtual].Value.ToString();
            ag = dataGridView1[4, linhaAtual].Value.ToString();
            conta = dataGridView1[5, linhaAtual].Value.ToString();
            gerente = dataGridView1[6, linhaAtual].Value.ToString();
            tel = dataGridView1[7, linhaAtual].Value.ToString();
            cel = dataGridView1[8, linhaAtual].Value.ToString();
            obs = dataGridView1[9, linhaAtual].Value.ToString();
           // id_emp = Convert.ToInt16(dataGridView1[10, linhaAtual].Value);
            usuario = dataGridView1[10, linhaAtual].Value.ToString();
            excluido = dataGridView1[11, linhaAtual].Value.ToString();
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            obtemDadosGrid();
            tabControl1.SelectedIndex = 1;
            textBox_nome.Text = nome;
            textBox_ag.Text = ag;
            textBox_cel.Text = cel;
            textBox_conta.Text = conta;
            textBox_gerente.Text = gerente;
            textBox_nro.Text = nro;
            textBox_obs.Text = obs;
            textBox_tel.Text = tel;
            comboBox_emp.SelectedIndex = id_emp;

            DialogResult res = MessageBox.Show("Deseja editar a " + nome + "?", "Midas - Controle Financeiro - Manutenção de Bancos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                textBox_ag.Enabled = true;
                textBox_cel.Enabled = true;
                textBox_conta.Enabled = true;
                textBox_gerente.Enabled = true;
                textBox_nome.Enabled = true;
                textBox_nro.Enabled = true;
                textBox_obs.Enabled = true;
                textBox_tel.Enabled = true;
                comboBox_emp.Enabled = true;
                toolStripButton2.Enabled = true;
                toolStripButton3.Enabled = true;
            }
        }
    }
}
