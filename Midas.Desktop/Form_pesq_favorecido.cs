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
    public partial class Form_pesq_favorecido : Form
    {
        public String favorecido;
        bool listagemCompleta;
        public Form_pesq_favorecido(String favorecido)
        {
            InitializeComponent();
            if(favorecido.Length.Equals(0))
            {
                listagemCompleta = true;


                dataGridView_fornecedor.DataSource = Servico.buscarRazaoFornecedor(0);
                dataGridView_funcionario.DataSource = Servico.buscarUsuarios(0);
                List<Banco> b = new List<Banco>();
                b = Servico.buscarNomeBanco(0);
                
                datagrid_banco.DataSource = b ;

               

            }
            else
            {
                listagemCompleta = false;
                this.favorecido = favorecido;
            }
        }

        private void Form_pesq_favorecido_Load(object sender, EventArgs e)
        {

        }
    }
}
