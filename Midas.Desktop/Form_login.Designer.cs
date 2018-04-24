namespace Midas.Desktop
{
    partial class Form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.button_entrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_cadas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_user = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Controle de Acesso";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuário: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Senha:";
            // 
            // textBox_senha
            // 
            this.textBox_senha.Location = new System.Drawing.Point(101, 182);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.PasswordChar = '*';
            this.textBox_senha.Size = new System.Drawing.Size(380, 20);
            this.textBox_senha.TabIndex = 6;
            this.textBox_senha.TextChanged += new System.EventHandler(this.textBox_senha_TextChanged);
            // 
            // button_entrar
            // 
            this.button_entrar.Image = global::Midas.Desktop.Properties.Resources.icons8_login_arredondado_à_direita_48;
            this.button_entrar.Location = new System.Drawing.Point(30, 236);
            this.button_entrar.Name = "button_entrar";
            this.button_entrar.Size = new System.Drawing.Size(58, 55);
            this.button_entrar.TabIndex = 10;
            this.button_entrar.UseVisualStyleBackColor = true;
            this.button_entrar.Click += new System.EventHandler(this.button_entrar_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Midas.Desktop.Properties.Resources.icons8_cancel_48;
            this.button2.Location = new System.Drawing.Point(94, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 55);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_cadas
            // 
            this.button_cadas.Image = global::Midas.Desktop.Properties.Resources.icons8_plus_48;
            this.button_cadas.Location = new System.Drawing.Point(158, 236);
            this.button_cadas.Name = "button_cadas";
            this.button_cadas.Size = new System.Drawing.Size(62, 55);
            this.button_cadas.TabIndex = 8;
            this.button_cadas.UseVisualStyleBackColor = true;
            this.button_cadas.Click += new System.EventHandler(this.button_cadas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Midas.Desktop.Properties.Resources.icons8_senha_96;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Entrar";
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipTitle = "Cancelar";
            // 
            // toolTip3
            // 
            this.toolTip3.ToolTipTitle = "Cadastrar Novo Usuario (Somente Administrador)";
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(100, 141);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(380, 20);
            this.textBox_user.TabIndex = 11;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(509, 303);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.button_entrar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_cadas);
            this.Controls.Add(this.textBox_senha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Midas - Controle de Finanças";
            this.Load += new System.EventHandler(this.Form_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.Button button_cadas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_entrar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.TextBox textBox_user;
    }
}