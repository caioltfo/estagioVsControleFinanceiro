namespace Midas.Desktop
{
    partial class Form_cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_cadastro));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_salario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_nivel = new System.Windows.Forms.ComboBox();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.comboBox_empresa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cadastro de Usuario";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "________________________________________________________";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(105, 77);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(283, 20);
            this.textBox_user.TabIndex = 5;
            this.textBox_user.TextChanged += new System.EventHandler(this.textBox_user_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha:";
            // 
            // textBox_senha
            // 
            this.textBox_senha.Location = new System.Drawing.Point(105, 112);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.PasswordChar = '*';
            this.textBox_senha.Size = new System.Drawing.Size(283, 20);
            this.textBox_senha.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "E-mail:";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(106, 148);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(283, 20);
            this.textBox_email.TabIndex = 9;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Salario:";
            // 
            // textBox_salario
            // 
            this.textBox_salario.Location = new System.Drawing.Point(107, 183);
            this.textBox_salario.Name = "textBox_salario";
            this.textBox_salario.Size = new System.Drawing.Size(283, 20);
            this.textBox_salario.TabIndex = 11;
            this.textBox_salario.TextChanged += new System.EventHandler(this.textBox_salario_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nivel de Acesso:";
            // 
            // comboBox_nivel
            // 
            this.comboBox_nivel.FormattingEnabled = true;
            this.comboBox_nivel.Location = new System.Drawing.Point(155, 219);
            this.comboBox_nivel.Name = "comboBox_nivel";
            this.comboBox_nivel.Size = new System.Drawing.Size(234, 21);
            this.comboBox_nivel.TabIndex = 15;
            this.comboBox_nivel.SelectedIndexChanged += new System.EventHandler(this.comboBox_nivel_SelectedIndexChanged);
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Image = global::Midas.Desktop.Properties.Resources.icons8_login_arredondado_à_direita_48;
            this.button_cadastrar.Location = new System.Drawing.Point(17, 299);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(55, 49);
            this.button_cadastrar.TabIndex = 18;
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Image = global::Midas.Desktop.Properties.Resources.icons8_cancel_48;
            this.button_cancelar.Location = new System.Drawing.Point(440, 299);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(55, 49);
            this.button_cancelar.TabIndex = 19;
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // comboBox_empresa
            // 
            this.comboBox_empresa.FormattingEnabled = true;
            this.comboBox_empresa.Location = new System.Drawing.Point(155, 257);
            this.comboBox_empresa.Name = "comboBox_empresa";
            this.comboBox_empresa.Size = new System.Drawing.Size(234, 21);
            this.comboBox_empresa.TabIndex = 21;
            this.comboBox_empresa.SelectedIndexChanged += new System.EventHandler(this.comboBox_empresa_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Trabalha na empresa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(394, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "label_user";
            this.label9.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(395, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "label_email";
            this.label11.Visible = false;
            // 
            // Form_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(507, 363);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_empresa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_cadastrar);
            this.Controls.Add(this.comboBox_nivel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_salario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Midas - Controle Financeiro";
            this.Load += new System.EventHandler(this.Form_cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_salario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_nivel;
        private System.Windows.Forms.Button button_cadastrar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.ComboBox comboBox_empresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}