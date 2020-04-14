using System;
using System.Collections.Generic;
using System.Text;
using folhadepagamento.VO;
using folhadepagamento.Control;
using System.Data.SqlClient;

namespace folhadepagamento.Model
{
    class LicencaDAO
     {
        public void CadastrarLicencaDAO(LicencaVO dadosTela)
        {
            ConecctionBase conexao = new ConecctionBase();

            string sql_idempregador;
            string sql_cpf;

            sql_idempregador = "(select id_empregador from Funcionario where id_funcionario =" + dadosTela.idFuncionario + ")";
            sql_cpf = "(select cpf_func from Funcionario where id_funcionario =" + dadosTela.idFuncionario + ")";

            String sql = "INSERT INTO dbo.licenca_medica("
                       + "dt_inicio_licenca,cpf_funcionario,tipo_licenca,Empregador_id_empregador,Funcionario_id_funcionario)"
                       + "VALUES('"+ dadosTela.dtEntradaLicenca +"',"+ sql_cpf +",'"+dadosTela.TipoLicenca+"'," +  sql_idempregador + ","
                       + dadosTela.idFuncionario +")";
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
