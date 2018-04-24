using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Midas.Model.Entidades;
using Midas.Model;
using System.Data.SqlTypes;
using System.Windows;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;
using System.Net;

namespace Midas.Model.Servico
{
    public class Servico
    {
        public static bool IsCnpj(string cnpj)
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
        public static bool IsCpf(string cpf)
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
    
        public static Empresa objEmpresa(ref SqlDataReader dtr)
        {
            Empresa emp = new Empresa();
            emp.Id_empresa = Convert.ToInt64(dtr["id_empresa"]);
            emp.Nome_empresa = Convert.ToString(dtr["nome_empresa"]);

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
            return f;
        }
        public static Mov_lancamento objMov_Lancamento(ref SqlDataReader dtr)
        {
            Mov_lancamento mov = new Mov_lancamento();
            mov.Acrecimo_valor = Convert.ToDecimal(dtr["acrecimo_valor"]);
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
            return mov;
        }
        public static List<Usuario> buscarUsuarios()
        {
            List<Usuario> us = new List<Usuario>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM usuario");
            while (dr.Read())
                us.Add(objUsuario(ref dr));
            dr.Close();
            return us;
        }
        public static List<Usuario> buscarUsuarios(Int64 id_usuario)
        {
            List<Usuario> us = new List<Usuario>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM usuario where id_usuario = "+id_usuario);
            while (dr.Read())
                us.Add(objUsuario(ref dr));
            dr.Close();
            return us;
        }
        public static List<Usuario> buscarUsuarios(String nome_usuario)
        {
            List<Usuario> us = new List<Usuario>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM usuario WHERE user_usuario ='"+nome_usuario+"'");
            while (dr.Read())
                us.Add(objUsuario(ref dr));
            dr.Close();
            return us;
        }
        public static List<Usuario> buscarNomeUsuariosPorId(Int64 id_user)
        {
            List<Usuario> us = new List<Usuario>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT user_usuario FROM usuario WHERE id_usuario ='" + id_user + "'");
            while (dr.Read())
                us.Add(objUsuario(ref dr));
            dr.Close();
            return us;
        }
        public static List<Usuario> buscarIdUsuariosPorSenha(String senha)
        {
            List<Usuario> us = new List<Usuario>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT id_usuario FROM usuario WHERE senha_usuario ='" + senha + "'");
            while (dr.Read())
                us.Add(objUsuario(ref dr));
            dr.Close();
            return us;
        }
        public static List<Usuario> buscarIdUsuariosPorNome(String nome)
        {
            List<Usuario> us = new List<Usuario>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT id_usuario FROM usuario WHERE senha_usuario ='" + nome + "'");
            while (dr.Read())
                us.Add(objUsuario(ref dr));
            dr.Close();
            return us;
        }
        public static List<Empresa> buscarEmpresa()
        {
            List<Empresa> us = new List<Empresa>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM empresa");
            while (dr.Read())
                us.Add(objEmpresa(ref dr));
            dr.Close();
            return us;
        }
        public static Int64 buscarIdEmpresaPorNomeEmpresa(string razao_emp)
        {
            Empresa us = new Empresa();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT id_empresa FROM empresa WHERE nome_empresa ='"+razao_emp+"'");
            
            dr.Close();
            return us.Id_empresa;
        }
        public static List<Documentos> buscarDoc()
        {
            List<Documentos> us = new List<Documentos>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM documentos");
            while (dr.Read())
                us.Add(objDoc(ref dr));
            dr.Close();
            return us;
        }
        public static List<Banco> buscarBanco()
        {
            List<Banco> us = new List<Banco>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM banco");
            while (dr.Read())
                us.Add(objBanco(ref dr));
            dr.Close();
            return us;
        }
        public static List<Mov_lancamento> buscarMov_lancamento()
        {
            List<Mov_lancamento> us = new List<Mov_lancamento>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM mov_lancamento");
            while (dr.Read())
                us.Add(objMov_Lancamento(ref dr));
            dr.Close();
            return us;
        }

