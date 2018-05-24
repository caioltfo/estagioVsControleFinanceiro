using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Midas.Model.Entidades;
using System.Text.RegularExpressions;
using System.Data;
using System.Net;
using System.IO;
using System.Reflection;



namespace Midas.Model.Servico
{
    public class Servico
    {
        public static bool IsCnpj(string cnpj)
        {
            if (cnpj == "" || cnpj == "" || cnpj == null)
            {
                return false;
            }
            {
                int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int soma;
                int resto;
                string digito;
                string tempCnpj;

                cnpj = cnpj.Trim();
                cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

                if (cnpj.Length != 14)
                    return false;

                tempCnpj = cnpj.Substring(0, 12);

                soma = 0;
                for (int i = 0; i < 12; i++)
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

                resto = (soma % 11);
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = resto.ToString();

                tempCnpj = tempCnpj + digito;
                soma = 0;
                for (int i = 0; i < 13; i++)
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

                resto = (soma % 11);
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = digito + resto.ToString();

                return cnpj.EndsWith(digito);
            }
        }
        
        public static List<object> ConvertToList(DataTable table)
        {
            if (table == null)
                return null;

            List<DataRow> rows = new List<DataRow>();

            foreach (DataRow row in table.Rows)
                rows.Add(row);

            return rows.ToList<object>();
        }
        public static bool IsCpf(string cpf)
        {
            if (cpf == " " || cpf == "" || cpf == null)
            {
                return false;
            }
            else
            {
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string tempCpf;
                string digito;
                int soma;
                int resto;

                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");

                if (cpf.Length != 11)
                    return false;

                tempCpf = cpf.Substring(0, 9);
                soma = 0;

                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = resto.ToString();

                tempCpf = tempCpf + digito;

                soma = 0;
                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;

                digito = digito + resto.ToString();

                return cpf.EndsWith(digito);
            }
        }

