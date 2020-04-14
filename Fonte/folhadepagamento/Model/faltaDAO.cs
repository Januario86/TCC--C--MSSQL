using System;
using System.Collections.Generic;
using System.Text;
using folhadepagamento.VO;
using folhadepagamento.Util;
using folhadepagamento.Control;
using System.Data.SqlClient;

namespace folhadepagamento.Model
{
    class faltaDAO
    {        
        public void CadastrarFaltasDAO(FaltaVO dadosTela)
        {
            ConecctionBase conexao = new ConecctionBase();

            string sql_func;
            string sql_Nomefunc;

            sql_func = "(select id_funcionario from Funcionario where id_funcionario =" + dadosTela.IdFuncFerias + ")";
            sql_Nomefunc = "(select nome_func from Funcionario where id_funcionario =" + dadosTela.IdFuncFerias + ")";

            String sql = "INSERT INTO dbo.faltas("
              + "dt_falta,motivo_falta,nome_func,Funcionario_id_funcionario)"
              + "VALUES('" + dadosTela.DataFalta + "','" + dadosTela.MotivoFalta + "'," + sql_Nomefunc + ","
              + dadosTela.IdFuncFerias +")";

            try
            {
               SqlConnection cn = new SqlConnection();
               conexao.conexao();
               cn = conexao.abrirConexao();
               conexao.executeNonQuery(sql, cn);
               conexao.fecharConexao(cn);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
    }



}


