using System;
using System.Collections.Generic;
using System.Text;
using folhadepagamento.VO;
using System.Data.SqlClient;

namespace folhadepagamento.Model
{
    class FeriasDAO
    {
        public void CadastrarFeriasDAO(FeriasVO dadosTela)
        {
            ConecctionBase conexao = new ConecctionBase();

            string sql_idempregador;

            sql_idempregador = "(select id_empregador from Funcionario where id_funcionario =" + dadosTela.IdFuncFerias + ")";

            String sql = " INSERT INTO dbo.ferias("
              + "dt_entrada_ferias,dt_retorno_ferias,Empregador_id_Empregador,Funcionario_id_funcionario,qtd_dias_ferias)"
              + "VALUES('" + dadosTela.DtEntradaFerias + "','" + dadosTela.DtRetornoFerias+ "'," + sql_idempregador + ","
              + dadosTela.IdFuncFerias + "," + dadosTela.QtdDiasFerias +")";
            try
            {
                SqlConnection cn = new SqlConnection();
                conexao.conexao();
                cn = conexao.abrirConexao();
                conexao.executeNonQuery(sql, cn);
                conexao.fecharConexao(cn);
                // conexao.fecharConexao(conexao.abrirConexao());
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
    }
}
