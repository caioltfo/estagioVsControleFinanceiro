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
using Midas.Model.Entidades;


namespace Midas.Desktop
{
    public partial class frm_empresa : Form
    {
        Boolean add;
        String user = Program.USER;
        private int linhaAtual = 0;
        private string nome;

        public frm_empresa(bool add)
        {
            InitializeComponent();
            this.add = add;
            if (add == true)
            {
                
                tabControl1.SelectedIndex = 1;
                textBox_nome.Enabled = true;
                toolStripButton_salvar.Enabled = true;
                toolStripButton_excluir.Enabled = true;
            }
        }
        private void obtemDadosGrid()
        {
            //obtem os dados do datagridview da linha selecionada usando as posições das colunas
            //a primeira coluna é a coluna 0 a segunda é a coluna 1 , e , assim por diante
            nome = dataGridView_empresa[2, linhaAtual].Value.ToString();
            

        }
        private void frm_empresa_Load(object sender, EventArgs e)
        {

        }

        private void Consulta_Click(object sender, EventArgs e)
        {
            dataGridView_empresa.DataSource = Servico.buscarEmpresa(textBox_pesquisa.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            obtemDadosGrid();
            tabControl1.SelectedIndex = 1;
            textBox_nome.Text = nome;
            DialogResult res = MessageBox.Show("Deseja editar a " + nome + "?", "Midas - Controle Financeiro - Manutenção de Empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                textBox_nome.Enabled = true;
                toolStripButton_salvar.Enabled = true;
                toolStripButton_excluir.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView_empresa.DataSource = Servico.buscarEmpresa(textBox_pesquisa.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView_empresa.DataSource = Servico.buscarEmpresa();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void tabPage_manut_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton_salvar_Click(object sender, EventArgs e)
        {
            
            {
                if (!textBox_nome.Text.Length.Equals(0))
                {
                    DialogResult res = MessageBox.Show("Deseja mesmo cadastrar a " + textBox_nome.Text + " como sua empresa?", "Midas -  Controle Financeiro - Cadastro de Empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        Empresa f = new Empresa();
                        f.Nome_empresa = textBox_nome.Text;
                        f.Excluido = 0;
                        try
                        {
                            Servico.salvar(f, Program.ID_USER);
                            MessageBox.Show("Salva com sucesso!", "Midas - Controle Financeiro - Cadastro de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERRO - " + ex, "Midas - Controle Financeiro - Cadastro de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (textBox_nome.Text.Length.Equals(0))
                {
                    MessageBox.Show("Você não pode cadastrar uma empresa sem ao menos ter digitado o nome.", "Midas - Controle Financeiro - Cadastro de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void textBox_nome_TextChanged(object sender, EventArgs e)
        {
            string nome = textBox_nome.Text;
            if (Servico.validaDescriDoc(nome) == true)
            {
                pictureBox_nome.Image = Properties.Resources.ok;

                pictureBox_nome.Visible = true;
            }
            else
            {
                pictureBox_nome.Image = Properties.Resources.erro;

                pictureBox_nome.Visible = true;
            }
        }

        private void toolStripButton_excluir_Click(object sender, EventArgs e)
        {
            if (!textBox_nome.Text.Length.Equals(0))
            {
                DialogResult res = MessageBox.Show("Deseja mesmo excluir a " + textBox_nome.Text + "?", "Midas -  Controle Financeiro - Exclusão de Empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {

                    try
                    {

                        Servico.excluirEmp(textBox_nome.Text, Program.ID_USER);
                        MessageBox.Show("Excluído com sucesso!", "Midas - Controle Financeiro - Exclusão de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO - " + ex, "Midas - Controle Financeiro - Cadastro de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
        }

        private void toolStripButton_add_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo cadastrar uma nova empresa?", "Midas - Controle Financeiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //frmIndex frmp = new frmIndex(user);
                //Form_autenticaForne frm = new Form_autenticaForne();
                frm_empresa frm = new frm_empresa(true);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void dataGridView_empresa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