        public static List<Fornecedor> buscarFornecedor()
        {
            List<Fornecedor> us = new List<Fornecedor>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM fornecedor");
            while (dr.Read())
                us.Add(objFornecedor(ref dr));
            dr.Close();
            return us;
        }
        public static List<Fornecedor> buscarFornecedor(Int64 id_fornecedor)
        {
            List<Fornecedor> us = new List<Fornecedor>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM fornecedor WHERE id_fornecedor ="+id_fornecedor);
            while (dr.Read())
                us.Add(objFornecedor(ref dr));
            dr.Close();
            return us;
        }
        public static List<Fornecedor> buscarFornecedor(String nome_fornecedor)
        {
            List<Fornecedor> us = new List<Fornecedor>();
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT * FROM fornecedor WHERE nome_fornecedor ='" + nome_fornecedor+"'");
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
                 "VALUES ( default ,'"+c.Cpf_fornecedor+"','"+c.Cnpj_fornecedor+"','"+c.Razao_social_fornecedor+"','"+c.Fantasia_fornecedor+"',"+c.Telefone_fornecedor+",'"+c.Site_fornecedor+"',"+c.Celular_fornecedor+",'"+c.Email_fornecedor+"','"+c.Cidade_fornecedor+"','"+c.Rua_fornecedor+"','"+c.Numero_fornecedor+"','"+c.Complemento_fornecedor+"','"+c.Nro_banco_fornecedor+"','"+c.Ag_bang_fornecedor+"','"+c.Conta_fornecedor+"','"+c.Gerente_fornecedor+"',"+c.Telefone_gerente_fornecedor+","+c.Celular_gerente_fornecedor+",'"+c.Obd_fornecedor+"',"+user+")";
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
        "SET[cpf_fornecedor] = '"+c.Cpf_fornecedor+"'" +
      ",[cnpj_fornecedor] = '"+c.Cnpj_fornecedor+"'" +
      ",[razao_social_fornecedor] = '"+c.Razao_social_fornecedor+"'" +
      ",[fantasia_fornecedor] = '"+c.Fantasia_fornecedor+"'" +
      ",[telefone_fornecedor] = '"+c.Telefone_fornecedor+"'" +
      ",[site_fornecedor] = '"+c.Site_fornecedor+"'" +
      ",[celular_fornecedor] = '"+c.Celular_fornecedor+"'" +
      ",[email_fornecedor] = '"+c.Email_fornecedor+"'" +
      ",[cidade_fornecedor] = '"+c.Cidade_fornecedor+"'" +
      ",[rua_fornecedor] = '"+c.Rua_fornecedor+"'" +
      ",[numero_fornecedor] = '"+c.Numero_fornecedor+"'" +
      ",[complemento_fornecedor] = '"+c.Complemento_fornecedor+"'" +
      ",[nro_banco_fornecedor] = '"+c.Nro_banco_fornecedor+"'" +
      ",[ag_banco_fornecedor] = '"+c.Ag_bang_fornecedor+"'" +
      ",[conta_fornecedor] = '"+c.Conta_fornecedor+"'" +
      ",[gerente_fornecedor] = '"+c.Gerente_fornecedor+"'" +
      ",[telefone_gerente_fornecedor] = "+c.Telefone_gerente_fornecedor +
      ",[celular_gerente_fornecedor] = "+ c.Celular_gerente_fornecedor +
      ",[obs_fornecedor] = '"+c.Obd_fornecedor+"'" +
      ",[usuario_manutencao_fornecedor] = " + user+
      "WHERE id_fornecedor ="+c.Id_fornecedor+"GO";
                Suporte.ConexaoBanco.executar(sql);
            }
        }
        public static void salvar(Usuario user, string nivel)
        {
            try
            {
                List<Object> param = new List<Object>();
                param.Add(user.User_usuario);
                param.Add(user.Senha_usuario);
                param.Add(user.Email_usuario);
                if(nivel == "Administrador")
                {
                    param.Add(0);

                }else
                {
                    param.Add(1);

                }
                param.Add(user.Salario_usuario);
                param.Add(user.Empresa.Id_empresa);
                Suporte.ConexaoBanco.executar("INSERT INTO usuario VALUES(default,@1,@2,@3,@4,@5,@6)", param);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
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

            bool fail;


            System.Uri Url = new System.Uri(url); //é sempre bom por um site que costuma estar sempre on, para n haver problemas


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
        public static Boolean validaUsuario(String senha)
        {
            
            SqlDataReader dr = Suporte.ConexaoBanco.selecionar("SELECT user_usuario FROM usuario");
            while(dr.Read())
            {
                if(senha == dr["user_usuario"].ToString())
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
        public static DataTable buscarFornecedorPorCategoria(Int64 cat, String busca)
        {
            List<Fornecedor> forn = new List<Fornecedor>();
            DataTable dt = new DataTable();
            if (cat == 0)
            {

                dt = Suporte.ConexaoBanco.selecionarDataTable("SELECT * FROM fornecedor WHERE razao_social_fornecedor='" + busca+"'");


            }else if(cat == 1)
            {
                dt = Suporte.ConexaoBanco.selecionarDataTable("SELECT * FROM fornecedor WHERE cnpj_fornecedor='" + busca+"'");
            }
            return dt;
        }
    }
}