        public static Empresa objEmpresa(ref SqlDataReader dtr)
        {
            Empresa emp = new Empresa();
            emp.Id_empresa = Convert.ToInt64(dtr["id_empresa"]);
            emp.Nome_empresa = Convert.ToString(dtr["nome_empresa"]);
            emp.Excluido = Convert.ToInt16(dtr["excluido"]);
            return emp;
        }
        public static Usuario objUsuario(ref SqlDataReader dtr)
        {
            Usuario u = new Usuario();
            u.Id_usuario = Convert.ToInt64(dtr["id_usuario"]);
            u.User_usuario = dtr["user_usuario"].ToString();
            u.Senha_usuario = dtr["senha_usuario"].ToString();
            u.Salario_usuario = Convert.ToDecimal(dtr["salario_usuario"]);
            //u.Perfil_usuario = Convert.ToInt64(dtr["perfil_usuario"]);
            u.Nivel_usuario = Convert.ToInt16(dtr["nivel_usuario"]);
            Empresa emp = new Empresa();
            u.Empresa = emp;
            u.Email_usuario = Convert.ToString(dtr["email_usuario"]);
            u.Excluido = Convert.ToInt16(dtr["excluido"]);
            return u;
        }
        public static Documentos objDoc(ref SqlDataReader dtr)
        {
            Documentos doc = new Documentos();
            doc.Descricao_doc = dtr["descricao_doc"].ToString();
            doc.Obs_doc = dtr["obs_doc"].ToString();
            doc.Id_doc = Convert.ToInt64(dtr["id_doc"]);
            Usuario u = new Usuario();
            doc.Usuario_manutencao_documentos = u;
            doc.Excluido = Convert.ToInt16(dtr["excluido"]);
            return doc;
        }
        public static Banco objBanco(ref SqlDataReader dtr)
        {
            Banco b = new Banco();
            b.Ag_banco = dtr["ag_banco"].ToString();
            b.Celular_gerente_banco = Convert.ToInt64(dtr["celular_gerente_banco"]);
            b.Conta_banco = dtr["conta_banco"].ToString();
            Empresa e = new Empresa();
            b.Empresa = e;
            b.Gerente_banco = dtr["gerente_banco"].ToString();
            b.Id_banco = (Int64)dtr["id_banco"];
            b.Nome_banco = dtr["nome_banco"].ToString();
            b.Nro_banco = (Int64)dtr["nro_banco"];
            b.Obs_banco = dtr["obs_banco"].ToString();
            b.Telefone_gerente_banco = (Int64)dtr["telefone_gerente_banco"];
            Usuario us = new Usuario();
            b.Usuario_manutencao_banco = us;
            b.Excluido = Convert.ToInt16(dtr["excluido"]);
            return b;

        }
        public static Fornecedor objFornecedor(ref SqlDataReader dtr)
        {
            Fornecedor f = new Fornecedor();
            f.Id_fornecedor = (Int64)dtr["id_fornecedor"];
            f.Cpf_fornecedor = dtr["cpf_fornecedor"].ToString();
            f.Cnpj_fornecedor = dtr["cnpj_fornecedor"].ToString();
            f.Razao_social_fornecedor = dtr["razao_social_fornecedor"].ToString();
            f.Telefone_fornecedor = (Int64)dtr["telefone_fornecedor"];
            f.Site_fornecedor = dtr["site_fornecedor"].ToString();
            f.Celular_fornecedor = (Int64)dtr["celular_fornecedor"];
            f.Email_fornecedor = dtr["email_fornecedor"].ToString();
            f.Cidade_fornecedor = dtr["cidade_fornecedor"].ToString();
            f.Rua_fornecedor = dtr["rua_fornecedor"].ToString();
            f.Numero_fornecedor = dtr["numero_fornecedor"].ToString();
            f.Complemento_fornecedor = dtr["complemento_fornecedor"].ToString();
            f.Nro_banco_fornecedor = dtr["nro_banco_fornecedor"].ToString();
            f.Ag_bang_fornecedor = dtr["ag_banco_fornecedor"].ToString();
            f.Conta_fornecedor = dtr["conta_fornecedor"].ToString();
            f.Gerente_fornecedor = dtr["gerente_fornecedor"].ToString();
            f.Telefone_fornecedor = (Int64)dtr["Telefone_fornecedor"];
            f.Telefone_gerente_fornecedor = (Int64)dtr["telefone_gerente_fornecedor"];
            f.Celular_gerente_fornecedor = (Int64)dtr["celular_gerente_fornecedor"];
            f.Obd_fornecedor = dtr["obs_fornecedor"].ToString();
            Usuario us = new Usuario();
            f.Usuario_manutencao_fornecedor = us;
            f.Excluido = Convert.ToInt16(dtr["excluido"]);
            return f;
        }
        public static Fornecedor objFornecedor2(ref SqlDataReader dtr)
        {
            Fornecedor f = new Fornecedor();
            
            f.Razao_social_fornecedor = dtr["razao_social_fornecedor"].ToString();
           
           
            return f;
        }
        public static Mov_lancamento objMov_Lancamento(ref SqlDataReader dtr)
        {
            Mov_lancamento mov = new Mov_lancamento();
            mov.Acrecimo_valor = Convert.ToDecimal(dtr["acrecimo_valor"].ToString().Replace(",","."));
            mov.Data_lancamento = Convert.ToDateTime(dtr["data_lacamento"]);
            mov.Data_pagamento = Convert.ToDateTime(dtr["data_pagamento"]);
            mov.Data_vencimento = Convert.ToDateTime(dtr["data_vencimento"]);
            mov.Descontos_valor = (Decimal)dtr["descontos_valor"];
            Documentos doc = new Documentos();
            mov.Documento = doc;
            mov.Favorecido = dtr["favorecido"].ToString();
            mov.Id_lancamento = (Int64)dtr["id_lancamento"];
            mov.Pago = Convert.ToInt16(dtr["pago"]);
            mov.Saldo_a_pagar = (Decimal)dtr["saldo_a_pagar"];
            mov.Valor_do_titulo = (Decimal)dtr["valor_do_titulo"];
            mov.Valor_pago = (Decimal)dtr["valor_pago"];
            mov.Excluido = Convert.ToInt16(dtr["excluido"]);
            return mov;
        }
        public static Mov_lancamento objMov_Lancamento2(ref SqlDataReader dtr)
        {
            Mov_lancamento mov = new Mov_lancamento();
           
            mov.Data_lancamento = Convert.ToDateTime(dtr["data_lancamento"]);
           
            mov.Data_vencimento = Convert.ToDateTime(dtr["data_vencimento"]);
           
            Documentos doc = new Documentos();
            mov.Documento = doc;
            mov.Favorecido = dtr["favorecido"].ToString();
           
            mov.Pago = Convert.ToInt16(dtr["pago"]);
           
            mov.Valor_do_titulo = (Decimal)dtr["valor_do_titulo"];
           
           
            return mov;
        }
        public static List<Usuario> buscarUsuarios(int excluido)
        {
            List<Usuario> us = new List<Usuario>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM usuario WHERE excluido = " + excluido);
            while (dr.Read())
                us.Add(objUsuario(ref dr));
            dr.Close();
            return us;
        }
        public static List<Usuario> buscarUsuarios(Int64 id_usuario, int excluido)
        {
            List<Usuario> us = new List<Usuario>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM usuario where id_usuario = " + id_usuario + " AND excluido = " + excluido);
            while (dr.Read())
                us.Add(objUsuario(ref dr));
            dr.Close();
            return us;
        }
        public static List<Usuario> buscarUsuarios(String nome_usuario, int excluido)
        {
            List<Usuario> us = new List<Usuario>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM usuario WHERE user_usuario ='" + nome_usuario + "' AND excluido = " + excluido);
            while (dr.Read())
                us.Add(objUsuario(ref dr));
            dr.Close();
            return us;
        }
        public static List<Empresa> buscarEmpresa(int excluido)
        {
            List<Empresa> us = new List<Empresa>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM empresa WHERE excluido = " + excluido);
            while (dr.Read())
                us.Add(objEmpresa(ref dr));
            dr.Close();
            return us;
        }
        public static List<Empresa> buscarDoc(String pesquisa, int excluido)
        {
            List<Empresa> us = new List<Empresa>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM documentos WHERE excluido = " + excluido +" AND descricao_doc = '"+pesquisa+"'");
            while (dr.Read())
                us.Add(objEmpresa(ref dr));
            dr.Close();
            return us;
        }
        public static List<Usuario> buscarNomeUsuariosPorId(Int64 id_user, int excluido)
        {
            List<Usuario> us = new List<Usuario>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT user_usuario FROM usuario WHERE id_usuario ='" + id_user + "' AND excluido = " + excluido);
            while (dr.Read())
                us.Add(objUsuario(ref dr));
            dr.Close();
            return us;
        }
        public static List<Usuario> buscarUsuariosPorNome(String nome, int excluido)
        {
            List<Usuario> us = new List<Usuario>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM usuario WHERE user_usuario ='" + nome + "' AND excluido = " + excluido);
            while (dr.Read())
                us.Add(objUsuario(ref dr));
            dr.Close();
            return us;
        }
        public static List<Usuario> buscarUsuariosPorEmail(String email, int excluido)
        {
            List<Usuario> us = new List<Usuario>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM usuario WHERE email_usuario ='" + email + "' AND excluido = " + excluido);
            while (dr.Read())
                us.Add(objUsuario(ref dr));
            dr.Close();
            return us;
        }
        public static List<Usuario> buscarIdUsuariosPorSenha(String senha, int excluido)
        {
            List<Usuario> us = new List<Usuario>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT id_usuario FROM usuario WHERE senha_usuario ='" + senha + "' AND excluido = " + excluido);
            while (dr.Read())
                us.Add(objUsuario(ref dr));
            dr.Close();
            return us;
        }
        public static List<Usuario> buscarIdUsuariosPorNome(String nome, int excluido)
        {
            List<Usuario> us = new List<Usuario>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT id_usuario FROM usuario WHERE senha_usuario ='" + nome + "' AND excluido = " + excluido);
            while (dr.Read())
                us.Add(objUsuario(ref dr));
            dr.Close();
            return us;
        }
        public static DataTable buscarEmpresa(string nome)
        {
            List<Empresa> us = new List<Empresa>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM empresa WHERE nome_empresa = '"+nome+"' AND excluido = 0");
            while (dr.Read())
                us.Add(objEmpresa(ref dr));
            dr.Close();
            DataTable dt = new DataTable();
            dt = ToDataTable(us);
            return dt;
        }
        public static DataTable buscarBancoPorNome(string nome)
        {
            List<Empresa> us = new List<Empresa>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM banco WHERE nome_banco = '" + nome + "' AND excluido = 0");
            while (dr.Read())
                us.Add(objEmpresa(ref dr));
            dr.Close();
            DataTable dt = new DataTable();
            dt = ToDataTable(us);
            return dt;
        }
        public static DataTable buscarEmpresaPorNum(Int64 num)
        {
            List<Empresa> us = new List<Empresa>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM  banco WHERE nro_banco = " + num + " AND excluido = 0");
            while (dr.Read())
                us.Add(objEmpresa(ref dr));
            dr.Close();
            DataTable dt = new DataTable();
            dt = ToDataTable(us);
            return dt;
        }
        public static DataTable buscarEmpresaPorAg(string nome)
        {
            List<Empresa> us = new List<Empresa>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM banco WHERE ag_banco = '" + nome + "' AND excluido = 0");
            while (dr.Read())
                us.Add(objEmpresa(ref dr));
            dr.Close();
            DataTable dt = new DataTable();
            dt = ToDataTable(us);
            return dt;
        }
        public static DataTable buscarEmpresaPorConta(string nome)
        {
            List<Empresa> us = new List<Empresa>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM banco WHERE conta_banco = '" + nome + "' AND excluido = 0");
            while (dr.Read())
                us.Add(objEmpresa(ref dr));
            dr.Close();
            DataTable dt = new DataTable();
            dt = ToDataTable(us);
            return dt;
        }
        public static DataTable buscarEmpresa()
        {
            List<Empresa> us = new List<Empresa>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM empresa WHERE excluido = 0");
            while (dr.Read())
                us.Add(objEmpresa(ref dr));
            dr.Close();
            DataTable dt = new DataTable();
            dt = ToDataTable(us);
            return dt;
        }
        public static Int64 buscarIdEmpresaPorNomeEmpresa(string razao_emp, int excluido)
        {
            Empresa us = new Empresa();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT id_empresa FROM empresa WHERE nome_empresa ='" + razao_emp + "' AND excluido = " + excluido);

            dr.Close();
            return us.Id_empresa;
        }
        public static List<Documentos> buscarDoc(int excluido)
        {
            List<Documentos> us = new List<Documentos>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM documentos WHERE excluido = " + excluido);
            while (dr.Read())
                us.Add(objDoc(ref dr));
            dr.Close();
            return us;
        }
        public static List<Documentos> buscarIdDoc(String descri)
        {
            List<Documentos> us = new List<Documentos>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT id_doc FROM documentos WHERE excluido = 0 AND descricao_doc = '"+descri+"'");
            while (dr.Read())
                us.Add(objDoc(ref dr));
            dr.Close();
            return us;
        }
        public static List<Banco> buscarNomeBanco(int excluido)
        {
            List<Banco> us = new List<Banco>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT nome_banco FROM banco WHERE excluido = " + excluido);
            while (dr.Read())
                us.Add(objBanco(ref dr));
            dr.Close();
            return us;
        }
        public static List<Banco> buscarBanco(int excluido)
        {
            List<Banco> us = new List<Banco>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM banco WHERE excluido = " + excluido);
            while (dr.Read())
                us.Add(objBanco(ref dr));
            dr.Close();
            return us;
        }
        public static List<Mov_lancamento> buscarMov_lancamento(int excluido)
        {
            List<Mov_lancamento> us = new List<Mov_lancamento>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT data_lancamento, data_vencimento, favorecido, valor_do_titulo, pago FROM mov_lancamento WHERE excluido = " + excluido);
            while (dr.Read())
                us.Add(objMov_Lancamento2(ref dr));
            dr.Close();
            return us;
        }
        public static List<Mov_lancamento> buscarMov_lancamentoPorTudo(string favorecido, DateTime data_lancamento, DateTime data_vencimento, int pago, int excluido)
        {
            List<Mov_lancamento> us = new List<Mov_lancamento>(); 
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT data_lancamento, data_vencimento, favorecido, valor_do_titulo, pago FROM mov_lancamento WHERE excluido = " + excluido +" AND favorecido = '"+favorecido+"' AND data_lancamento = '"+data_lancamento+"' AND "+
                "data_vencimento = '" + data_vencimento + "' AND pago = "+pago);
            while (dr.Read())
                us.Add(objMov_Lancamento2(ref dr));
            dr.Close();
            return us;
        }
        public static List<Mov_lancamento> buscarMov_lancamentoPorFavorecido(string favorecido, int excluido)
        {
            List<Mov_lancamento> us = new List<Mov_lancamento>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT data_lancamento, data_vencimento, favorecido, valor_do_titulo, pago FROM mov_lancamento WHERE excluido = " + excluido + " AND favorecido = '" + favorecido + "'");
            while (dr.Read())
                us.Add(objMov_Lancamento2(ref dr));
            dr.Close();
            return us;
        }
        public static List<Mov_lancamento> buscarMov_lancamentoPorDataLancamento(DateTime data_lancamento, int excluido)
        {
            List<Mov_lancamento> us = new List<Mov_lancamento>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT data_lancamento, data_vencimento, favorecido, valor_do_titulo, pago FROM mov_lancamento WHERE excluido = " + excluido + " AND data_lancamento = '" + data_lancamento + "'");
            while (dr.Read())
                us.Add(objMov_Lancamento2(ref dr));
            dr.Close();
            return us;
        }
        public static List<Mov_lancamento> buscarMov_lancamentoPorDataVencimento(DateTime data_vencimento, int excluido)
        {
            List<Mov_lancamento> us = new List<Mov_lancamento>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT data_lancamento, data_vencimento, favorecido, valor_do_titulo, pago FROM mov_lancamento WHERE excluido = " + excluido + " AND data_vencimento = '" + data_vencimento + "'");
            while (dr.Read())
                us.Add(objMov_Lancamento2(ref dr));
            dr.Close();
            return us;
        }
        public static List<Mov_lancamento> buscarMov_lancamentoPorPago(int pago, int excluido)
        {
            List<Mov_lancamento> us = new List<Mov_lancamento>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT data_lancamento, data_vencimento, favorecido, valor_do_titulo, pago FROM mov_lancamento WHERE excluido = " + excluido + " AND pago = " + pago );
            while (dr.Read())
                us.Add(objMov_Lancamento2(ref dr));
            dr.Close();
            return us;
        }
        public static List<Fornecedor> buscarFornecedor( String razao)
        {
            List<Fornecedor> us = new List<Fornecedor>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM fornecedor WHERE razao_social_fornecedor = '"+razao+"'");
            while (dr.Read())
                us.Add(objFornecedor(ref dr));
            dr.Close();
            return us;
        }
        public static List<Fornecedor> buscarFornecedor()
        {
            List<Fornecedor> us = new List<Fornecedor>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM fornecedor WHERE excluido = 0");
            while (dr.Read())
                us.Add(objFornecedor(ref dr));
            dr.Close();
            return us;
        }
        public static List<Fornecedor> buscarRazaoFornecedor(int excluido)
        {
            List<Fornecedor> us = new List<Fornecedor>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT razao_social_fornecedor FROM fornecedor WHERE excluido = " + excluido);
            while (dr.Read())
                us.Add(objFornecedor2(ref dr));
            dr.Close();
            return us;
        }
        public static List<Fornecedor> buscarFornecedor(int excluido)
        {
            List<Fornecedor> us = new List<Fornecedor>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM fornecedor WHERE excluido = " + excluido);
            while (dr.Read())
                us.Add(objFornecedor(ref dr));
            dr.Close();
            return us;
        }
        /*public static List<Mov_lancamento> buscarMov(Int64 excluido)
        {
            List<Mov_lancamento> us = new List<Mov_lancamento>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM mov_lancamento WHERE excluido = " + excluido);
            while (dr.Read())
                us.Add(obj(ref dr));
            dr.Close();
            return us;
        }*/
        public static List<Fornecedor> buscarFornecedor(Int64 id_fornecedor, int excluido)
        {
            List<Fornecedor> us = new List<Fornecedor>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM fornecedor WHERE id_fornecedor =" + id_fornecedor + " AND excluido = " + excluido);
            while (dr.Read())
                us.Add(objFornecedor(ref dr));
            dr.Close();
            return us;
        }
        public static DataTable ToDataTable<T>(List<T> items)

