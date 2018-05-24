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
using System.Data.SqlClient;


namespace Midas.Desktop
{
    public partial class frmIndex : Form
    {
        String _user = Program.USER;
        public frmIndex()
        {
            InitializeComponent();
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_user frm = new frm_user(false);
            frm.MdiParent = this;
            frm.Show();

        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fornecedores forn = new fornecedores(false);
            forn.MdiParent = this;
            forn.Show();
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = _user;
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void arquivoMortoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tiposDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void porNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja tira um relatório de fornecedores ordenado pela razão social?", "Midas - Controle Financeiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                frmRelatorioNomeFornecedor f = new frmRelatorioNomeFornecedor();
                f.MdiParent = this;
                f.Show();
                
            }
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_empresa frm = new frm_empresa(false);
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void fornecedoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_fornecedor_excluidos frm = new frm_fornecedor_excluidos(false);
            frm.MdiParent = this;
            frm.Show();
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_banco frm = new frm_banco(false);
            frm.MdiParent = this;
            frm.Show();

        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_doc frm = new frm_doc(false);
            frm.MdiParent = this;
            frm.Show();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_contasapagar frm = new Form_contasapagar();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
