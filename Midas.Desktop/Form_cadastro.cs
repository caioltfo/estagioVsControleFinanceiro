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
using Midas.Model;
using Midas.Model.Entidades;


namespace Midas.Desktop
{
    public partial class Form_cadastro : Form
    {
        string _adm;
         public Form_cadastro(string adm)
        {
            InitializeComponent();
            _adm = adm;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_cadastro_Load(object sender, EventArgs e)
        {
            List<Empresa> em = new List<Empresa>();
            em = Servico.buscarEmpresa();
            foreach(Empresa emp in em)
            {
                comboBox_empresa.Items.Add(emp.Nome_empresa);
                
            }
            comboBox_nivel.Items.Add("Diretor");
            comboBox_nivel.Items.Add("Funcionário Administrador");
            comboBox_nivel.Items.Add("Funcionário");

            
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        

        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            if(Servico.validaEmail(textBox_email.Text) && Servico.validaUsuario(textBox_user.Text))
            {
                Usuario us = new Usuario();

                us.User_usuario = textBox_user.Text;
                us.Salario_usuario = Convert.ToDecimal(textBox_salario.Text.Replace(",", "."));
                us.Senha_usuario = textBox_senha.Text;
                us.Email_usuario = textBox_email.Text;
                us.Empresa.Id_empresa = Servico.buscarIdEmpresaPorNomeEmpresa(comboBox_empresa.SelectedText);

                Servico.salvar(us, comboBox_nivel.SelectedItem.ToString());
            }else
            {
                MessageBox.Show("Usuario já foi escolido e E-mail está inválido","Midas-Controle Finaceiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
           
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo cancelar?", "Midas - Controle Financeiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res.Equals(DialogResult.Yes))
            {
                Form_login frm = new Form_login();
                frm.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void comboBox_nivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox_email_TextChanged(object sender, EventArgs e)
        {
            if(Servico.validaEmail(textBox_email.Text))
            {
                label11.Text = "Email Válido";
                label11.ForeColor = Color.Green;
                label11.Visible = true;
            }else
            {
                label11.Text = "Email Inválido";
                label11.ForeColor = Color.Red;
                label11.Visible = true;
            }
        }

        private void textBox_salario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_user_TextChanged(object sender, EventArgs e)
        {
            if (Servico.validaUsuario(textBox_user.Text) == true)
            {
                label9.Text = "Usuario Válido";
                label9.ForeColor = Color.Green;
                label9.Visible = true;
            }
            else
            {
                label9.Text = "Usuario Inválido";
                label9.ForeColor = Color.Red;
                label9.Visible = true;
            }
        }
    }
}
