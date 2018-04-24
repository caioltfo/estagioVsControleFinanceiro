namespace Midas.Desktop
{
    partial class frmIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndex));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porDataDeLançamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porDataDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFavorecidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porValorDoTituloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porNomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCNPJCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasFísicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bancosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.configuraçãoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.movimentoToolStripMenuItem,
            this.relatoriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.documentosToolStripMenuItem,
            this.empresasToolStripMenuItem,
            this.bancosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Image = global::Midas.Desktop.Properties.Resources.icons8_conference_96;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::Midas.Desktop.Properties.Resources.icons8_circled_user_male_skin_type_6_96;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Image = global::Midas.Desktop.Properties.Resources.icons8_fornecedor_96;
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // documentosToolStripMenuItem
            // 
            this.documentosToolStripMenuItem.Image = global::Midas.Desktop.Properties.Resources.icons8_documents_folder_96;
            this.documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
            this.documentosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.documentosToolStripMenuItem.Text = "Documentos";
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.Image = global::Midas.Desktop.Properties.Resources.icons8_organization_96;
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.empresasToolStripMenuItem.Text = "Empresas";
            // 
            // bancosToolStripMenuItem
            // 
            this.bancosToolStripMenuItem.Image = global::Midas.Desktop.Properties.Resources.icons8_museum_96;
            this.bancosToolStripMenuItem.Name = "bancosToolStripMenuItem";
            this.bancosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.bancosToolStripMenuItem.Text = "Bancos";
            // 
            // movimentoToolStripMenuItem
            // 
            this.movimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasAPagarToolStripMenuItem});
            this.movimentoToolStripMenuItem.Image = global::Midas.Desktop.Properties.Resources.icons8_receipt_96;
            this.movimentoToolStripMenuItem.Name = "movimentoToolStripMenuItem";
            this.movimentoToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.movimentoToolStripMenuItem.Text = "Movimento";
            // 
            // contasAPagarToolStripMenuItem
            // 
            this.contasAPagarToolStripMenuItem.Name = "contasAPagarToolStripMenuItem";
            this.contasAPagarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.contasAPagarToolStripMenuItem.Text = "Contas a Pagar";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasAPagarToolStripMenuItem1,
            this.fornecedoresToolStripMenuItem1,
            this.usuariosToolStripMenuItem1,
            this.empresasToolStripMenuItem1,
            this.bancosToolStripMenuItem1});
            this.relatoriosToolStripMenuItem.Image = global::Midas.Desktop.Properties.Resources.icons8_presentation_96;
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // contasAPagarToolStripMenuItem1
            // 
            this.contasAPagarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porDataDeLançamentoToolStripMenuItem,
            this.porDataDePagamentoToolStripMenuItem,
            this.porFavorecidoToolStripMenuItem,
            this.porValorDoTituloToolStripMenuItem});
            this.contasAPagarToolStripMenuItem1.Name = "contasAPagarToolStripMenuItem1";
            this.contasAPagarToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.contasAPagarToolStripMenuItem1.Text = "Contas a pagar";
            // 
            // porDataDeLançamentoToolStripMenuItem
            // 
            this.porDataDeLançamentoToolStripMenuItem.Name = "porDataDeLançamentoToolStripMenuItem";
            this.porDataDeLançamentoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.porDataDeLançamentoToolStripMenuItem.Text = "Por data de lançamento";
            // 
            // porDataDePagamentoToolStripMenuItem
            // 
            this.porDataDePagamentoToolStripMenuItem.Name = "porDataDePagamentoToolStripMenuItem";
            this.porDataDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.porDataDePagamentoToolStripMenuItem.Text = "Por data de pagamento";
            // 
            // porFavorecidoToolStripMenuItem
            // 
            this.porFavorecidoToolStripMenuItem.Name = "porFavorecidoToolStripMenuItem";
            this.porFavorecidoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.porFavorecidoToolStripMenuItem.Text = "Por favorecido";
            // 
            // porValorDoTituloToolStripMenuItem
            // 
            this.porValorDoTituloToolStripMenuItem.Name = "porValorDoTituloToolStripMenuItem";
            this.porValorDoTituloToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.porValorDoTituloToolStripMenuItem.Text = "Por valor do titulo";
            // 
            // fornecedoresToolStripMenuItem1
            // 
            this.fornecedoresToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNomeToolStripMenuItem,
            this.porCNPJCPFToolStripMenuItem,
            this.pessoasFísicasToolStripMenuItem});
            this.fornecedoresToolStripMenuItem1.Name = "fornecedoresToolStripMenuItem1";
            this.fornecedoresToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.fornecedoresToolStripMenuItem1.Text = "Fornecedores";
            // 
            // porNomeToolStripMenuItem
            // 
            this.porNomeToolStripMenuItem.Name = "porNomeToolStripMenuItem";
            this.porNomeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.porNomeToolStripMenuItem.Text = "Por Nome";
            // 
            // porCNPJCPFToolStripMenuItem
            // 
            this.porCNPJCPFToolStripMenuItem.Name = "porCNPJCPFToolStripMenuItem";
            this.porCNPJCPFToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.porCNPJCPFToolStripMenuItem.Text = "Pessoas Juridicas";
            // 
            // pessoasFísicasToolStripMenuItem
            // 
            this.pessoasFísicasToolStripMenuItem.Name = "pessoasFísicasToolStripMenuItem";
            this.pessoasFísicasToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pessoasFísicasToolStripMenuItem.Text = "Pessoas Físicas";
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            // 
            // empresasToolStripMenuItem1
            // 
            this.empresasToolStripMenuItem1.Name = "empresasToolStripMenuItem1";
            this.empresasToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.empresasToolStripMenuItem1.Text = "Empresas";
            // 
            // bancosToolStripMenuItem1
            // 
            this.bancosToolStripMenuItem1.Name = "bancosToolStripMenuItem1";
            this.bancosToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.bancosToolStripMenuItem1.Text = "Bancos";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(971, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(28, 17);
            this.toolStripStatusLabel1.Text = "Olá,";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(30, 17);
            this.toolStripStatusLabel2.Text = "User";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçãoDeUsuariosToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::Midas.Desktop.Properties.Resources.icons8_conference_96;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // configuraçãoDeUsuariosToolStripMenuItem
            // 
            this.configuraçãoDeUsuariosToolStripMenuItem.Name = "configuraçãoDeUsuariosToolStripMenuItem";
            this.configuraçãoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.configuraçãoDeUsuariosToolStripMenuItem.Text = "Configuração de usuarios";
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 483);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Midas - Controle Financeiro";
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAPagarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porDataDeLançamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porDataDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFavorecidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porValorDoTituloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porNomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCNPJCPFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoasFísicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bancosToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoDeUsuariosToolStripMenuItem;
    }
}