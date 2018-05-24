using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midas.Model.Servico;
using Midas.Model.Entidades;
using System.Windows.Forms;

namespace Midas.Desktop
{
    public partial class frm_user : Form
    {
        Boolean add;
        String user = Program.USER;
        private int linhaAtual = 0;
        private string senha, email;

        public frm_user(bool add)
        {

            InitializeComponent();
            this.add = add;
            if (add == true)
            {

                tabControl1.SelectedIndex = 1;
                textBox_email.Enabled = true;
                textBox_empresa.Enabled = true;
                comboBox_nivel.Enabled = true;
                textBox_senha.Enabled = true;
                textBox_user.Enabled = true;
                
                toolStripButton2.Enabled = true;


            }
        }

        private void button_todos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Servico.buscarUsuarios(0);
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            if (comboBox_filtro.SelectedIndex.Equals(0))
            {
                dataGridView1.DataSource = Servico.buscarUsuariosPorNome(textBox_pesquisa.Text, 0);
            }
            else
            {
                dataGridView1.DataSource = Servico.buscarUsuariosPorEmail(textBox_email.Text, 0);
            }

        }

        private void frm_user_Load(object sender, EventArgs e)
        {
            comboBox_nivel.Items.Add("Diretor");
            comboBox_nivel.Items.Add("Funcionário Administrador");
            comboBox_nivel.Items.Add("Funcionário");

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            List<Usuario> us = new List<Usuario>();
            us = Servico.buscarUsuarios(0);
            foreach (Usuario user in us)
            {
                if (!textBox_user.Text.Length.Equals(0) && textBox_empresa.Text.Length.Equals(us))
                {
                    DialogResult res = MessageBox.Show("Deseja mesmo cadastrar o " + textBox_user.Text + " como seu usuário?", "Midas -  Controle Financeiro - Cadastro de Empresa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        Usuario f = new Usuario();
                        f.User_usuario = textBox_user.Text;
                        f.Email_usuario = textBox_email.Text;
                        f.Salario_usuario = Convert.ToInt64(textBox_Sal.Text.ToString().Replace(",","."));
                        f.Senha_usuario = textBox_senha.Text;
                        
                        
                        f.Excluido = 0;
                        try
                        {
                           // Servico.salvar(f,comboBox_nivel.SelectedIndex);
                            MessageBox.Show("Salva com sucesso!", "Midas - Controle Financeiro - Cadastro de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERRO - " + ex, "Midas - Controle Financeiro - Cadastro de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                }
                else
                {
                    MessageBox.Show("Você deve adicionar um e-mail válido e deve digitar algum usuário", "Midas - Controle Financeiro - Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo cadastrar uma novo usuário?", "Midas - Controle Financeiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //frmIndex frmp = new frmIndex(user);
                //Form_autenticaForne frm = new Form_autenticaForne();
                frm_user frm = new frm_user(true);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.Hide();
            }

        }
    }
}
