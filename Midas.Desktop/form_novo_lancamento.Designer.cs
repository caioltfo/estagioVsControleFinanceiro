namespace Midas.Desktop
{
    partial class form_novo_lancamento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_novo_lancamento));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_favorecido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_data_lancamento = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_data_vencimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_data_pagamento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_pesq_favorecido = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_tipo_doc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_pago = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox_val = new System.Windows.Forms.MaskedTextBox();
            this.button_salvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Favorecido:";
            // 
            // textBox_favorecido
            // 
            this.textBox_favorecido.Location = new System.Drawing.Point(118, 25);
            this.textBox_favorecido.Name = "textBox_favorecido";
            this.textBox_favorecido.Size = new System.Drawing.Size(174, 20);
            this.textBox_favorecido.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBox_favorecido, "Favorecido do lançamento");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data lançamento:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker_data_lancamento
            // 
            this.dateTimePicker_data_lancamento.Location = new System.Drawing.Point(118, 51);
            this.dateTimePicker_data_lancamento.Name = "dateTimePicker_data_lancamento";
            this.dateTimePicker_data_lancamento.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker_data_lancamento.TabIndex = 3;
            this.toolTip1.SetToolTip(this.dateTimePicker_data_lancamento, "Data atual do lançamento");
            // 
            // dateTimePicker_data_vencimento
            // 
            this.dateTimePicker_data_vencimento.Location = new System.Drawing.Point(118, 77);
            this.dateTimePicker_data_vencimento.Name = "dateTimePicker_data_vencimento";
            this.dateTimePicker_data_vencimento.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker_data_vencimento.TabIndex = 5;
            this.toolTip2.SetToolTip(this.dateTimePicker_data_vencimento, "Data que irá vencer");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data vencimento:";
            // 
            // dateTimePicker_data_pagamento
            // 
            this.dateTimePicker_data_pagamento.Location = new System.Drawing.Point(118, 103);
            this.dateTimePicker_data_pagamento.Name = "dateTimePicker_data_pagamento";
            this.dateTimePicker_data_pagamento.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker_data_pagamento.TabIndex = 7;
            this.toolTip1.SetToolTip(this.dateTimePicker_data_pagamento, "Data que foi pago");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data pagamento:";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_pesq_favorecido);
            this.groupBox1.Controls.Add(this.dateTimePicker_data_vencimento);
            this.groupBox1.Controls.Add(this.dateTimePicker_data_pagamento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_favorecido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker_data_lancamento);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 149);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // button_pesq_favorecido
            // 
            this.button_pesq_favorecido.BackColor = System.Drawing.Color.Transparent;
            this.button_pesq_favorecido.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button_pesq_favorecido.FlatAppearance.BorderSize = 0;
            this.button_pesq_favorecido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pesq_favorecido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_pesq_favorecido.Image = global::Midas.Desktop.Properties.Resources.icons8_mais_241;
            this.button_pesq_favorecido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_pesq_favorecido.Location = new System.Drawing.Point(298, 19);
            this.button_pesq_favorecido.Name = "button_pesq_favorecido";
            this.button_pesq_favorecido.Size = new System.Drawing.Size(34, 27);
            this.button_pesq_favorecido.TabIndex = 12;
            this.button_pesq_favorecido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_pesq_favorecido.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_tipo_doc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(359, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 66);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // comboBox_tipo_doc
            // 
            this.comboBox_tipo_doc.FormattingEnabled = true;
            this.comboBox_tipo_doc.Location = new System.Drawing.Point(118, 29);
            this.comboBox_tipo_doc.Name = "comboBox_tipo_doc";
            this.comboBox_tipo_doc.Size = new System.Drawing.Size(214, 21);
            this.comboBox_tipo_doc.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de documento:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_pago);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.maskedTextBox_val);
            this.groupBox3.Location = new System.Drawing.Point(361, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 76);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // checkBox_pago
            // 
            this.checkBox_pago.AutoSize = true;
            this.checkBox_pago.Location = new System.Drawing.Point(15, 53);
            this.checkBox_pago.Name = "checkBox_pago";
            this.checkBox_pago.Size = new System.Drawing.Size(51, 17);
            this.checkBox_pago.TabIndex = 9;
            this.checkBox_pago.Text = "Pago";
            this.checkBox_pago.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Valor do título:";
            // 
            // maskedTextBox_val
            // 
            this.maskedTextBox_val.Location = new System.Drawing.Point(118, 19);
            this.maskedTextBox_val.Name = "maskedTextBox_val";
            this.maskedTextBox_val.Size = new System.Drawing.Size(214, 20);
            this.maskedTextBox_val.TabIndex = 0;
            // 
            // button_salvar
            // 
            this.button_salvar.BackColor = System.Drawing.Color.Transparent;
            this.button_salvar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button_salvar.FlatAppearance.BorderSize = 0;
            this.button_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_salvar.Image = global::Midas.Desktop.Properties.Resources.icons8_plus_483;
            this.button_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_salvar.Location = new System.Drawing.Point(12, 176);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(100, 54);
            this.button_salvar.TabIndex = 11;
            this.button_salvar.Text = "&Salvar";
            this.button_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_salvar.UseVisualStyleBackColor = false;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // form_novo_lancamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(714, 255);
            this.Controls.Add(this.button_salvar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_novo_lancamento";
            this.Text = "Midas - Controle Financeiro - Novo Lançamento";
            this.Load += new System.EventHandler(this.form_novo_lancamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_favorecido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_data_lancamento;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_data_vencimento;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_data_pagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_tipo_doc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox_pago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_val;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_pesq_favorecido;
    }
}