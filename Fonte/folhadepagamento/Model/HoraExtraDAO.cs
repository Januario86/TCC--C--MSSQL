using System;
using System.Collections.Generic;
using System.Text;
using folhadepagamento.VO;
using folhadepagamento.Control;
using System.Data.SqlClient;

namespace folhadepagamento.Model
{
    class HoraExtraDAO
    {
        //Autor: Felipe Januário 02-09-2015
        //Método Responsável por inserir os dados do Funcionário/HOraExtra na Base
        //frmHoraExtra

        public void CadastrarHoraExtraDAO(HoraExtraVO dadosTela )
        {
            ConecctionBase conexao = new ConecctionBase();

            string sql_idempregador;
            string    sql_cpf;            

            sql_idempregador = "(select id_empregador from Funcionario where id_funcionario =" + dadosTela.IdFuncionario + ")";
            sql_cpf          = "(select cpf_func from Funcionario where id_funcionario =" + dadosTela.IdFuncionario + ")";

            String sql      =" INSERT INTO dbo.hora_extra("
                            + "qtd_hora_extra,dt_hr_extra,Empregador_id_empregador,Funcionario_id_funcionario,cpf_func)"
                            + "VALUES("+dadosTela.QtdHora+ ",'"+ dadosTela.DataReferencia +"',"+sql_idempregador+ "," 
                            +  dadosTela.IdFuncionario+","+sql_cpf+")";
            try
            {
                SqlConnection cn = new SqlConnection();
                conexao.conexao();
                cn = conexao.abrirConexao();
                conexao.executeNonQuery(sql,cn);
                conexao.fecharConexao(cn);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
    }
}