        {

            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties

            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in Props)

            {

                //Setting column names as Property names

                dataTable.Columns.Add(prop.Name);

            }

            foreach (T item in items)

            {

                var values = new object[Props.Length];

                for (int i = 0; i < Props.Length; i++)

                {

                    //inserting property values to datatable rows

                    values[i] = Props[i].GetValue(item, null);

                }

                dataTable.Rows.Add(values);

            }

            //put a breakpoint here and check datatable

            return dataTable;

        }
        public static List<Fornecedor> buscarFornecedor(String nome_fornecedor, int excluido)
        {
            List<Fornecedor> us = new List<Fornecedor>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM fornecedor WHERE razao_social_fornecedor ='" + nome_fornecedor + "' AND excluido = " + excluido + "ORDER BY razao_social_fornecedor");
            while (dr.Read())
                us.Add(objFornecedor(ref dr));
            dr.Close();
            return us;
        }
        public static void salvar(Fornecedor c, Int64 user)
        {
            String sql;
            // Se tem 'id' igual a zero é porque ainda não foi inserido
            if (c.Id_fornecedor == 0)
            {
                sql = "INSERT INTO fornecedor " +
                 "VALUES ('" + c.Cpf_fornecedor + "','" + c.Cnpj_fornecedor + "','" + c.Razao_social_fornecedor + "','" + c.Fantasia_fornecedor + "'," + c.Telefone_fornecedor + ",'" + c.Site_fornecedor + "'," + c.Celular_fornecedor + ",'" + c.Email_fornecedor + "','" + c.Cidade_fornecedor + "','" + c.Rua_fornecedor + "','" + c.Numero_fornecedor + "','" + c.Complemento_fornecedor + "','" + c.Nro_banco_fornecedor + "','" + c.Ag_bang_fornecedor + "','" + c.Conta_fornecedor + "','" + c.Gerente_fornecedor + "'," + c.Telefone_gerente_fornecedor + "," + c.Celular_gerente_fornecedor + ",'" + c.Obd_fornecedor + "'," + user + "," + c.Excluido + ")";
                Suporte.ConexaoBanco.executar(sql);
                // Devemos capturar o id do aparelho registrado
                sql = "SELECT max(id_fornecedor) as id_fornecedor FROM fornecedor";
                SqlDataReader dtr = Suporte.ConexaoBanco.selecionar(sql);
                dtr.Read();
                c.Id_fornecedor = (Int64)dtr["id_fornecedor"];
                dtr.Close();
            }
            else // Senão apenas atualiza
            {
                sql = "USE[bd_Midas] GO UPDATE[dbo].[fornecedor]" +
        "SET[cpf_fornecedor] = '" + c.Cpf_fornecedor + "'" +
      ",[cnpj_fornecedor] = '" + c.Cnpj_fornecedor + "'" +
      ",[razao_social_fornecedor] = '" + c.Razao_social_fornecedor + "'" +
      ",[fantasia_fornecedor] = '" + c.Fantasia_fornecedor + "'" +
      ",[telefone_fornecedor] = '" + c.Telefone_fornecedor + "'" +
      ",[site_fornecedor] = '" + c.Site_fornecedor + "'" +
      ",[celular_fornecedor] = '" + c.Celular_fornecedor + "'" +
      ",[email_fornecedor] = '" + c.Email_fornecedor + "'" +
      ",[cidade_fornecedor] = '" + c.Cidade_fornecedor + "'" +
      ",[rua_fornecedor] = '" + c.Rua_fornecedor + "'" +
      ",[numero_fornecedor] = '" + c.Numero_fornecedor + "'" +
      ",[complemento_fornecedor] = '" + c.Complemento_fornecedor + "'" +
      ",[nro_banco_fornecedor] = '" + c.Nro_banco_fornecedor + "'" +
      ",[ag_banco_fornecedor] = '" + c.Ag_bang_fornecedor + "'" +
      ",[conta_fornecedor] = '" + c.Conta_fornecedor + "'" +
      ",[gerente_fornecedor] = '" + c.Gerente_fornecedor + "'" +
      ",[telefone_gerente_fornecedor] = " + c.Telefone_gerente_fornecedor +
      ",[celular_gerente_fornecedor] = " + c.Celular_gerente_fornecedor +
      ",[obs_fornecedor] = '" + c.Obd_fornecedor + "'" +
      ",[usuario_manutencao_fornecedor] = " + user +
      "WHERE id_fornecedor =" + c.Id_fornecedor + "GO";
                Suporte.ConexaoBanco.executar(sql);
            }
        }
        public static void salvar(Documentos c, Int64 user)
        {
            String sql;
            // Se tem 'id' igual a zero é porque ainda não foi inserido
            if (c.Id_doc == 0 )
            {
                sql = "INSERT INTO documentos " +
                 "VALUES ('" + c.Descricao_doc + "','" + c.Obs_doc + "','" + user + "'," + c.Excluido + ")";
                Suporte.ConexaoBanco.executar(sql);
                // Devemos capturar o id do aparelho registrado
                sql = "SELECT max(id_doc) as id_doc FROM documentos";
                SqlDataReader dtr = Suporte.ConexaoBanco.selecionar(sql);
                dtr.Read();
                c.Id_doc = (Int64)dtr["id_doc"];
                dtr.Close();
            }
            else // Senão apenas atualiza
            {
                sql = "UPDATE documentos" +
        "SET descricao_doc = '" + c.Descricao_doc +"', obs_doc = '"+ c.Obs_doc +"', usuario_manutencao_documentos = "+c.Usuario_manutencao_documentos+ 
      " WHERE id_fornecedor =" + c.Id_doc;
                Suporte.ConexaoBanco.executar(sql);
            }
        }
        public static void salvar(Mov_lancamento c, Int64 user)
        {
            String sql;
            // Se tem 'id' igual a zero é porque ainda não foi inserido
            if (c.Id_lancamento == 0)
            {
                sql = "INSERT INTO mov_lancamento " +
                 "VALUES ('" + c.Favorecido + "', '" + c.Data_lancamento + "', '"+c.Data_vencimento+"', "+c.Documento.Id_doc+", "+c.Valor_do_titulo+", "+c.Valor_pago+", "+c.Acrecimo_valor+","+c.Descontos_valor+","+c.Saldo_a_pagar+", "+c.Pago+", '"+c.Data_pagamento+"', "+c.Excluido+")";
                Suporte.ConexaoBanco.executar(sql);
                // Devemos capturar o id do aparelho registrado
                sql = "SELECT max(id_lancamento) as id_lancamento FROM mov_lancamento";
                SqlDataReader dtr = Suporte.ConexaoBanco.selecionar(sql);
                dtr.Read();
                c.Id_lancamento = (Int64)dtr["id_lancamento"];
                dtr.Close();
            }
            else // Senão apenas atualiza
            {
                sql = "UPDATE mov_lancamento" +
        "SET favorecido = '" + c.Favorecido + "', data_lancamento ='"+c.Data_lancamento+"', data_vencimento = '"+c.Data_vencimento+"', tipo_documento = "+c.Documento.Id_doc+", valor_do_titulo = "+c.Valor_do_titulo+", pago = "+c.Pago+", data_pagamento = '"+c.Data_pagamento+"' , excluido = 0" +
      " WHERE id_lancamento =" + c.Id_lancamento;
                Suporte.ConexaoBanco.executar(sql);
            }
        }
       
        public static void salvar(Empresa c, Int64 user)
        {
            String sql;
            // Se tem 'id' igual a zero é porque ainda não foi inserido
            if (c.Id_empresa == 0)
            {
                sql = "INSERT INTO empresa " +
                 "VALUES ('" + c.Nome_empresa + "', "+c.Excluido+")";
                Suporte.ConexaoBanco.executar(sql);
                // Devemos capturar o id do aparelho registrado
                sql = "SELECT max(id_empresa) as id_empresa FROM empresa";
                SqlDataReader dtr = Suporte.ConexaoBanco.selecionar(sql);
                dtr.Read();
                c.Id_empresa = (Int64)dtr["id_empresa"];
                dtr.Close();
            }
            else // Senão apenas atualiza
            {
                sql = "UPDATE empresa" +
        "SET nome_empresa = '" + c.Nome_empresa + "', excluido = 0"+
      " WHERE id_empresa =" + c.Id_empresa;
                Suporte.ConexaoBanco.executar(sql);
            }
        }
        public static void salvar(Banco c, Int64 user)
        {
            String sql;
            // Se tem 'id' igual a zero é porque ainda não foi inserido
            if (c.Id_banco == 0)
            {
                sql = "INSERT INTO banco " +
                 "VALUES ('" + c.Nome_banco + "'," + c.Nro_banco + ",'" + c.Ag_banco + "','" + c.Conta_banco + "','"+c.Gerente_banco+"',"+c.Telefone_gerente_banco+","+c.Celular_gerente_banco+",'"+c.Obs_banco+"',"+c.Empresa+","+user+","+c.Excluido+")";
                Suporte.ConexaoBanco.executar(sql);
                // Devemos capturar o id do aparelho registrado
                sql = "SELECT max(id_banco) as id_banco FROM banco";
                SqlDataReader dtr = Suporte.ConexaoBanco.selecionar(sql);
                dtr.Read();
                c.Id_banco = (Int64)dtr["id_banco"];
                dtr.Close();
            }
            else // Senão apenas atualiza
            {
                sql = "UPDATE banco" +
        "SET nome_banco = '" + c.Nome_banco + "', nro_banco = " + c.Nro_banco + ", ag_banco = " + c.Ag_banco +", conta_banco = '" +c.Conta_banco+ "', gerente_banco = '"+c.Gerente_banco+"', telefone_gerente_banco = " +c.Telefone_gerente_banco + ", celular_gerente_banco = "+c.Celular_gerente_banco +", obs_banco = '"+c.Obs_banco +"', id_empresa = "+c.Empresa+", usuario_manutencao_banco = "+user +", excluido = "+ c.Excluido+
      " WHERE id_banco =" + c.Id_banco;
                Suporte.ConexaoBanco.executar(sql);
            }
        }
        public static void excluirDoc(String descricao)
        {
            String sql;

            sql = "UPDATE documentos" +
    " SET excluido = 1 WHERE descricao_doc ='" + descricao + "'";
            Suporte.ConexaoBanco.executar(sql);

        }
        public static void darBaixa(Int16 id_movimento, DateTime data_pagamento)
        {
            Suporte.ConexaoBanco.executar("UPDATE mov_lancamento SET pago = 1, data_pagamento =  '" + data_pagamento + "' WHERE id_lancamento = " + id_movimento);
        }
        public static void excluirBanco(String nome_banco)
        {
            String sql;

            sql = "UPDATE banco" +
    " SET  excluido = 1 WHERE nome_banco ='" + nome_banco + "'";
            Suporte.ConexaoBanco.executar(sql);

        }
        public static void excluirUser(String user)
        {
            String sql;

            sql = "UPDATE usuario" +
    " SET  excluido = 1 WHERE user_usuario ='" + user + "'";
            Suporte.ConexaoBanco.executar(sql);

        }
        
        public static void excluir(String razao, Int64 user)
        {
            String sql;

            sql = "USE [bd_Midas] GO UPDATE[dbo].[fornecedor]" +
    " SET[excluido] = 1 WHERE [razao_social_fornecedor]='" + razao + "'GO";
            Suporte.ConexaoBanco.executar(sql);

        }
        public static void excluirMov(Int64 id)
        {
            String sql;

            sql = "UPDATE mov_lancamento" +
    " SET excluido = 1 WHERE id_lancamento = " + id;
            Suporte.ConexaoBanco.executar(sql);

        }
        public static void excluirEmp(String razao, Int64 user)
        {
            String sql;

            sql = "UPDATE empresa" +
    " SET excluido = 1 WHERE nome_empresa ='" + razao +"'";
            Suporte.ConexaoBanco.executar(sql);

        }
        public static void ativar(String razao)
        {
            String sql;

            sql = "UPDATE fornecedor" +
    " SET excluido = 0 WHERE razao_social_fornecedor ='" + razao + "'";
            Suporte.ConexaoBanco.executar(sql);

        }
        public static void ativarDoc(String descricao)
        {
            String sql;

            sql = "UPDATE documentos" +
    " SET excluido = 0 WHERE descricao_doc ='" + descricao + "'";
            Suporte.ConexaoBanco.executar(sql);

        }
        public static void ativarBanco(String nome_banco)
        {
            String sql;

            sql = "UPDATE banco" +
    " SET excluido = 0 WHERE nome_banco ='" + nome_banco + "'";
            Suporte.ConexaoBanco.executar(sql);

        }
        public static void ativarUsuario(String user)
        {
            String sql;

            sql = "UPDATE usuario" +
    " SET excluido = 0 WHERE user_usuario ='" + user + "'";
            Suporte.ConexaoBanco.executar(sql);

        }
      /*  public static void GeneratePDF(DataTable dataTable, string titulo)

        {
            using (var fileStream = new FileStream("relatorio.pdf", System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None))
            {
                int cols = dataTable.Columns.Count;

                int rows = dataTable.Rows.Count;

                var document = new iTextSharp.text.Document(PageSize.A4.Rotate());
                var pdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(document, fileStream);
                document.Open();
                iTextSharp.text.FontFactory.RegisterDirectory("C:\\WINDOWS\\Fonts");
                var font = iTextSharp.text.FontFactory.GetFont("Arial", 20);
                
                var contentByte = pdfWriter.DirectContent;
                
                // Imagem.
//var image = iTextSharp.text.Image.GetInstance("Midas.Desktop\\Resources\\logo.jpg");
  //              image.ScaleToFit(100, 100);
    //            image.SetAbsolutePosition(2, 2);
      //          contentByte.AddImage(image);

                // Textos.
                var paragraph = new iTextSharp.text.Paragraph(titulo, font);
                paragraph.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                document.Add(paragraph);

                PdfPTable pdfTable = new PdfPTable(cols);

               
                // cabeçalhos

                for (int i = 0; i < cols; i++)

                {

                    PdfPCell cellCols = new PdfPCell();

                    Font ColFont = FontFactory.GetFont(FontFactory.HELVETICA, 5, Font.BOLD);

                    Chunk chunkCols = new Chunk(dataTable.Columns[i].ColumnName, ColFont);

                    cellCols.Phrase = new Phrase(chunkCols);

                    pdfTable.AddCell(cellCols);



                }
                // dados

                for (int k = 0; k < rows; k++)

                    for (int j = 0; j < cols; j++)

                    {

                        PdfPCell cellRows = new PdfPCell();

                        Font RowFont = FontFactory.GetFont(FontFactory.HELVETICA, 5);

                        Chunk chunkRows = new Chunk(dataTable.Rows[k][j].ToString(), RowFont);

                        cellRows.Phrase = new Phrase(chunkRows);

                        pdfTable.AddCell(cellRows);

                    }



                document.Add(pdfTable);

                

                // Figuras geométricas.

                document.Close();
                System.Diagnostics.Process.Start("relatorio.pdf");
            }
            

           


            


        }*/
      /*  public static void salvar(Usuario user, Int64 nivel)
        {
            String sql;
            // Se tem 'id' igual a zero é porque ainda não foi inserido
            if (user.Id_usuario == 0)
            {
                sql = "INSERT INTO usuario " +
                 "VALUES ('" + user.User_usuario + "','" + user.Senha_usuario + "','" + user.Email_usuario + "','" + user.Perfil_usuario + "'," + user.Nivel_usuario + "," + user.Salario_usuario + ","+user.Empresa+","  + user.Excluido + ")";
                Suporte.ConexaoBanco.executar(sql);
                // Devemos capturar o id do aparelho registrado
                sql = "SELECT max(id_usuario) as id_usuario FROM usuario";
                SqlDataReader dtr = Suporte.ConexaoBanco.selecionar(sql);
                dtr.Read();
                user.Id_usuario = (Int64)dtr["id_usuario"];
                dtr.Close();
            }
            else // Senão apenas atualiza
            {
                sql = "USE[bd_Midas] GO UPDATE[dbo].[usuario]" +
        "SET[user_usuario] = '" +user.User_usuario + "'" +
      ",[cnpj_fornecedor] = '" + c.Cnpj_fornecedor + "'" +
      ",[razao_social_fornecedor] = '" + c.Razao_social_fornecedor + "'" +
      ",[fantasia_fornecedor] = '" + c.Fantasia_fornecedor + "'" +
      ",[telefone_fornecedor] = '" + c.Telefone_fornecedor + "'" +
      ",[site_fornecedor] = '" + c.Site_fornecedor + "'" +
      ",[celular_fornecedor] = '" + c.Celular_fornecedor + "'" +
      ",[email_fornecedor] = '" + c.Email_fornecedor + "'" +
      ",[cidade_fornecedor] = '" + c.Cidade_fornecedor + "'" +
      ",[rua_fornecedor] = '" + c.Rua_fornecedor + "'" +
      ",[numero_fornecedor] = '" + c.Numero_fornecedor + "'" +
      ",[complemento_fornecedor] = '" + c.Complemento_fornecedor + "'" +
      ",[nro_banco_fornecedor] = '" + c.Nro_banco_fornecedor + "'" +
      ",[ag_banco_fornecedor] = '" + c.Ag_bang_fornecedor + "'" +
      ",[conta_fornecedor] = '" + c.Conta_fornecedor + "'" +
      ",[gerente_fornecedor] = '" + c.Gerente_fornecedor + "'" +
      ",[telefone_gerente_fornecedor] = " + c.Telefone_gerente_fornecedor +
      ",[celular_gerente_fornecedor] = " + c.Celular_gerente_fornecedor +
      ",[obs_fornecedor] = '" + c.Obd_fornecedor + "'" +
      ",[usuario_manutencao_fornecedor] = " + user +
      "WHERE id_fornecedor =" + c.Id_fornecedor + "GO";
                Suporte.ConexaoBanco.executar(sql);
            }
        }*/
        public static Boolean validaTel(string email)
        {


            Regex rg = new Regex(@"^\([1-9]{2}\) [9]{0,1}[6-9]{1}[0-9]{3}\-[0-9]{4}$");

            if (rg.IsMatch(email))
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ConectarUrl(string url)
        {

            /// 



            /// 
            if (url != null || url != " " || url != "" || url.Equals(!url.Length.Equals(0)))
            {
                bool fail;


                System.Uri Url = new System.Uri("https://" + url); //é sempre bom por um site que costuma estar sempre on, para n haver problemas


                WebRequest WebReq;

                WebResponse Resp;


                WebReq = WebRequest.Create(Url);


                try

                {

                    Resp = WebReq.GetResponse();

                    Resp.Close();

                    WebReq = null;

                    fail = true; //consegue conexão à internet                

                }


                catch

                {

                    WebReq = null;

                    fail = false; //falhou a conexão à internet                

                }


                return fail;

            }
            else
            {
                return false;
            }


        }
        public static Boolean validaEmail(string email)
        {


            Regex rg = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");

            if (rg.IsMatch(email))
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean res;
        public static Boolean validaUsuario(String senha, int excluido)
        {

            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT user_usuario FROM usuario WHERE excluido = " + excluido);
            while (dr.Read())
            {
                if (senha == dr["user_usuario"].ToString())
                {

                    res = false;
                }
                else if (senha != dr["user_usuario"].ToString())
                {
                    res = true;
                }
            }
            dr.Close();
            return res;


        }
        public static Boolean validaRazao(String senha)
        {

            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT razao_social_fornecedor FROM fornecedor");
            while (dr.Read())
            {
                if (senha == dr["razao_social_fornecedor"].ToString())
                {

                    res = false;
                }
                else if (senha != dr["razao_social_fornecedor"].ToString())
                {
                    res = true;
                }
            }
            dr.Close();
            return res;


        }
        public static Boolean validaNomeEmp(String senha)
        {

            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT nome_empresa FROM empresa");
            while (dr.Read())
            {
                if (senha == dr["nome_empresa"].ToString())
                {

                    res = false;
                }
                else if (senha != dr["nome_empresa"].ToString())
                {
                    res = true;
                }
            }
            dr.Close();
            return res;


        }
        public static Boolean validaDescriDoc(String senha)
        {

            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT descricao_doc FROM documentos");
            while (dr.Read())
            {
                if (senha == dr["descricao_doc"].ToString())
                {

                    res = false;
                }
                else if (senha != dr["descricao_doc"].ToString())
                {
                    res = true;
                }
            }
            dr.Close();
            return res;


        }
        public static Boolean validaConta(string senha)
        {

            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT conta_banco FROM banco");
            while (dr.Read())
            {
                if (senha == dr["conta_banco"].ToString())
                {

                    res = false;
                }
                else if (senha != dr["conta_banco"].ToString())
                {
                    res = true;
                }
            }
            dr.Close();
            return res;


        }
        public static Boolean validaNumBanco(Int64 senha)
        {

            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT nro_banco FROM banco");
            while (dr.Read())
            {
                if (senha == Convert.ToInt64(dr["nro_banco"]))
                {

                    res = false;
                }
                else if (senha != Convert.ToInt64(dr["nro_banco"]))
                {
                    res = true;
                }
            }
            dr.Close();
            return res;


        }

        public static Boolean validaFant(String senha)
        {

            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT fantasia_fornecedor FROM fornecedor");
            while (dr.Read())
            {
                if (senha == dr["fantasia_fornecedor"].ToString())
                {

                    res = false;
                }
                else if (senha != dr["fantasia_fornecedor"].ToString())
                {
                    res = true;
                }
            }
            dr.Close();
            return res;


        }
        public static DataTable buscarFornecedorPorCategoria(Int64 cat, String busca, int excluido)
        {
            List<Fornecedor> forn = new List<Fornecedor>();
            DataTable dt = new DataTable();
            if (cat == 0)
            {

                dt = Suporte.ConexaoBanco.selecionarDataTable("SELECT * FROM fornecedor WHERE razao_social_fornecedor='" + busca + "' AND excluido=" + excluido);


            }
            else if (cat == 1)
            {
                dt = Suporte.ConexaoBanco.selecionarDataTable("SELECT * FROM fornecedor WHERE cnpj_fornecedor='" + busca + "' AND excluido=" + excluido);
            }
            else if (cat == 2)
            {
                dt = Suporte.ConexaoBanco.selecionarDataTable("SELECT * FROM fornecedor WHERE cpf_fornecedor='" + busca + "' AND excluido=" + excluido);
            }
            else if (cat == 3)
            {
                dt = Suporte.ConexaoBanco.selecionarDataTable("SELECT * FROM fornecedor WHERE fantasia_fornecedor='" + busca + "' AND excluido=" + excluido);
            }
            else if (cat == 4)
            {
                dt = Suporte.ConexaoBanco.selecionarDataTable("SELECT * FROM fornecedor WHERE telefone_fornecedor=" + busca + " AND excluido=" + excluido);
            }
            else if (cat == 5)
            {
                dt = Suporte.ConexaoBanco.selecionarDataTable("SELECT * FROM fornecedor WHERE celular_fornecedor= " + busca + " AND excluido=" + excluido);
            }
            else
            {
                dt = Suporte.ConexaoBanco.selecionarDataTable("SELECT * FROM fornecedor WHERE excluido=" + excluido);
            }
            return dt;
        }
    }
}
