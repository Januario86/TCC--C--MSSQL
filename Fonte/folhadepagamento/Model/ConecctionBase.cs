using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
//using System.Linq;
using System.Web;
using System.Data;

namespace folhadepagamento.Model
{
    class ConecctionBase
    {
        public SqlConnection conexao()
        {
            //CLAUDIAEFELIPE terminal casa
            //MW7QIYIBB6JUNW terminal trab

         string conec ="Data Source = MW7QIYIBB6JUNW\\SQLEXPRESS;Initial Catalog=folha;User ID='sa';Password='dDfFgGhH001';Language=Portuguese";
         SqlConnection cn = new SqlConnection(conec);

            return cn;
        }

        public SqlConnection abrirConexao()
        {
            SqlConnection cn = conexao();

            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void fecharConexao(SqlConnection cn)
        {
            try
            {
                cn.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable executeQuery(string sql, SqlConnection cn)
        {
            try
            {
                //SqlCommand sqlComm = new SqlCommand(sql, cn);

                //sqlComm.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(sql,cn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int executeNonQuery(string sql, SqlConnection cn)
        {
            try
            {
                SqlCommand sqlComm = new SqlCommand(sql, cn);

                return sqlComm.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
