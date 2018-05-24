using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midas.Model.Servico;
using Midas.Model.Entidades;
using Midas.Model.Suporte;
using System.Data.SqlClient;



namespace Midas.Desktop
{
    public partial class Form_contasapagar : Form
    {
        public int pago = 0;
        public int vencido = 0;
        public Decimal valTotaisEspecificos = 0;
        public Decimal valTotaisGeral = 0;
        public Decimal valPago = 0;
        public Decimal valRecebidos = 0;
        public decimal aux;

        public Form_contasapagar()
        {
            InitializeComponent();
        }
        private void  somarTotaisPagos()
        {
            aux = 0;
            foreach (DataGridViewRow col in dataGridView_movimentos.Rows)
            {
                if(Convert.ToInt16(col.Cells[10].Value) == 1 && Convert.ToDecimal(col.Cells[6].Value) < 0)
                {
                    aux = aux + Convert.ToDecimal(col.Cells[6].Value);
                }
                
            }
            valPago = aux;
            label_saida.Text = valPago.ToString();
            if(valPago < 0)
            {
                label_saida.ForeColor = Color.Red;
            }else
            {
                label_saida.ForeColor = Color.Green;
            }

        }
        private void somarTotaisRecebidos()
        {
            aux = 0;
            foreach (DataGridViewRow col in dataGridView_movimentos.Rows)
            {
                if (Convert.ToInt16(col.Cells[10].Value) == 1 && Convert.ToDecimal(col.Cells[6].Value) > 0)
                {
                    aux = aux + Convert.ToDecimal(col.Cells[6].Value);
                }

            }
            valRecebidos = aux;
            label_entrada.Text = valRecebidos.ToString();
            if (valRecebidos < 0)
            {
               label_entrada.ForeColor = Color.Red;
            }
            else
            {
                label_entrada.ForeColor = Color.Green;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        public List<Mov_lancamento> atualizarTodos()
        {
            SqlDataReader dr = ConexaoBanco.selecionar("SELECT id_lancamento, data_lancamento, data_vencimento, tipo_documento, favorecido, data_pagamento, valor_do_titulo, pago FROM mov_lancamento WHERE excluido = 0 ");
            List<Mov_lancamento> mov = new List<Mov_lancamento>();
            while (dr.Read())
            {
                Mov_lancamento movi = new Mov_lancamento();
                movi.Id_lancamento = Convert.ToInt16(dr["id_lancamento"]);
                movi.Data_lancamento = Convert.ToDateTime(dr["data_lancamento"]);
                movi.Data_vencimento = Convert.ToDateTime(dr["data_vencimento"]);

                movi.Data_pagamento = Convert.ToDateTime(dr["data_pagamento"]);
                // movi.Documento.Id_doc = Convert.ToInt16(dr["tipo_documento"]);
                movi.Favorecido = dr["favorecido"].ToString();
                movi.Valor_do_titulo = Convert.ToInt64(dr["valor_do_titulo"]);
                movi.Pago = Convert.ToInt16(dr["pago"]);
                mov.Add(movi);

            }
            dr.Close();
            return mov;
        }
        public List<Mov_lancamento> atualizarTodosVencidos()
        {
            SqlDataReader dr = ConexaoBanco.selecionar("SELECT id_lancamento, data_lancamento, data_vencimento, tipo_documento, favorecido, data_pagamento, valor_do_titulo, pago FROM mov_lancamento WHERE excluido = 0 AND data_vencimento < '" + DateTime.Now +"' AND pago = 0");
            List<Mov_lancamento> mov = new List<Mov_lancamento>();
            while (dr.Read())
            {
                Mov_lancamento movi = new Mov_lancamento();
                movi.Id_lancamento = Convert.ToInt16(dr["id_lancamento"]);
                movi.Data_lancamento = Convert.ToDateTime(dr["data_lancamento"]);
                movi.Data_vencimento = Convert.ToDateTime(dr["data_vencimento"]);

                movi.Data_pagamento = Convert.ToDateTime(dr["data_pagamento"]);
                // movi.Documento.Id_doc = Convert.ToInt16(dr["tipo_documento"]);
                movi.Favorecido = dr["favorecido"].ToString();
                movi.Valor_do_titulo = Convert.ToInt64(dr["valor_do_titulo"]);
                movi.Pago = Convert.ToInt16(dr["pago"]);
                mov.Add(movi);

            }
            dr.Close();
            return mov;
        }
        public List<Mov_lancamento> atualizarTodosPagos()
        {
            SqlDataReader dr = ConexaoBanco.selecionar("SELECT id_lancamento, data_lancamento, data_vencimento, tipo_documento, favorecido, data_pagamento, valor_do_titulo, pago FROM mov_lancamento WHERE excluido = 0 AND  pago = 1");
            List<Mov_lancamento> mov = new List<Mov_lancamento>();
            while (dr.Read())
            {
                Mov_lancamento movi = new Mov_lancamento();
                movi.Id_lancamento = Convert.ToInt16(dr["id_lancamento"]);
                movi.Data_lancamento = Convert.ToDateTime(dr["data_lancamento"]);
                movi.Data_vencimento = Convert.ToDateTime(dr["data_vencimento"]);

                movi.Data_pagamento = Convert.ToDateTime(dr["data_pagamento"]);
                // movi.Documento.Id_doc = Convert.ToInt16(dr["tipo_documento"]);
                movi.Favorecido = dr["favorecido"].ToString();
                movi.Valor_do_titulo = Convert.ToInt64(dr["valor_do_titulo"]);
                movi.Pago = Convert.ToInt16(dr["pago"]);
                mov.Add(movi);

            }
            dr.Close();
            return mov;
        }
        public void somarTotais(Boolean especificar)
        {
            
            if(especificar == false)
            {
                label_total_pesquisado.Text = "0,00";
                valPago = Convert.ToDecimal(label_saida.Text);
                valRecebidos = Convert.ToDecimal(label_entrada.Text);

                valTotaisGeral = valRecebidos + valPago;
                label_todos_mov.Text = valTotaisGeral.ToString();
                valTotaisGeral = 0;
                valPago = 0;
                valRecebidos = 0;
                aux = 0;
            }
            else
            {
                label_total_pesquisado.Text = "0,00";
                foreach (DataGridViewRow col in dataGridView_movimentos.Rows)
                {
                    aux = aux + Convert.ToDecimal(col.Cells[6].Value);
                }
                valTotaisEspecificos = aux;
                label_total_pesquisado.Text = valTotaisEspecificos.ToString();
                if (valTotaisEspecificos <= 0)
                {
                    label_total_pesquisado.ForeColor = Color.Red;
                }
                else
                {
                    label_total_pesquisado.ForeColor = Color.Green;
                }
                valTotaisEspecificos = 0;
                aux = 0;
            }
           

            
            
            
            
            
        }
        private void pintarCelulas()
        {
            foreach (DataGridViewRow row in dataGridView_movimentos.Rows)
            {
                if (Convert.ToDateTime(row.Cells["data_vencimento"].Value) < DateTime.Now && (decimal)row.Cells["valor_do_titulo"].Value < 0 && Convert.ToInt16(row.Cells["pago"].Value) == 0)
                {
                    row.Cells["data_vencimento"].Style.BackColor = Color.Red; // se está atrasado a saida  sem pagar
                    row.Cells["pago"].Style.BackColor = Color.Red; 
                    row.Cells["data_pagamento"].Style.BackColor = Color.Red;
                    row.Cells["id_lancamento"].Style.BackColor = Color.Red;
                    row.Cells["favorecido"].Style.BackColor = Color.Red;
                    row.Cells["excluido"].Style.BackColor = Color.Red;
                    row.Cells["valor_do_titulo"].Style.BackColor = Color.Red;
                    row.Cells["pago"].Style.BackColor = Color.Red;
                }
                if (Convert.ToDateTime(row.Cells["data_vencimento"].Value) == DateTime.Now && (decimal)row.Cells["valor_do_titulo"].Value < 0 && Convert.ToInt16(row.Cells["pago"].Value) == 0)
                {
                    row.Cells["data_vencimento"].Style.BackColor = Color.Yellow; // saida para hj sem pagar
                    row.Cells["pago"].Style.BackColor = Color.Yellow;
                    row.Cells["data_pagamento"].Style.BackColor = Color.Yellow;
                    row.Cells["id_lancamento"].Style.BackColor = Color.Yellow;
                    row.Cells["favorecido"].Style.BackColor = Color.Yellow;
                    row.Cells["excluido"].Style.BackColor = Color.Yellow;
                    row.Cells["valor_do_titulo"].Style.BackColor = Color.Yellow;
                    row.Cells["pago"].Style.BackColor = Color.Yellow;
                }
                if (Convert.ToDateTime(row.Cells["data_vencimento"].Value) > DateTime.Now && (decimal)row.Cells["valor_do_titulo"].Value < 0 && Convert.ToInt16(row.Cells["pago"].Value) == 0)
                {
                    row.Cells["data_vencimento"].Style.BackColor = Color.Violet; // saida para depois sem pagar
                    row.Cells["pago"].Style.BackColor = Color.Violet;
                    row.Cells["data_pagamento"].Style.BackColor = Color.Violet;
                    row.Cells["id_lancamento"].Style.BackColor = Color.Violet;
                    row.Cells["favorecido"].Style.BackColor = Color.Violet;
                    row.Cells["excluido"].Style.BackColor = Color.Violet;
                    row.Cells["valor_do_titulo"].Style.BackColor = Color.Violet;
                    row.Cells["pago"].Style.BackColor = Color.Violet;
                }
                if (Convert.ToDateTime(row.Cells["data_vencimento"].Value) > DateTime.Now && (decimal)row.Cells["valor_do_titulo"].Value > 0 && Convert.ToInt16(row.Cells["pago"].Value) == 0)
                {
                    row.Cells["data_vencimento"].Style.BackColor = Color.Orange; // entrada para depois sem pagar
                    row.Cells["pago"].Style.BackColor = Color.Orange;
                    row.Cells["data_pagamento"].Style.BackColor = Color.Orange;
                    row.Cells["id_lancamento"].Style.BackColor = Color.Orange;
                    row.Cells["favorecido"].Style.BackColor = Color.Orange;
                    row.Cells["excluido"].Style.BackColor = Color.Orange;
                    row.Cells["valor_do_titulo"].Style.BackColor = Color.Orange;
                    row.Cells["pago"].Style.BackColor = Color.Orange;
                }
                if (Convert.ToDateTime(row.Cells["data_vencimento"].Value) > DateTime.Now && (decimal)row.Cells["valor_do_titulo"].Value < 0 && Convert.ToInt16(row.Cells["pago"].Value) == 1)
                {
                    row.Cells["data_vencimento"].Style.BackColor = Color.Coral; // saida para depois já pagas
                    row.Cells["pago"].Style.BackColor = Color.Coral;
                    row.Cells["data_pagamento"].Style.BackColor = Color.Coral;
                    row.Cells["id_lancamento"].Style.BackColor = Color.Coral;
                    row.Cells["favorecido"].Style.BackColor = Color.Coral;
                    row.Cells["excluido"].Style.BackColor = Color.Coral;
                    row.Cells["valor_do_titulo"].Style.BackColor = Color.Coral;
                    row.Cells["pago"].Style.BackColor = Color.Coral;
                }
                if (Convert.ToDateTime(row.Cells["data_vencimento"].Value) > DateTime.Now && (decimal)row.Cells["valor_do_titulo"].Value > 0 && Convert.ToInt16(row.Cells["pago"].Value) == 1)
                {
                    row.Cells["data_vencimento"].Style.BackColor = Color.Olive; // entrada para depois já pagas
                    row.Cells["pago"].Style.BackColor = Color.Olive;
                    row.Cells["data_pagamento"].Style.BackColor = Color.Olive;
                    row.Cells["id_lancamento"].Style.BackColor = Color.Olive;
                    row.Cells["favorecido"].Style.BackColor = Color.Olive;
                    row.Cells["excluido"].Style.BackColor = Color.Olive;
                    row.Cells["valor_do_titulo"].Style.BackColor = Color.Olive;
                    row.Cells["pago"].Style.BackColor = Color.Olive;
                }
                if (Convert.ToDateTime(row.Cells["data_vencimento"].Value) == DateTime.Now && (decimal)row.Cells["valor_do_titulo"].Value > 0 && Convert.ToInt16(row.Cells["pago"].Value) == 0)
                {
                    row.Cells["data_vencimento"].Style.BackColor = Color.YellowGreen; // entrada para hj sem pagar
                    row.Cells["pago"].Style.BackColor = Color.YellowGreen;
                    row.Cells["data_pagamento"].Style.BackColor = Color.YellowGreen;
                    row.Cells["id_lancamento"].Style.BackColor = Color.YellowGreen;
                    row.Cells["favorecido"].Style.BackColor = Color.YellowGreen;
                    row.Cells["excluido"].Style.BackColor = Color.YellowGreen;
                    row.Cells["valor_do_titulo"].Style.BackColor = Color.YellowGreen;
                    row.Cells["pago"].Style.BackColor = Color.YellowGreen;
                }
                if (Convert.ToDateTime(row.Cells["data_vencimento"].Value) == DateTime.Now && (decimal)row.Cells["valor_do_titulo"].Value > 0 && Convert.ToInt16(row.Cells["pago"].Value) == 1)
                {
                    row.Cells["data_vencimento"].Style.BackColor = Color.DimGray; // entrada para hj ja paga
                    row.Cells["pago"].Style.BackColor = Color.DimGray;
                    row.Cells["data_pagamento"].Style.BackColor = Color.DimGray;
                    row.Cells["id_lancamento"].Style.BackColor = Color.DimGray;
                    row.Cells["favorecido"].Style.BackColor = Color.DimGray;
                    row.Cells["excluido"].Style.BackColor = Color.DimGray;
                    row.Cells["valor_do_titulo"].Style.BackColor = Color.DimGray;
                    row.Cells["pago"].Style.BackColor = Color.DimGray;
                }
                if (Convert.ToDateTime(row.Cells["data_vencimento"].Value) < Convert.ToDateTime(row.Cells["data_pagamento"].Value) && Convert.ToInt16(row.Cells["pago"].Value) == 1 &&  Convert.ToDecimal(row.Cells["valor_do_titulo"].Value) < 0)
                {
                    row.Cells["pago"].Style.BackColor = Color.Blue; // se for pago a saida atrasado
                    row.Cells["data_vencimento"].Style.BackColor = Color.Blue;
                    row.Cells["id_lancamento"].Style.BackColor = Color.Blue;
                    row.Cells["data_pagamento"].Style.BackColor = Color.Blue;
                    row.Cells["favorecido"].Style.BackColor = Color.Blue;
                    row.Cells["excluido"].Style.BackColor = Color.Blue;
                   
                    row.Cells["valor_do_titulo"].Style.BackColor = Color.Blue;
                    row.Cells["pago"].Style.BackColor = Color.Blue;
                    
                }
                if (Convert.ToDateTime(row.Cells["data_vencimento"].Value) >= Convert.ToDateTime(row.Cells["data_pagamento"].Value) && Convert.ToInt16(row.Cells["pago"].Value) == 1 && Convert.ToDecimal(row.Cells["valor_do_titulo"].Value) < 0)
                {
                    row.Cells["pago"].Style.BackColor = Color.Aqua; // se for pago a saida sem estar atrasado
                    row.Cells["data_vencimento"].Style.BackColor = Color.Aqua;
                    row.Cells["id_lancamento"].Style.BackColor = Color.Aqua;
                    row.Cells["data_pagamento"].Style.BackColor = Color.Aqua;
                    row.Cells["favorecido"].Style.BackColor = Color.Aqua;
                    row.Cells["excluido"].Style.BackColor = Color.Aqua;

                    row.Cells["valor_do_titulo"].Style.BackColor = Color.Aqua;
                    row.Cells["pago"].Style.BackColor = Color.Aqua;

                }
                if (Convert.ToDateTime(row.Cells["data_vencimento"].Value) < Convert.ToDateTime(row.Cells["data_pagamento"].Value) && Convert.ToInt16(row.Cells["pago"].Value) == 1 && Convert.ToDecimal(row.Cells["valor_do_titulo"].Value) > 0)
                {
                    row.Cells["pago"].Style.BackColor = Color.Maroon; // entrada efetuada atrsada
                    row.Cells["data_vencimento"].Style.BackColor = Color.Maroon;
                    row.Cells["id_lancamento"].Style.BackColor = Color.Maroon;
                    row.Cells["data_pagamento"].Style.BackColor = Color.Maroon;
                    row.Cells["favorecido"].Style.BackColor = Color.Maroon;
                    row.Cells["excluido"].Style.BackColor = Color.Maroon;

                    row.Cells["valor_do_titulo"].Style.BackColor = Color.Maroon;
                    row.Cells["pago"].Style.BackColor = Color.Maroon;

                }

            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
           
            dataGridView_movimentos.DataSource = atualizarTodos();

            somarTotaisRecebidos();
           
            somarTotaisPagos();
            somarTotais(false);
            pintarCelulas();
            
        }
           

        private void button_novo_lanca_Click(object sender, EventArgs e)
        {
            form_novo_lancamento frm = new form_novo_lancamento();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void pictureBox_pesquisa_Click(object sender, EventArgs e)
        {
            Form_pesq_favorecido frm = new Form_pesq_favorecido(textBox1.Text);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
        
        private void button_pesquisa_Click(object sender, EventArgs e)
        {
           if(comboBox_categoria.SelectedIndex == 0)
            {
                dataGridView_movimentos.DataSource = Servico.buscarMov_lancamentoPorDataLancamento(Convert.ToDateTime(textBox_pesquisa.Text),0);
                pintarCelulas();
                somarTotais(true);
                
            }else if(comboBox_categoria.SelectedIndex == 1)
            {
                dataGridView_movimentos.DataSource = Servico.buscarMov_lancamentoPorDataVencimento(Convert.ToDateTime(textBox_pesquisa.Text), 0);
                pintarCelulas();
                somarTotais(true);
            }
           else if(comboBox_categoria.SelectedIndex == 2)
            {
                dataGridView_movimentos.DataSource = Servico.buscarMov_lancamentoPorFavorecido(textBox_pesquisa.Text, 0);
                pintarCelulas();
                somarTotais(true);
            }
           
           
        }
        public String favorecido;
        public DataGridViewRow row;
        private void button_baixa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo dar baixa no movimento do favorecido " + favorecido + " ?", "Midas - Controle Financeiro - Movimentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                
                ConexaoBanco.executar("UPDATE mov_lancamento SET pago = 1, data_pagamento =  '" + Convert.ToDateTime(DateTime.Now) + "' WHERE id_lancamento = " + Convert.ToInt16(dataGridView_movimentos.CurrentRow.Cells[1].Value));
                MessageBox.Show("Movimento pago na data: "+DateTime.Now+" com sucesso!", "Midas - Controle Financeiro - Movimentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizarTodos();
                button_baixa.Enabled =false;
                button_deletar.Enabled = false;
            }
            else
            {
                button_baixa.Enabled = false;
                button_deletar.Enabled = false;
            }
        }
        
        private void dataGridView_movimentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button_baixa.Enabled = true;
            button_deletar.Enabled = true;
            button_baixa.Focus();
            favorecido = dataGridView_movimentos.CurrentRow.Cells[2].Value.ToString();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo deletar o movimento do favorecido " + favorecido + " ?", "Midas - Controle Financeiro - Movimentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                button_deletar.Enabled = false;
               Servico.excluirMov(Convert.ToInt64(dataGridView_movimentos.CurrentRow.Cells[1].Value));
               MessageBox.Show("Movimento excluido com sucesso", "Midas - Controle Financeiro - Movimentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
               atualizarTodos();
            }
            else
            {
                button_deletar.Enabled = false;
            }
           
        }

        private void button_vencidos_Click(object sender, EventArgs e)
        {
            dataGridView_movimentos.DataSource = atualizarTodosVencidos();
            pintarCelulas();
        }

        private void button_pagos_Click(object sender, EventArgs e)
        {
            dataGridView_movimentos.DataSource = atualizarTodosPagos();
            pintarCelulas();
        }

        private void comboBox_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_categoria.SelectedIndex == 0 || comboBox_categoria.SelectedIndex == 1)
            {
                textBox_pesquisa.Mask = "00/00/0000";
            }
            else
            {
                textBox_pesquisa.Mask = "";
            }
        }
    }
}
