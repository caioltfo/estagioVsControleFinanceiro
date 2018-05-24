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
using Midas.Model;




namespace Midas.Desktop
{
    public partial class Form_login : Form
    {
        
        public string _USER;
        public Form_login()
        {
            InitializeComponent();
        }
        public void OpenForm(Type frmType)
        {
            var bolCtl = false;
            foreach (var form in Application.OpenForms.Cast<System.Windows.Forms.Form>().Where(form => form.GetType() == frmType))
            {
                form.Focus();
                bolCtl = true;
                break;
            }

            if (bolCtl) return;
            var frm = (System.Windows.Forms.Form)Activator.CreateInstance(frmType);
            frm.MdiParent = this;
            frm.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo sair?", "Midas - Controle Financeiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }else
            {

            }

        }
        private void pegarId(string senha)
        {

        }
      
        private void button_entrar_Click(object sender, EventArgs e)
        {
            _USER = textBox_user.Text;
            Program.USER = _USER;
            string senha = textBox_senha.Text;
            List<Usuario> u = new List<Usuario>();
            u = Servico.buscarUsuarios(1);
            foreach(Usuario us in u)
            {
                
                if(us.Senha_usuario.Equals(senha) && us.User_usuario.Equals(_USER))
                {
                    Program.ID_USER = us.Id_usuario;
                    frmIndex frm = new frmIndex();
                    frm.Show();
                    this.Hide();

                }else if(!us.Senha_usuario.Equals(senha))
                {
                    MessageBox.Show("Senha está incorreta","Midas - Controle Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else if(!us.User_usuario.Equals(_USER))
                {
                    MessageBox.Show("Usuario está incorreto", "Midas - Controle Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    MessageBox.Show("Usuario e senha estam incorretos", "Midas - Controle Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button_cadas_Click(object sender, EventArgs e)
        {
            
            frm_autentica frm = new frm_autentica();
            frm.Show();
            this.Hide();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox_senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
