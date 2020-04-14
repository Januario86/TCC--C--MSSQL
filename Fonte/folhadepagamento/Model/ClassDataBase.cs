using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;
using System.Data.SqlClient;

namespace folhadepagamento.Model
{
    class ClassDataBase
    {
        private OleDbConnection _conexao;

        public OleDbConnection Conexao
        {
            get { return _conexao; }
            set { _conexao = value; }
        }

        public void ConectaAccess()
        {

            _conexao = new OleDbConnection(Properties.Settings.Default.conexaoAccess.ToString());

            try
            {
                _conexao.Open();
            }
            catch (Exception e)
            {
                throw (e);
            }

        }

        public void DesconectaAccess()
        {
            try
            {
                _conexao.Close();
            }
            catch (Exception e)
            {
                throw (e);
            }

        }

        public int ExecuteNonQueryAccess(String sql)
        {
            OleDbCommand comando = new OleDbCommand(sql, _conexao);

            int linhasAfetadas = 0;

            try
            {
                comando.Transaction = _conexao.BeginTransaction();
                linhasAfetadas = comando.ExecuteNonQuery();
                comando.Transaction.Commit();
                return linhasAfetadas;
            }
            catch (Exception e)
            {
                comando.Transaction.Rollback();
                throw (e);
            }
        }

        public OleDbDataReader SelecDataReadertAccess(String sql)
        {
            OleDbCommand comando = new OleDbCommand(sql, _conexao);
            try
            {
                return comando.ExecuteReader();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public OleDbDataAdapter SelecDataAdapterAccess(String sql)
        {
            try
            {
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, _conexao);
                OleDbCommandBuilder comando = new OleDbCommandBuilder(dataAdapter);

                return dataAdapter;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
    }
}
