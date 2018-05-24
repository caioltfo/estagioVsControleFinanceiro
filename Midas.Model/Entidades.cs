using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Midas.Model.Entidades
{
    public class Empresa
    {
        private Int64 id_empresa;
        private String nome_empresa;
        private int excluido;
        public int Excluido { get => excluido; set => excluido = value; }
        public long Id_empresa { get => id_empresa; set => id_empresa = value; }
        public string Nome_empresa { get => nome_empresa; set => nome_empresa = value; }
        
    }
    public class Usuario
    {
        private Int64 id_usuario;
        private String user_usuario;
        private String senha_usuario;
        private String email_usuario;
        private Int64 perfil_usuario;
        private int nivel_usuario;
        private Decimal salario_usuario;
        private Empresa empresa;
        private int excluido;
        public int Excluido { get => excluido; set => excluido = value; }
        public long Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string User_usuario { get => user_usuario; set => user_usuario = value; }
        public string Senha_usuario { get => senha_usuario; set => senha_usuario = value; }
        public string Email_usuario { get => email_usuario; set => email_usuario = value; }
        public long Perfil_usuario { get => perfil_usuario; set => perfil_usuario = value; }
        public int Nivel_usuario { get => nivel_usuario; set => nivel_usuario = value; }
        public decimal Salario_usuario { get => salario_usuario; set => salario_usuario = value; }
        public Empresa Empresa { get => empresa; set => empresa = value; }
    }
    public class Documentos
    {
        private Int64 id_doc;
        private String descricao_doc;
        private String obs_doc;
        private Usuario usuario_manutencao_documentos;
        private int excluido;
        public int Excluido { get => excluido; set => excluido = value; }
        public long Id_doc { get => id_doc; set => id_doc = value; }
        public string Descricao_doc { get => descricao_doc; set => descricao_doc = value; }
        public string Obs_doc { get => obs_doc; set => obs_doc = value; }
        public Usuario Usuario_manutencao_documentos { get => usuario_manutencao_documentos; set => usuario_manutencao_documentos = value; }
    }
    public class Banco
    {
        private Int64 id_banco;
        private String nome_banco;
        private Int64 nro_banco;
        private String ag_banco;
        private String conta_banco;
        private String gerente_banco;
        private Int64 telefone_gerente_banco;
        private Int64 celular_gerente_banco;
        private String obs_banco;
        private Empresa empresa;
        private Usuario usuario_manutencao_banco;
        private int excluido;
        public int Excluido { get => excluido; set => excluido = value; }
        public long Id_banco { get => id_banco; set => id_banco = value; }
        public string Nome_banco { get => nome_banco; set => nome_banco = value; }
        public long Nro_banco { get => nro_banco; set => nro_banco = value; }
        public string Ag_banco { get => ag_banco; set => ag_banco = value; }
        public string Conta_banco { get => conta_banco; set => conta_banco = value; }
        public string Gerente_banco { get => gerente_banco; set => gerente_banco = value; }
        public long Telefone_gerente_banco { get => telefone_gerente_banco; set => telefone_gerente_banco = value; }
        public long Celular_gerente_banco { get => celular_gerente_banco; set => celular_gerente_banco = value; }
        public string Obs_banco { get => obs_banco; set => obs_banco = value; }
        public Empresa Empresa { get => empresa; set => empresa = value; }
        public Usuario Usuario_manutencao_banco { get => usuario_manutencao_banco; set => usuario_manutencao_banco = value; }
    }
    public class Fornecedor
    {
        private Int64 id_fornecedor;
        private String cpf_fornecedor;
        private String cnpj_fornecedor;
        private String razao_social_fornecedor;
        private String fantasia_fornecedor;
        private Int64 telefone_fornecedor;
        private String site_fornecedor;
        private Int64 celular_fornecedor;
        private String email_fornecedor;
        private String cidade_fornecedor;
        private string rua_fornecedor;
        private string numero_fornecedor;
        private string complemento_fornecedor;
        private string nro_banco_fornecedor;
        private string ag_bang_fornecedor;
        private string conta_fornecedor;
        private string gerente_fornecedor;
        private Int64 telefone_gerente_fornecedor;
        private Int64 celular_gerente_fornecedor;
        private String obd_fornecedor;
        private Usuario usuario_manutencao_fornecedor;
        private int excluido;
        public int Excluido { get => excluido; set => excluido = value; }
        public long Id_fornecedor { get => id_fornecedor; set => id_fornecedor = value; }
        public string Cpf_fornecedor { get => cpf_fornecedor; set => cpf_fornecedor = value; }
        public string Cnpj_fornecedor { get => cnpj_fornecedor; set => cnpj_fornecedor = value; }
        public string Razao_social_fornecedor { get => razao_social_fornecedor; set => razao_social_fornecedor = value; }
        public string Fantasia_fornecedor { get => fantasia_fornecedor; set => fantasia_fornecedor = value; }
        public long Telefone_fornecedor { get => telefone_fornecedor; set => telefone_fornecedor = value; }
        public string Site_fornecedor { get => site_fornecedor; set => site_fornecedor = value; }
        public long Celular_fornecedor { get => celular_fornecedor; set => celular_fornecedor = value; }
        public string Email_fornecedor { get => email_fornecedor; set => email_fornecedor = value; }
        public string Cidade_fornecedor { get => cidade_fornecedor; set => cidade_fornecedor = value; }
        public string Rua_fornecedor { get => rua_fornecedor; set => rua_fornecedor = value; }
        public string Numero_fornecedor { get => numero_fornecedor; set => numero_fornecedor = value; }
        public string Complemento_fornecedor { get => complemento_fornecedor; set => complemento_fornecedor = value; }
        public string Nro_banco_fornecedor { get => nro_banco_fornecedor; set => nro_banco_fornecedor = value; }
        public string Ag_bang_fornecedor { get => ag_bang_fornecedor; set => ag_bang_fornecedor = value; }
        public string Conta_fornecedor { get => conta_fornecedor; set => conta_fornecedor = value; }
        public string Gerente_fornecedor { get => gerente_fornecedor; set => gerente_fornecedor = value; }
        public long Telefone_gerente_fornecedor { get => telefone_gerente_fornecedor; set => telefone_gerente_fornecedor = value; }
        public long Celular_gerente_fornecedor { get => celular_gerente_fornecedor; set => celular_gerente_fornecedor = value; }
        public string Obd_fornecedor { get => obd_fornecedor; set => obd_fornecedor = value; }
        public Usuario Usuario_manutencao_fornecedor { get => usuario_manutencao_fornecedor; set => usuario_manutencao_fornecedor = value; }
    }
    public class Mov_lancamento
    {
        private Int64 id_lancamento;
        private String favorecido;
        private DateTime data_lancamento;
        private DateTime data_vencimento;
        private Documentos documento;
        private Decimal valor_do_titulo;
        private Decimal valor_pago;
        private Decimal acrecimo_valor;
        private Decimal descontos_valor;
        private Decimal saldo_a_pagar;
        private int pago;
        private DateTime data_pagamento;
        private int excluido;
        public int Excluido { get => excluido; set => excluido = value; }
        public long Id_lancamento { get => id_lancamento; set => id_lancamento = value; }
        public string Favorecido { get => favorecido; set => favorecido = value; }
        public DateTime Data_lancamento { get => data_lancamento; set => data_lancamento = value; }
        public DateTime Data_vencimento { get => data_vencimento; set => data_vencimento = value; }
        public Documentos Documento { get => documento; set => documento = value; }
        public decimal Valor_do_titulo { get => valor_do_titulo; set => valor_do_titulo = value; }
        public decimal Acrecimo_valor { get => acrecimo_valor; set => acrecimo_valor = value; }
        public decimal Descontos_valor { get => descontos_valor; set => descontos_valor = value; }
        public decimal Saldo_a_pagar { get => saldo_a_pagar; set => saldo_a_pagar = value; }
        public int Pago { get => pago; set => pago = value; }
        public DateTime Data_pagamento { get => data_pagamento; set => data_pagamento = value; }
        public decimal Valor_pago { get => valor_pago; set => valor_pago = value; }
    }

}
