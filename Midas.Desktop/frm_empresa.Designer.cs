namespace Midas.Desktop
{
    partial class frm_empresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_empresa));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabIndex_Consulta = new System.Windows.Forms.TabPage();
            this.textBox_pesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_todos = new System.Windows.Forms.Button();
            this.button_buscar = new System.Windows.Forms.Button();
            this.dataGridView_empresa = new System.Windows.Forms.DataGridView();
            this.tabPage_manut = new System.Windows.Forms.TabPage();
            this.pictureBox_nome = new System.Windows.Forms.PictureBox();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_add = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_salvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_excluir = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabIndex_Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_empresa)).BeginInit();
            this.tabPage_manut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_nome)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabIndex_Consulta);
            this.tabControl1.Controls.Add(this.tabPage_manut);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 402);
            this.tabControl1.TabIndex = 0;
            // 
            // tabIndex_Consulta
            // 
            this.tabIndex_Consulta.Controls.Add(this.textBox_pesquisa);
            this.tabIndex_Consulta.Controls.Add(this.label1);
            this.tabIndex_Consulta.Controls.Add(this.button_todos);
            this.tabIndex_Consulta.Controls.Add(this.button_buscar);
            this.tabIndex_Consulta.Controls.Add(this.dataGridView_empresa);
            this.tabIndex_Consulta.Location = new System.Drawing.Point(4, 22);
            this.tabIndex_Consulta.Name = "tabIndex_Consulta";
            this.tabIndex_Consulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabIndex_Consulta.Size = new System.Drawing.Size(687, 376);
            this.tabIndex_Consulta.TabIndex = 0;
            this.tabIndex_Consulta.Text = "Consulta";
            this.tabIndex_Consulta.UseVisualStyleBackColor = true;
            this.tabIndex_Consulta.Click += new System.EventHandler(this.Consulta_Click);
            // 
            // textBox_pesquisa
            // 
            this.textBox_pesquisa.Location = new System.Drawing.Point(75, 29);
            this.textBox_pesquisa.Name = "textBox_pesquisa";
            this.textBox_pesquisa.Size = new System.Drawing.Size(389, 20);
            this.textBox_pesquisa.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Empresa:";
            // 
            // button_todos
            // 
            this.button_todos.Location = new System.Drawing.Point(558, 28);
            this.button_todos.Name = "button_todos";
            this.button_todos.Size = new System.Drawing.Size(121, 23);
            this.button_todos.TabIndex = 2;
            this.button_todos.Text = "&Todos as Empresas";
            this.button_todos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_todos.UseVisualStyleBackColor = true;
            this.button_todos.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(477, 28);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(75, 23);
            this.button_buscar.TabIndex = 1;
            this.button_buscar.Text = "&Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_empresa
            // 
            this.dataGridView_empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_empresa.Location = new System.Drawing.Point(8, 67);
            this.dataGridView_empresa.Name = "dataGridView_empresa";
            this.dataGridView_empresa.Size = new System.Drawing.Size(673, 313);
            this.dataGridView_empresa.TabIndex = 0;
            this.dataGridView_empresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView_empresa.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_empresa_CellContentDoubleClick);
            // 
            // tabPage_manut
            // 
            this.tabPage_manut.Controls.Add(this.pictureBox_nome);
            this.tabPage_manut.Controls.Add(this.textBox_nome);
            this.tabPage_manut.Controls.Add(this.toolStrip1);
            this.tabPage_manut.Controls.Add(this.label3);
            this.tabPage_manut.Location = new System.Drawing.Point(4, 22);
            this.tabPage_manut.Name = "tabPage_manut";
            this.tabPage_manut.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_manut.Size = new System.Drawing.Size(687, 376);
            this.tabPage_manut.TabIndex = 1;
            this.tabPage_manut.Text = "Manutenção";
            this.tabPage_manut.UseVisualStyleBackColor = true;
            this.tabPage_manut.Click += new System.EventHandler(this.tabPage_manut_Click);
            // 
            // pictureBox_nome
            // 
            this.pictureBox_nome.Image = global::Midas.Desktop.Properties.Resources.ok;
            this.pictureBox_nome.Location = new System.Drawing.Point(569, 55);
            this.pictureBox_nome.Name = "pictureBox_nome";
            this.pictureBox_nome.Size = new System.Drawing.Size(24, 20);
            this.pictureBox_nome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_nome.TabIndex = 61;
            this.pictureBox_nome.TabStop = false;
            this.pictureBox_nome.Visible = false;
            // 
            // textBox_nome
            // 
            this.textBox_nome.Enabled = false;
            this.textBox_nome.Location = new System.Drawing.Point(120, 55);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(443, 20);
            this.textBox_nome.TabIndex = 2;
            this.textBox_nome.TextChanged += new System.EventHandler(this.textBox_nome_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_add,
            this.toolStripButton_salvar,
            this.toolStripButton_excluir});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(681, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_add
            // 
            this.toolStripButton_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_add.Image = global::Midas.Desktop.Properties.Resources.icons8_plus_481;
            this.toolStripButton_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_add.Name = "toolStripButton_add";
            this.toolStripButton_add.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_add.Text = "toolStripButton_add";
            this.toolStripButton_add.ToolTipText = "Adiconar novo fornecedor";
            this.toolStripButton_add.Click += new System.EventHandler(this.toolStripButton_add_Click);
            // 
            // toolStripButton_salvar
            // 
            this.toolStripButton_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_salvar.Enabled = false;
            this.toolStripButton_salvar.Image = global::Midas.Desktop.Properties.Resources.icons8_login_arredondado_à_direita_48;
            this.toolStripButton_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_salvar.Name = "toolStripButton_salvar";
            this.toolStripButton_salvar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_salvar.Text = "toolStripButton2";
            this.toolStripButton_salvar.ToolTipText = "Salvar o fornecedor";
            this.toolStripButton_salvar.Click += new System.EventHandler(this.toolStripButton_salvar_Click);
            // 
            // toolStripButton_excluir
            // 
            this.toolStripButton_excluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_excluir.Enabled = false;
            this.toolStripButton_excluir.Image = global::Midas.Desktop.Properties.Resources.icons8_cancel_48;
            this.toolStripButton_excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_excluir.Name = "toolStripButton_excluir";
            this.toolStripButton_excluir.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_excluir.Text = "toolStripButton2";
            this.toolStripButton_excluir.ToolTipText = "Excluir Fornecedor";
            this.toolStripButton_excluir.Click += new System.EventHandler(this.toolStripButton_excluir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome da empresa:";
            // 
            // frm_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(695, 402);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutencao de Empresa";
            this.Load += new System.EventHandler(this.frm_empresa_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabIndex_Consulta.ResumeLayout(false);
            this.tabIndex_Consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_empresa)).EndInit();
            this.tabPage_manut.ResumeLayout(false);
            this.tabPage_manut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_nome)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabIndex_Consulta;
        private System.Windows.Forms.TabPage tabPage_manut;
        private System.Windows.Forms.DataGridView dataGridView_empresa;
        private System.Windows.Forms.Button button_todos;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_pesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_add;
        private System.Windows.Forms.ToolStripButton toolStripButton_salvar;
        private System.Windows.Forms.ToolStripButton toolStripButton_excluir;
        private System.Windows.Forms.PictureBox pictureBox_nome;
    }
}