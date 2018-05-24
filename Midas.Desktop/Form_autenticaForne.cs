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
    public partial class Form_autenticaForne : Form
    {
        public Form_autenticaForne()
        {
            InitializeComponent();
        }

        private void Form_autenticaForne_Load(object sender, EventArgs e)
        {
            
        }
        private void button_entrar_Click(object sender, EventArgs e)
        {
            List<Usuario> user = new List<Usuario>();
            user = Servico.buscarUsuarios(1);
            foreach (Usuario u in user)
            {
                if (u.User_usuario.Equals(textBox_adm.Text))
                {
                    if (u.Senha_usuario.Equals(textBox_senha.Text))
                    {
                        fornecedores frm = new fornecedores(true);
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta", "Midas - Controle Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario incorreta", "Midas - Controle Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo cancelar?", "Midas - Controle Financeiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res.Equals(DialogResult.Yes))
            {
                this.Hide();
            }
            else
            {

            }
        }
    }
}
