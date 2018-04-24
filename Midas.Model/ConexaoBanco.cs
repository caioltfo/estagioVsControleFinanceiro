using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Midas.Model.Suporte
{
    public static class ConexaoBanco
    {
        //Variavel que contem os dados da conexão ao banco
        //postgres utilizando o npgsql que é um drive nativo
        //para acesso ao postgres para o C#
        static string stringConexao = "server=DESKTOP-RHJGKEG\\SQLEXPRESS; Database=bd_Midas;Integrated Security=SSPI;";
        /*
        static string stringConexao =
        "Server = 200.145.153.172; " +
        "Database = turma73b ;" +
        "User ID= turma73b; password = chuchuverde;";
        */
        static SqlConnection cn;
        private static void conectar()
        {
            if (cn == null)
                cn = new SqlConnection();
            try
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.ConnectionString = stringConexao;
                    cn.Open();
                }
            }
            catch (SqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
        private static void desconectar()
        {
            cn.Close(); // fecha a conexão com o banco de dados
            cn.Dispose(); // libera os recursos utilizados
            cn = null;
        }
        //Executa uma query no banco de dados. (Sem retorno)
        // insert - update - delete
        public static void executar(string sql)
        {
            try
            {
                conectar();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                desconectar();
            }
        }
        //Executa uma query no banco de dados com parametros
        public static void executar(string sql, List<object> parametros)
        {
            try
            {
                conectar();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cn;
                int i = 1;
                foreach (object parametro in parametros)
                    cmd.Parameters.AddWithValue(i++.ToString(), parametro);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                desconectar();
            }
        }
        //Executa uma query no banco de dados com parametros retornando 'campoRetorno'
        public static int executar(string sql, List<object> parametros, string campoRetorno)
        {
            try
            {
                conectar();
                SqlCommand cmd = new SqlCommand();
                int modificado = 0;
                cmd.CommandText = sql + " RETURNING " + campoRetorno;
                cmd.Connection = cn;
                int i = 1;
                foreach (object parametro in parametros)
                    cmd.Parameters.AddWithValue(i++.ToString(), parametro);
                modificado = Convert.ToInt32(cmd.ExecuteScalar());
                return modificado;
            }
            catch (SqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                desconectar();
            }
        }
        //Select simples retornando um DataReader
        public static SqlDataReader selecionar(string sql)
        {
            try
            {
                conectar();
                SqlCommand cmd = new SqlCommand(sql, cn);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (SqlException ex)
            {
                desconectar();
                throw new ApplicationException(ex.Message);
            }
        }
        //Select com parametros retornando um DataReader
        public static SqlDataReader selecionar(string sql, List<object>
        parametros)
        {
            try
            {
                conectar();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cn;
                int i = 1;
                foreach (object parametro in parametros)
                    cmd.Parameters.AddWithValue(i++.ToString(), parametro);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (SqlException ex)
            {
                desconectar();
                throw new ApplicationException(ex.Message);
            }
        }
        // Select retornando os dados em um DataTable
        public static DataTable selecionarDataTable(string sql)
        {
            try
            {
                conectar();
                // Cria o objeto DataTable
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                desconectar();
            }
        }
        public static DataSet selecionarDataSet(string sql)
        {
            try
            {
                conectar();
                // Cria o objeto DataSet
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (SqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                desconectar();
            }
        }
        public static DataSet selecionarDataSet(string tabela, string campos,
        string where = "", string orderBy = "")
        {
            try
            {
                conectar();
                // Cria o objeto DataSet
                DataSet ds = new DataSet();
                string sql = @"select " + campos + " from " + tabela;
                if (where != "")
                    sql += @" where " + where + " ";
                if (orderBy != "")
                    sql += @" order by " + orderBy + " ";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, tabela);
                return ds;
            }
            catch (SqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                desconectar();
            }
        }
    }
}
