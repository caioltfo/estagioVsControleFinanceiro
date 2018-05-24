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
    public partial class frm_doc : Form
    {
        String user = Program.USER;
        private int linhaAtual = 0;
        private string descri, obs;

        public frm_doc(bool add)
        {
            InitializeComponent();
            
            if (add == true)
            {
                
                tabControl1.SelectedIndex = 1;
                textBox_descri.Enabled = true;
                textBox_obs.Enabled = true;
                toolStripButton_salvar.Enabled = true;
               
            }
        }

        private void button_todos_Click(object sender, EventArgs e)
        {
            dataGridView_doc.DataSource = Servico.buscarDoc(0);
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            dataGridView_doc.DataSource = Servico.buscarDoc(textBox_descri.Text,0);
        }

        private void toolStripButton_add_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo cadastrar uma nova categoria de documentos?", "Midas - Controle Financeiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //frmIndex frmp = new frmIndex(user);
                //Form_autenticaForne frm = new Form_autenticaForne();
                frm_doc frm = new frm_doc(true);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.Hide();
            }
            else
            {

            }

        }

        private void toolStripButton_salvar_Click(object sender, EventArgs e)
        {
            if (!textBox_descri.Text.Length.Equals(0) && !textBox_obs.Text.Length.Equals(0))
            {
                DialogResult res = MessageBox.Show("Deseja mesmo cadastrar o " + textBox_descri.Text + " como uma categoria de documento?", "Midas -  Controle Financeiro - Cadastro de Documentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Documentos f = new Documentos();
                    f.Descricao_doc = textBox_descri.Text;
                    f.Obs_doc = textBox_obs.Text;
                    f.Excluido = 0;
                    try
                    {
                        Servico.salvar(f, Program.ID_USER);
                        MessageBox.Show("Salva com sucesso!", "Midas - Controle Financeiro - Cadastro de Dosumentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO - " + ex, "Midas - Controle Financeiro - Cadastro de Documentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (textBox_descri.Text.Length.Equals(0))
            {
                MessageBox.Show("Você não pode cadastrar um Documento sem ao menos ter digitado o nome.", "Midas - Controle Financeiro - Cadastro de Documentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox_descri_TextChanged(object sender, EventArgs e)
        {
            string nome = textBox_descri.Text;
            if (Servico.validaDescriDoc(nome) == true)
            {
                pictureBox_descri.Image = Properties.Resources.ok;

                pictureBox_descri.Visible = true;
            }
            else
            {
                pictureBox_descri.Image = Properties.Resources.erro;

                pictureBox_descri.Visible = true;
            }
        }

        private void toolStripButton_excluir_Click(object sender, EventArgs e)
        {
            if (!textBox_descri.Text.Length.Equals(0))
            {
                DialogResult res = MessageBox.Show("Deseja mesmo excluir o " + textBox_descri.Text + "?", "Midas -  Controle Financeiro - Exclusão de Empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {

                    try
                    {

                        Servico.excluirDoc(textBox_descri.Text);
                        MessageBox.Show("Excluído com sucesso!", "Midas - Controle Financeiro - Exclusão de Documentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO - " + ex, "Midas - Controle Financeiro - Cadastro de Documentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
        }
        private void obtemDadosGrid()
        {
            //obtem os dados do datagridview da linha selecionada usando as posições das colunas
            //a primeira coluna é a coluna 0 a segunda é a coluna 1 , e , assim por diante
            descri = dataGridView_doc[2, linhaAtual].Value.ToString();
            obs = dataGridView_doc[3, linhaAtual].Value.ToString();

        }
        private void dataGridView_doc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            obtemDadosGrid();
            tabControl1.SelectedIndex = 1;
            textBox_descri.Text = descri;
            textBox_obs.Text = obs;
            DialogResult res = MessageBox.Show("Deseja editar o " + descri + "?", "Midas - Controle Financeiro - Manutenção de Documentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                textBox_obs.Enabled = true;
                textBox_descri.Enabled = true;
                toolStripButton_salvar.Enabled = true;
                toolStripButton_excluir.Enabled = true;
            }
        }
    }
}
