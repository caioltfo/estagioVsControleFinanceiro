namespace Midas.Desktop
{
    partial class Form_contasapagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_contasapagar));
            this.dataGridView_movimentos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pesquisa = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_categoria = new System.Windows.Forms.ComboBox();
            this.button_pesquisa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_entrada = new System.Windows.Forms.Label();
            this.label_saida = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_todos_mov = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_total_pesquisado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bd_MidasDataSet1 = new Midas.Desktop.bd_MidasDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel_red = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_pagos = new System.Windows.Forms.Button();
            this.button_vencidos = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.button_mostrar_todos = new System.Windows.Forms.Button();
            this.button_novo_lanca = new System.Windows.Forms.Button();
            this.button_rel = new System.Windows.Forms.Button();
            this.button_baixa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_pesquisa = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_movimentos)).BeginInit();
            this.Pesquisa.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bd_MidasDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_movimentos
            // 
            this.dataGridView_movimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_movimentos.Location = new System.Drawing.Point(3, 129);
            this.dataGridView_movimentos.Name = "dataGridView_movimentos";
            this.dataGridView_movimentos.Size = new System.Drawing.Size(1024, 292);
            this.dataGridView_movimentos.TabIndex = 0;
            this.dataGridView_movimentos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_movimentos_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 13;
            // 
            // Pesquisa
            // 
            this.Pesquisa.Controls.Add(this.textBox_pesquisa);
            this.Pesquisa.Controls.Add(this.label5);
            this.Pesquisa.Controls.Add(this.label4);
            this.Pesquisa.Controls.Add(this.comboBox_categoria);
            this.Pesquisa.Controls.Add(this.button_pesquisa);
            this.Pesquisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pesquisa.Location = new System.Drawing.Point(0, 0);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(1370, 61);
            this.Pesquisa.TabIndex = 10;
            this.Pesquisa.TabStop = false;
            this.Pesquisa.Text = "Pesquisa específica";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pesquisar por:";
            // 
            // comboBox_categoria
            // 
            this.comboBox_categoria.FormattingEnabled = true;
            this.comboBox_categoria.Items.AddRange(new object[] {
            "Data lançamento",
            "Data Vencimento",
            "Favorecido"});
            this.comboBox_categoria.Location = new System.Drawing.Point(86, 20);
            this.comboBox_categoria.Name = "comboBox_categoria";
            this.comboBox_categoria.Size = new System.Drawing.Size(253, 21);
            this.comboBox_categoria.TabIndex = 12;
            this.comboBox_categoria.SelectedIndexChanged += new System.EventHandler(this.comboBox_categoria_SelectedIndexChanged);
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
            this.button_pesquisa.Location = new System.Drawing.Point(659, 7);
            this.button_pesquisa.Name = "button_pesquisa";
            this.button_pesquisa.Size = new System.Drawing.Size(116, 54);
            this.button_pesquisa.TabIndex = 11;
            this.button_pesquisa.Text = "&Pesquisar";
            this.button_pesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_pesquisa.UseVisualStyleBackColor = false;
            this.button_pesquisa.Click += new System.EventHandler(this.button_pesquisa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_entrada);
            this.groupBox2.Controls.Add(this.label_saida);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label_todos_mov);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label_total_pesquisado);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 549);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1370, 86);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label_entrada
            // 
            this.label_entrada.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_entrada.Location = new System.Drawing.Point(789, 40);
            this.label_entrada.Name = "label_entrada";
            this.label_entrada.Size = new System.Drawing.Size(189, 36);
            this.label_entrada.TabIndex = 12;
            this.label_entrada.Text = "00,00";
            // 
            // label_saida
            // 
            this.label_saida.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_saida.Location = new System.Drawing.Point(538, 40);
            this.label_saida.Name = "label_saida";
            this.label_saida.Size = new System.Drawing.Size(189, 36);
            this.label_saida.TabIndex = 11;
            this.label_saida.Text = "00,00";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(746, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 36);
            this.label15.TabIndex = 10;
            this.label15.Text = "R$:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(749, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Entradas totais:";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(493, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 36);
            this.label12.TabIndex = 7;
            this.label12.Text = "R$:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(496, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Saídas totais:";
            // 
            // label_todos_mov
            // 
            this.label_todos_mov.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_todos_mov.Location = new System.Drawing.Point(317, 40);
            this.label_todos_mov.Name = "label_todos_mov";
            this.label_todos_mov.Size = new System.Drawing.Size(189, 36);
            this.label_todos_mov.TabIndex = 5;
            this.label_todos_mov.Text = "00,00";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(274, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 36);
            this.label11.TabIndex = 4;
            this.label11.Text = "R$:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Total de todos os movimentos:";
            // 
            // label_total_pesquisado
            // 
            this.label_total_pesquisado.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_pesquisado.Location = new System.Drawing.Point(55, 40);
            this.label_total_pesquisado.Name = "label_total_pesquisado";
            this.label_total_pesquisado.Size = new System.Drawing.Size(189, 36);
            this.label_total_pesquisado.TabIndex = 2;
            this.label_total_pesquisado.Text = "00,00";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 36);
            this.label8.TabIndex = 1;
            this.label8.Text = "R$:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total dos valores dos movimentos pesquisados:";
            // 
            // bd_MidasDataSet1
            // 
            this.bd_MidasDataSet1.DataSetName = "bd_MidasDataSet";
            this.bd_MidasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.panel10);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.panel9);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.panel8);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.panel7);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.panel6);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.panel_red);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 430);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1370, 119);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Legenda:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(366, 92);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(143, 13);
            this.label25.TabIndex = 21;
            this.label25.Text = "Entrada efetuadas atrasadas";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Maroon;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Location = new System.Drawing.Point(323, 86);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(37, 19);
            this.panel10.TabIndex = 20;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(52, 92);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(176, 13);
            this.label24.TabIndex = 19;
            this.label24.Text = "Saída efetuada no prazo estipulado";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Aqua;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(9, 86);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(37, 19);
            this.panel9.TabIndex = 18;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(963, 25);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(174, 13);
            this.label23.TabIndex = 17;
            this.label23.Text = "Saída monetária efetuada atrasada";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Blue;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(920, 19);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(37, 19);
            this.panel8.TabIndex = 16;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(963, 63);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(147, 13);
            this.label22.TabIndex = 15;
            this.label22.Text = "Entrada para hoje já efetuada";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(920, 57);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(37, 19);
            this.panel7.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1186, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(194, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Entrada para hoje, ainda não efetuadas";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.YellowGreen;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(1143, 19);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(37, 19);
            this.panel6.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(719, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(186, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "Saída monetárias futuras já efetuadas";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Coral;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(659, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(37, 19);
            this.panel5.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(719, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(140, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Entrada futuras já efetuadas";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Olive;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(659, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(37, 19);
            this.panel4.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(366, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(236, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Entradas monetárias futuras, ainda não efetuada";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(323, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(37, 19);
            this.panel3.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(366, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(213, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Saída monetária futura, ainda não efetuada";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Violet;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(323, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(37, 19);
            this.panel2.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Saída monetária para hoje sem pagar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(9, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 19);
            this.panel1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Saída monetária atrasada sem efetuar pegamento";
            // 
            // panel_red
            // 
            this.panel_red.BackColor = System.Drawing.Color.Red;
            this.panel_red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_red.Location = new System.Drawing.Point(9, 19);
            this.panel_red.Name = "panel_red";
            this.panel_red.Size = new System.Drawing.Size(37, 19);
            this.panel_red.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 61);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1370, 62);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pesquisa combinada";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(734, 23);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(158, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(622, 26);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(106, 13);
            this.label27.TabIndex = 4;
            this.label27.Text = "Data de vencimento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(459, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(347, 29);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(106, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Data de lançamento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Favorecido:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button_pagos
            // 
            this.button_pagos.BackColor = System.Drawing.Color.Transparent;
            this.button_pagos.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button_pagos.FlatAppearance.BorderSize = 0;
            this.button_pagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pagos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_pagos.Image = global::Midas.Desktop.Properties.Resources.icons8_cash_in_hand_48;
            this.button_pagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_pagos.Location = new System.Drawing.Point(1050, 367);
            this.button_pagos.Name = "button_pagos";
            this.button_pagos.Size = new System.Drawing.Size(254, 54);
            this.button_pagos.TabIndex = 20;
            this.button_pagos.Text = "&Mostrar todos os lançamentos Pagos";
            this.button_pagos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_pagos.UseVisualStyleBackColor = false;
            this.button_pagos.Click += new System.EventHandler(this.button_pagos_Click);
            // 
            // button_vencidos
            // 
            this.button_vencidos.BackColor = System.Drawing.Color.Transparent;
            this.button_vencidos.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button_vencidos.FlatAppearance.BorderSize = 0;
            this.button_vencidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_vencidos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_vencidos.Image = global::Midas.Desktop.Properties.Resources.icons8_no_entry_48;
            this.button_vencidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_vencidos.Location = new System.Drawing.Point(1050, 248);
            this.button_vencidos.Name = "button_vencidos";
            this.button_vencidos.Size = new System.Drawing.Size(254, 54);
            this.button_vencidos.TabIndex = 19;
            this.button_vencidos.Text = "&Mostrar todos os lançamentos Vencidos";
            this.button_vencidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_vencidos.UseVisualStyleBackColor = false;
            this.button_vencidos.Click += new System.EventHandler(this.button_vencidos_Click);
            // 
            // button_deletar
            // 
            this.button_deletar.BackColor = System.Drawing.Color.Transparent;
            this.button_deletar.Enabled = false;
            this.button_deletar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button_deletar.FlatAppearance.BorderSize = 0;
            this.button_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deletar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_deletar.Image = global::Midas.Desktop.Properties.Resources.icons8_cancel_48;
            this.button_deletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_deletar.Location = new System.Drawing.Point(1205, 128);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(153, 54);
            this.button_deletar.TabIndex = 16;
            this.button_deletar.Text = "&Deletar movimento";
            this.button_deletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_deletar.UseVisualStyleBackColor = false;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // button_mostrar_todos
            // 
            this.button_mostrar_todos.BackColor = System.Drawing.Color.Transparent;
            this.button_mostrar_todos.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button_mostrar_todos.FlatAppearance.BorderSize = 0;
            this.button_mostrar_todos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mostrar_todos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_mostrar_todos.Image = global::Midas.Desktop.Properties.Resources.icons8_reiniciar_48;
            this.button_mostrar_todos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_mostrar_todos.Location = new System.Drawing.Point(1050, 308);
            this.button_mostrar_todos.Name = "button_mostrar_todos";
            this.button_mostrar_todos.Size = new System.Drawing.Size(215, 54);
            this.button_mostrar_todos.TabIndex = 12;
            this.button_mostrar_todos.Text = "&Mostrar todos os lançamentos";
            this.button_mostrar_todos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_mostrar_todos.UseVisualStyleBackColor = false;
            this.button_mostrar_todos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_novo_lanca
            // 
            this.button_novo_lanca.BackColor = System.Drawing.Color.Transparent;
            this.button_novo_lanca.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button_novo_lanca.FlatAppearance.BorderSize = 0;
            this.button_novo_lanca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_novo_lanca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_novo_lanca.Image = global::Midas.Desktop.Properties.Resources.icons8_login_arredondado_à_direita_482;
            this.button_novo_lanca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_novo_lanca.Location = new System.Drawing.Point(1039, 128);
            this.button_novo_lanca.Name = "button_novo_lanca";
            this.button_novo_lanca.Size = new System.Drawing.Size(147, 54);
            this.button_novo_lanca.TabIndex = 9;
            this.button_novo_lanca.Text = "&Novo lançamento";
            this.button_novo_lanca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_novo_lanca.UseVisualStyleBackColor = false;
            this.button_novo_lanca.Click += new System.EventHandler(this.button_novo_lanca_Click);
            // 
            // button_rel
            // 
            this.button_rel.BackColor = System.Drawing.Color.Transparent;
            this.button_rel.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button_rel.FlatAppearance.BorderSize = 0;
            this.button_rel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_rel.Image = global::Midas.Desktop.Properties.Resources.icons8_impressão_48;
            this.button_rel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_rel.Location = new System.Drawing.Point(1205, 188);
            this.button_rel.Name = "button_rel";
            this.button_rel.Size = new System.Drawing.Size(147, 54);
            this.button_rel.TabIndex = 8;
            this.button_rel.Text = "&Imprimir relatório";
            this.button_rel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_rel.UseVisualStyleBackColor = false;
            // 
            // button_baixa
            // 
            this.button_baixa.BackColor = System.Drawing.Color.Transparent;
            this.button_baixa.Enabled = false;
            this.button_baixa.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button_baixa.FlatAppearance.BorderSize = 0;
            this.button_baixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_baixa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_baixa.Image = global::Midas.Desktop.Properties.Resources.icons8_para_baixo_2_48;
            this.button_baixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_baixa.Location = new System.Drawing.Point(1050, 188);
            this.button_baixa.Name = "button_baixa";
            this.button_baixa.Size = new System.Drawing.Size(96, 54);
            this.button_baixa.TabIndex = 4;
            this.button_baixa.Text = "&Baixa";
            this.button_baixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_baixa.UseVisualStyleBackColor = false;
            this.button_baixa.Click += new System.EventHandler(this.button_baixa_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::Midas.Desktop.Properties.Resources.icons8_pesquisar_481;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(930, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 54);
            this.button1.TabIndex = 17;
            this.button1.Text = "&Pesquisar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox_pesquisa
            // 
            this.textBox_pesquisa.Location = new System.Drawing.Point(366, 19);
            this.textBox_pesquisa.Name = "textBox_pesquisa";
            this.textBox_pesquisa.Size = new System.Drawing.Size(268, 20);
            this.textBox_pesquisa.TabIndex = 15;
            // 
            // Form_contasapagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1370, 635);
            this.Controls.Add(this.button_pagos);
            this.Controls.Add(this.button_vencidos);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_deletar);
            this.Controls.Add(this.button_mostrar_todos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Pesquisa);
            this.Controls.Add(this.button_novo_lanca);
            this.Controls.Add(this.button_rel);
            this.Controls.Add(this.button_baixa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_movimentos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_contasapagar";
            this.Text = "Midas - Constrole Financeiro -  Contas a pagar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_movimentos)).EndInit();
            this.Pesquisa.ResumeLayout(false);
            this.Pesquisa.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bd_MidasDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_movimentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_baixa;
        private System.Windows.Forms.Button button_rel;
        private System.Windows.Forms.Button button_novo_lanca;
        private System.Windows.Forms.GroupBox Pesquisa;
        private System.Windows.Forms.Button button_pesquisa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_total_pesquisado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_mostrar_todos;
        private System.Windows.Forms.Label label_todos_mov;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private bd_MidasDataSet bd_MidasDataSet1;
        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel_red;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label_entrada;
        private System.Windows.Forms.Label label_saida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_categoria;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_vencidos;
        private System.Windows.Forms.Button button_pagos;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox textBox_pesquisa;
    }
}