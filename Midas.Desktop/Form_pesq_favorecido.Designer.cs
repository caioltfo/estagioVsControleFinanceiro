namespace Midas.Desktop
{
    partial class Form_pesq_favorecido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_pesq_favorecido));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_favorecido = new System.Windows.Forms.TextBox();
            this.button_pesquisa = new System.Windows.Forms.Button();
            this.dataGridView_fornecedor = new System.Windows.Forms.DataGridView();
            this.datagrid_banco = new System.Windows.Forms.DataGridView();
            this.dataGridView_funcionario = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_funcionario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_pesquisa);
            this.groupBox1.Controls.Add(this.textBox_favorecido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Favorecido:";
            // 
            // textBox_favorecido
            // 
            this.textBox_favorecido.Location = new System.Drawing.Point(109, 30);
            this.textBox_favorecido.Name = "textBox_favorecido";
            this.textBox_favorecido.Size = new System.Drawing.Size(351, 20);
            this.textBox_favorecido.TabIndex = 1;
            // 
            // button_pesquisa
            // 
            this.button_pesquisa.BackColor = System.Drawing.Color.Transparent;
            this.button_pesquisa.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button_pesquisa.FlatAppearance.BorderSize = 0;
            this.button_pesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pesquisa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_pesquisa.Image = global::Midas.Desktop.Properties.Resources.icons8_pesquisar_481;
            this.button_pesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_pesquisa.Location = new System.Drawing.Point(483, 12);
            this.button_pesquisa.Name = "button_pesquisa";
            this.button_pesquisa.Size = new System.Drawing.Size(122, 54);
            this.button_pesquisa.TabIndex = 12;
            this.button_pesquisa.Text = "&Pesquisar";
            this.button_pesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_pesquisa.UseVisualStyleBackColor = false;
            // 
            // dataGridView_fornecedor
            // 
            this.dataGridView_fornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_fornecedor.Location = new System.Drawing.Point(12, 99);
            this.dataGridView_fornecedor.Name = "dataGridView_fornecedor";
            this.dataGridView_fornecedor.Size = new System.Drawing.Size(623, 150);
            this.dataGridView_fornecedor.TabIndex = 1;
            // 
            // datagrid_banco
            // 
            this.datagrid_banco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_banco.Location = new System.Drawing.Point(12, 255);
            this.datagrid_banco.Name = "datagrid_banco";
            this.datagrid_banco.Size = new System.Drawing.Size(623, 150);
            this.datagrid_banco.TabIndex = 2;
            // 
            // dataGridView_funcionario
            // 
            this.dataGridView_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_funcionario.Location = new System.Drawing.Point(12, 411);
            this.dataGridView_funcionario.Name = "dataGridView_funcionario";
            this.dataGridView_funcionario.Size = new System.Drawing.Size(623, 150);
            this.dataGridView_funcionario.TabIndex = 3;
            // 
            // Form_pesq_favorecido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(647, 578);
            this.Controls.Add(this.dataGridView_funcionario);
            this.Controls.Add(this.datagrid_banco);
            this.Controls.Add(this.dataGridView_fornecedor);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_pesq_favorecido";
            this.Text = "Pesquisar Favorecido";
            this.Load += new System.EventHandler(this.Form_pesq_favorecido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_funcionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_favorecido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_pesquisa;
        private System.Windows.Forms.DataGridView dataGridView_fornecedor;
        private System.Windows.Forms.DataGridView datagrid_banco;
        private System.Windows.Forms.DataGridView dataGridView_funcionario;
    }
}