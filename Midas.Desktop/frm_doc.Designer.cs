namespace Midas.Desktop
{
    partial class frm_doc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_doc));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_todos = new System.Windows.Forms.Button();
            this.button_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_pesquisa = new System.Windows.Forms.TextBox();
            this.dataGridView_doc = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox_descri = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_obs = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_add = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_salvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_excluir = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_descri = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doc)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_descri)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 379);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_todos);
            this.tabPage1.Controls.Add(this.button_buscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox_pesquisa);
            this.tabPage1.Controls.Add(this.dataGridView_doc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(638, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Busca";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_todos
            // 
            this.button_todos.Location = new System.Drawing.Point(498, 20);
            this.button_todos.Name = "button_todos";
            this.button_todos.Size = new System.Drawing.Size(127, 23);
            this.button_todos.TabIndex = 6;
            this.button_todos.Text = "&Todos os usuarios";
            this.button_todos.UseVisualStyleBackColor = true;
            this.button_todos.Click += new System.EventHandler(this.button_todos_Click);
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(410, 21);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(75, 23);
            this.button_buscar.TabIndex = 5;
            this.button_buscar.Text = "&buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição do documento:";
            // 
            // textBox_pesquisa
            // 
            this.textBox_pesquisa.Location = new System.Drawing.Point(143, 22);
            this.textBox_pesquisa.Name = "textBox_pesquisa";
            this.textBox_pesquisa.Size = new System.Drawing.Size(261, 20);
            this.textBox_pesquisa.TabIndex = 1;
            // 
            // dataGridView_doc
            // 
            this.dataGridView_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_doc.Location = new System.Drawing.Point(10, 69);
            this.dataGridView_doc.Name = "dataGridView_doc";
            this.dataGridView_doc.Size = new System.Drawing.Size(615, 269);
            this.dataGridView_doc.TabIndex = 0;
            this.dataGridView_doc.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_doc_CellContentDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox_descri);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox_obs);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox_descri);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(638, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manutenção de Usuario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox_descri
            // 
            this.pictureBox_descri.Image = global::Midas.Desktop.Properties.Resources.erro;
            this.pictureBox_descri.Location = new System.Drawing.Point(507, 80);
            this.pictureBox_descri.Name = "pictureBox_descri";
            this.pictureBox_descri.Size = new System.Drawing.Size(24, 20);
            this.pictureBox_descri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_descri.TabIndex = 14;
            this.pictureBox_descri.TabStop = false;
            this.pictureBox_descri.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Observação:";
            // 
            // textBox_obs
            // 
            this.textBox_obs.Enabled = false;
            this.textBox_obs.Location = new System.Drawing.Point(133, 116);
            this.textBox_obs.Name = "textBox_obs";
            this.textBox_obs.Size = new System.Drawing.Size(368, 20);
            this.textBox_obs.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_add,
            this.toolStripButton_salvar,
            this.toolStripButton_excluir});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(632, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_add
            // 
            this.toolStripButton_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_add.Image = global::Midas.Desktop.Properties.Resources.icons8_plus_482;
            this.toolStripButton_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_add.Name = "toolStripButton_add";
            this.toolStripButton_add.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_add.Text = "toolStripButton_add";
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
            this.toolStripButton_salvar.Text = "toolStripButton_salvar";
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
            this.toolStripButton_excluir.Text = "toolStripButton_excluir";
            this.toolStripButton_excluir.Click += new System.EventHandler(this.toolStripButton_excluir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descrição:";
            // 
            // textBox_descri
            // 
            this.textBox_descri.Enabled = false;
            this.textBox_descri.Location = new System.Drawing.Point(133, 80);
            this.textBox_descri.Name = "textBox_descri";
            this.textBox_descri.Size = new System.Drawing.Size(368, 20);
            this.textBox_descri.TabIndex = 0;
            this.textBox_descri.TextChanged += new System.EventHandler(this.textBox_descri_TextChanged);
            // 
            // frm_doc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(646, 379);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_doc";
            this.Text = "Manutenção de documentos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doc)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_descri)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_todos;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_pesquisa;
        private System.Windows.Forms.DataGridView dataGridView_doc;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox_descri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_obs;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_add;
        private System.Windows.Forms.ToolStripButton toolStripButton_salvar;
        private System.Windows.Forms.ToolStripButton toolStripButton_excluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_descri;
    }
}