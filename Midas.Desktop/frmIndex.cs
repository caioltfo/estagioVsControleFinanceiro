using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
