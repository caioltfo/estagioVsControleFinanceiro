namespace Midas.Desktop
{
    partial class frm_banco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_banco));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_buscar = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_filtro = new System.Windows.Forms.ComboBox();
            this.textBox_pesquisa = new System.Windows.Forms.TextBox();
            this.button_todosOsBancos = new System.Windows.Forms.Button();
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_cel = new System.Windows.Forms.MaskedTextBox();
            this.textBox_tel = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox_Conta = new System.Windows.Forms.PictureBox();
            this.pictureBox_nurBanco = new System.Windows.Forms.PictureBox();
            this.comboBox_emp = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_obs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_gerente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_conta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ag = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_nro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Conta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_nurBanco)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_buscar);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 466);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_buscar
            // 
            this.tabPage_buscar.Controls.Add(this.label2);
            this.tabPage_buscar.Controls.Add(this.label1);
            this.tabPage_buscar.Controls.Add(this.comboBox_filtro);
            this.tabPage_buscar.Controls.Add(this.textBox_pesquisa);
            this.tabPage_buscar.Controls.Add(this.button_todosOsBancos);
            this.tabPage_buscar.Controls.Add(this.button_pesquisar);
            this.tabPage_buscar.Controls.Add(this.dataGridView1);
            this.tabPage_buscar.Location = new System.Drawing.Point(4, 22);
            this.tabPage_buscar.Name = "tabPage_buscar";
            this.tabPage_buscar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_buscar.Size = new System.Drawing.Size(755, 440);
            this.tabPage_buscar.TabIndex = 0;
            this.tabPage_buscar.Text = "Buscar";
            this.tabPage_buscar.UseVisualStyleBackColor = true;
            this.tabPage_buscar.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            // 
            // comboBox_filtro
            // 
            this.comboBox_filtro.FormattingEnabled = true;
            this.comboBox_filtro.Items.AddRange(new object[] {
            "Nome",
            "Número",
            "Agência",
            "Conta"});
            this.comboBox_filtro.Location = new System.Drawing.Point(46, 30);
            this.comboBox_filtro.Name = "comboBox_filtro";
            this.comboBox_filtro.Size = new System.Drawing.Size(167, 21);
            this.comboBox_filtro.TabIndex = 4;
            this.comboBox_filtro.SelectedIndexChanged += new System.EventHandler(this.comboBox_filtro_SelectedIndexChanged);
            // 
            // textBox_pesquisa
            // 
            this.textBox_pesquisa.Location = new System.Drawing.Point(238, 30);
            this.textBox_pesquisa.Name = "textBox_pesquisa";
            this.textBox_pesquisa.Size = new System.Drawing.Size(280, 20);
            this.textBox_pesquisa.TabIndex = 3;
            // 
            // button_todosOsBancos
            // 
            this.button_todosOsBancos.Location = new System.Drawing.Point(605, 31);
            this.button_todosOsBancos.Name = "button_todosOsBancos";
            this.button_todosOsBancos.Size = new System.Drawing.Size(142, 23);
            this.button_todosOsBancos.TabIndex = 2;
            this.button_todosOsBancos.Text = "Todos os bancos";
            this.button_todosOsBancos.UseVisualStyleBackColor = true;
            this.button_todosOsBancos.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.Location = new System.Drawing.Point(524, 31);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.button_pesquisar.TabIndex = 1;
            this.button_pesquisar.Text = "Buscar";
            this.button_pesquisar.UseVisualStyleBackColor = true;
            this.button_pesquisar.Click += new System.EventHandler(this.button_pesquisar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.textBox_cel);
            this.tabPage2.Controls.Add(this.textBox_tel);
            this.tabPage2.Controls.Add(this.pictureBox_Conta);
            this.tabPage2.Controls.Add(this.pictureBox_nurBanco);
            this.tabPage2.Controls.Add(this.comboBox_emp);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.textBox_obs);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox_gerente);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox_conta);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox_ag);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox_nro);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox_nome);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manutenção de bancos";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // textBox_cel
            // 
            this.textBox_cel.Enabled = false;
            this.textBox_cel.Location = new System.Drawing.Point(280, 287);
            this.textBox_cel.Mask = "(00) 00000-0000";
            this.textBox_cel.Name = "textBox_cel";
            this.textBox_cel.Size = new System.Drawing.Size(296, 20);
            this.textBox_cel.TabIndex = 26;
            this.textBox_cel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBox_tel
            // 
            this.textBox_tel.Enabled = false;
            this.textBox_tel.Location = new System.Drawing.Point(279, 243);
            this.textBox_tel.Mask = "(00) 0000-0000";
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(296, 20);
            this.textBox_tel.TabIndex = 25;
            this.textBox_tel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.textBox_tel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // pictureBox_Conta
            // 
            this.pictureBox_Conta.Image = global::Midas.Desktop.Properties.Resources.ok;
            this.pictureBox_Conta.Location = new System.Drawing.Point(581, 180);
            this.pictureBox_Conta.Name = "pictureBox_Conta";
            this.pictureBox_Conta.Size = new System.Drawing.Size(23, 20);
            this.pictureBox_Conta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Conta.TabIndex = 24;
            this.pictureBox_Conta.TabStop = false;
            this.pictureBox_Conta.Visible = false;
            // 
            // pictureBox_nurBanco
            // 
            this.pictureBox_nurBanco.Image = global::Midas.Desktop.Properties.Resources.ok;
            this.pictureBox_nurBanco.Location = new System.Drawing.Point(581, 103);
            this.pictureBox_nurBanco.Name = "pictureBox_nurBanco";
            this.pictureBox_nurBanco.Size = new System.Drawing.Size(23, 20);
            this.pictureBox_nurBanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_nurBanco.TabIndex = 23;
            this.pictureBox_nurBanco.TabStop = false;
            this.pictureBox_nurBanco.Visible = false;
            // 
            // comboBox_emp
            // 
            this.comboBox_emp.Enabled = false;
            this.comboBox_emp.FormattingEnabled = true;
            this.comboBox_emp.Location = new System.Drawing.Point(280, 359);
            this.comboBox_emp.Name = "comboBox_emp";
            this.comboBox_emp.Size = new System.Drawing.Size(295, 21);
            this.comboBox_emp.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(167, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Empresa:";
            // 
            // textBox_obs
            // 
            this.textBox_obs.Enabled = false;
            this.textBox_obs.Location = new System.Drawing.Point(280, 320);
            this.textBox_obs.Name = "textBox_obs";
            this.textBox_obs.Size = new System.Drawing.Size(295, 20);
            this.textBox_obs.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Observação:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(167, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Celular do gerente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telefone do gerente:";
            // 
            // textBox_gerente
            // 
            this.textBox_gerente.Enabled = false;
            this.textBox_gerente.Location = new System.Drawing.Point(222, 210);
            this.textBox_gerente.Name = "textBox_gerente";
            this.textBox_gerente.Size = new System.Drawing.Size(353, 20);
            this.textBox_gerente.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Gerente:";
            // 
            // textBox_conta
            // 
            this.textBox_conta.Enabled = false;
            this.textBox_conta.Location = new System.Drawing.Point(222, 180);
            this.textBox_conta.Name = "textBox_conta";
            this.textBox_conta.Size = new System.Drawing.Size(353, 20);
            this.textBox_conta.TabIndex = 8;
            this.textBox_conta.TextChanged += new System.EventHandler(this.textBox_conta_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Conta:";
            // 
            // textBox_ag
            // 
            this.textBox_ag.Enabled = false;
            this.textBox_ag.Location = new System.Drawing.Point(222, 143);
            this.textBox_ag.Name = "textBox_ag";
            this.textBox_ag.Size = new System.Drawing.Size(353, 20);
            this.textBox_ag.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Agência:";
            // 
            // textBox_nro
            // 
            this.textBox_nro.Enabled = false;
            this.textBox_nro.Location = new System.Drawing.Point(280, 103);
            this.textBox_nro.Name = "textBox_nro";
            this.textBox_nro.Size = new System.Drawing.Size(295, 20);
            this.textBox_nro.TabIndex = 4;
            this.textBox_nro.TextChanged += new System.EventHandler(this.textBox_nro_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número do banco:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Enabled = false;
            this.textBox_nome.Location = new System.Drawing.Point(211, 66);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(364, 20);
            this.textBox_nome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(749, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Midas.Desktop.Properties.Resources.icons8_plus_48;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = global::Midas.Desktop.Properties.Resources.icons8_login_arredondado_à_direita_48;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Enabled = false;
            this.toolStripButton3.Image = global::Midas.Desktop.Properties.Resources.icons8_cancel_48;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // frm_banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(763, 466);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_banco";
            this.Text = "Manutenção de bancos";
            this.Load += new System.EventHandler(this.frm_banco_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_buscar.ResumeLayout(false);
            this.tabPage_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Conta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_nurBanco)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_buscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_todosOsBancos;
        private System.Windows.Forms.Button button_pesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_filtro;
        private System.Windows.Forms.TextBox textBox_pesquisa;
        private System.Windows.Forms.PictureBox pictureBox_Conta;
        private System.Windows.Forms.PictureBox pictureBox_nurBanco;
        private System.Windows.Forms.ComboBox comboBox_emp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_obs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_gerente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_conta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_nro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.MaskedTextBox textBox_tel;
        private System.Windows.Forms.MaskedTextBox textBox_cel;
    }
}