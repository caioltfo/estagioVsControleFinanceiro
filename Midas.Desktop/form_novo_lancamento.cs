using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Midas.Model.Entidades;
using Midas.Model.Servico;
using Midas.Model.Suporte;
using System.Data.SqlClient;

namespace Midas.Desktop
{
    public partial class form_novo_lancamento : Form
    {
        public form_novo_lancamento()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public DataTable ObterTabela(SqlDataReader reader)
        {
            DataTable tbEsquema = reader.GetSchemaTable();
            DataTable tbRetorno = new DataTable();

            foreach (DataRow r in tbEsquema.Rows)
            {
                if (!tbRetorno.Columns.Contains(r["ColumnName"].ToString()))
                {
                    DataColumn col = new DataColumn()
                    {
                        ColumnName = r["ColumnName"].ToString(),
                        Unique = Convert.ToBoolean(r["IsUnique"]),
                        AllowDBNull = Convert.ToBoolean(r["AllowDBNull"]),
                        ReadOnly = Convert.ToBoolean(r["IsReadOnly"])
                    };
                    tbRetorno.Columns.Add(col);
                }
            }

            while (reader.Read())
            {
                DataRow novaLinha = tbRetorno.NewRow();
                for (int i = 0; i < tbRetorno.Columns.Count; i++)
                {
                    novaLinha[i] = reader.GetValue(i);
                }
                tbRetorno.Rows.Add(novaLinha);
            }

            return tbRetorno;
        }
        private void button_salvar_Click(object sender, EventArgs e)
        {
            List<String> favorecidos = new List<String>();
            try
            {

                try
                {
                   
                    SqlDataReader drf = ConexaoBanco.selecionar("SELECT razao_social_fornecedor FROM fornecedor WHERE excluido = 0");
                    drf.Read();
                    favorecidos = Servico.ConvertToListString(ObterTabela(drf));
                    drf.Close();
                    SqlDataReader drb = ConexaoBanco.selecionar("SELECT nome_banco FROM banco WHERE excluido = 0");
                    drb.Read();
                    favorecidos = Servico.ConvertToListString(ObterTabela(drb));
                    drb.Close();
                    SqlDataReader dru = ConexaoBanco.selecionar("SELECT user_usuario FROM usuario WHERE excluido = 0");
                    dru.Read();
                    favorecidos = Servico.ConvertToListString(ObterTabela(dru));
                    dru.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex, "Midas - Controle Financeiro - Novo Lançamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                foreach (String f in favorecidos)
                {
                    if (f == textBox_favorecido.Text)
                    {


                        if (checkBox_pago.Checked)
                        {
                            if (!textBox_favorecido.Text.Length.Equals(0))
                            {
                                try
                                {
                                    Mov_lancamento mov = new Mov_lancamento();
                                    mov.Favorecido = textBox_favorecido.Text;
                                    mov.Data_lancamento = Convert.ToDateTime(dateTimePicker_data_lancamento.Text);
                                    mov.Data_vencimento = Convert.ToDateTime(dateTimePicker_data_vencimento.Text);
                                    if (checkBox_pago.Checked == true)
                                    {
                                        mov.Data_pagamento = Convert.ToDateTime(dateTimePicker_data_pagamento.Text);
                                        mov.Pago = 1;
                                    }
                                    else
                                    {
                                        mov.Pago = 0;
                                    }


                                    Documentos doc = new Documentos();
                                    SqlDataReader dr = ConexaoBanco.selecionar("SELECT id_doc, descricao_doc, obs_doc FROM documentos WHERE excluido = 0 and descricao_doc = '" + comboBox_tipo_doc.SelectedItem + "'");

                                    dr.Read();
                                    doc.Id_doc = Convert.ToInt64(dr["id_doc"]);
                                    doc.Descricao_doc = dr["descricao_doc"].ToString();
                                    doc.Obs_doc = dr["obs_doc"].ToString();
                                    doc.Excluido = 0;
                                    dr.Close();



                                    mov.Documento = doc;




                                    mov.Valor_do_titulo = Convert.ToDecimal(maskedTextBox_val.Text.ToString().Replace(",", "."));
                                    Servico.salvar(mov, Program.ID_USER);
                                    MessageBox.Show("Movimento lançado com sucesso!", "Midas - Controle Financeiro - Novo Lançamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro: " + ex, "Midas - Controle Financeiro - Novo Lançamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Você deve colocar algum favorecido do movimento.", "Midas - Controle Financeiro - Novo Lançamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            if (!textBox_favorecido.Text.Length.Equals(0))
                            {
                                try
                                {
                                    Mov_lancamento mov = new Mov_lancamento();
                                    mov.Favorecido = textBox_favorecido.Text;
                                    mov.Data_lancamento = Convert.ToDateTime(dateTimePicker_data_lancamento.Text);
                                    mov.Data_vencimento = Convert.ToDateTime(dateTimePicker_data_vencimento.Text);
                                    if (!dateTimePicker_data_pagamento.Text.Length.Equals(0) || dateTimePicker_data_pagamento.Focused)
                                    {
                                        mov.Data_pagamento = Convert.ToDateTime(dateTimePicker_data_pagamento.Text);
                                    }

                                    Documentos doc = new Documentos();
                                    SqlDataReader dr = ConexaoBanco.selecionar("SELECT id_doc, descricao_doc, obs_doc FROM documentos WHERE excluido = 0 and descricao_doc = '" + comboBox_tipo_doc.SelectedItem + "'");
                                    dr.Read();
                                    doc.Id_doc = Convert.ToInt64(dr["id_doc"]);
                                    doc.Descricao_doc = dr["descricao_doc"].ToString();
                                    doc.Obs_doc = dr["obs_doc"].ToString();
                                    doc.Excluido = 0;
                                    dr.Close();



                                    mov.Documento = doc;

                                    mov.Pago = 0;
                                    mov.Valor_do_titulo = Convert.ToDecimal(maskedTextBox_val.Text.ToString());
                                    Servico.salvar(mov, Program.ID_USER);
                                    MessageBox.Show("Movimento lançado com sucesso!", "Midas - Controle Financeiro - Novo Lançamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro: " + ex, "Midas - Controle Financeiro - Novo Lançamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Você deve colocar algum favorecido no movimento.", "Midas - Controle Financeiro - Novo Lançamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex, "Midas - Controle Financeiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void form_novo_lancamento_Load(object sender, EventArgs e)
        {
            List<Documentos> mov = new List<Documentos>();
            mov = Servico.buscarDoc(0);
            foreach(Documentos d in mov)
            {
                comboBox_tipo_doc.Items.Add(d.Descricao_doc);
                
            }
        }
    }
}
