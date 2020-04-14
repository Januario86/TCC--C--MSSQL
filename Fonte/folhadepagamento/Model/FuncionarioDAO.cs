using System;
using System.Collections.Generic;
using System.Text;
using folhadepagamento.VO;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;


namespace folhadepagamento.Model
{
    class FuncionarioDAO
    {
        //Autor: Felipe Januário 14-08-2015
        //Método Responsável por inserir os dados do Funcionário na Base
        //frmCadastroFuncionário
        public void Cadastrarfuncionario(FuncionarioVO funcionarioVO)
        {
            ConecctionBase conexao = new ConecctionBase();

            string sql_idempregador;

            sql_idempregador = "(select id_empregador from Empregador where id_Empregador ="+ funcionarioVO.NomeEmpregador +")";

            String sql =

                " INSERT INTO Funcionario ("
                + "uf_func,nome_func,bairro_func,cel_func,cep_func,cidade_func,cpf_func,tel_func,email_func,dt_entrada_func,end_func,id_empregador,rg_func,numero_func"
                + ",jornada_semanal,jornada_diaria,data_pagamento,vale_transporte,valor_diario,"
                    + "qtd_dias_trabalho,carteira_trabalho,serie,salario,orgao_emissor)"
                + "VALUES((select id_uf from uf where id_uf ="+funcionarioVO.Uf+"),'"
                + funcionarioVO.NomeFunc +"','"+funcionarioVO.Bairro+"','"
                + funcionarioVO.Celular+"','" + funcionarioVO.Cep +"','"
                + funcionarioVO.Cidade+"','"+funcionarioVO.Cpf+"','" 
                + funcionarioVO.Telefone+ "','"+funcionarioVO.Email+"','"
                + funcionarioVO.DataAdmissao + "','"+funcionarioVO.Endereco +"',"
                + sql_idempregador+",'"+funcionarioVO.rgFunc+"'," 
                + funcionarioVO.NumeroFunc+"," 
                + funcionarioVO.QtdDiasPorSemana + "," + funcionarioVO.QtdHorasPorDia + ",'"
                + funcionarioVO.DataPagamento + "','" + funcionarioVO.ValeTransporte + "',"
                + funcionarioVO.ValorDiarioVale + "," + funcionarioVO.QtdDiarioTrabalho + ",'"
                + funcionarioVO.carteira + "'," + funcionarioVO.serie + "," 
                + funcionarioVO.salario + ",'"
                + funcionarioVO.orgaoEmissor + "')";
           
            /*
            string sqlContrato = "";
              sqlContrato = "INSERT INTO Contrato_trabalho ("
                    + "jornada_semanal,jornada_diaria,data_pagamento,vale_transporte,valor_diario,"
                    + "qtd_dias_trabalho,carteira_trabalho,serie,salario,orgao_emissor,CEI,id_empregador)"
                    + "VALUES("
                    + contratoVo.QtdDiasPorSemana+","+contratoVo.QtdHorasPorDia+ ",'"
                    + contratoVo.DataPagamento+"','"+contratoVo.ValeTransporte+"',"
                    + contratoVo.ValorDiarioVale+","+contratoVo.QtdDiarioTrabalho+",'"
                    + contratoVo.carteira+"',"+contratoVo.serie+","+contratoVo.salario+",'"
                    + contratoVo.orgaoEmissor+"',"+contratoVo.CEI+"," ;*/

            try
            {
                SqlConnection cn = new SqlConnection();
                conexao.conexao();
                cn=conexao.abrirConexao();
                conexao.executeNonQuery(sql,cn);
                conexao.fecharConexao(cn);

               /* conexao.conexao();
                conexao.abrirConexao();
                conexao.executeQuery(sql);
                conexao.fecharConexao(conexao.abrirConexao());*/
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        //Autor: Felipe Januário 14-08-2015
        //Método Responsável por carregar os dados do Funcionário
        //frmCadastroFuncionário

        
        public DataTable buscarfuncionarioDAO()
        {
            ConecctionBase conexao = new ConecctionBase();

            String sql = "select * from dbo.funcionario order by nome_func";
            DataTable retornoFunc;
            try
            {
                SqlConnection cn = new SqlConnection();

                //Conectar ao banco
                /*conexao.conexao();
                cn                  = conexao.abrirConexao();
                retornoFunc         = conexao.executeQuery(sql, cn);
                conexao.fecharConexao(cn);
                */
                conexao.conexao();
                cn=conexao.abrirConexao();
                retornoFunc = conexao.executeQuery(sql,cn);
                conexao.fecharConexao(conexao.abrirConexao());

                return retornoFunc;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        //Autor: Felipe Januário 02-09-2015
        //Método Responsável por carregar os dados do Funcionario
        //frmCadastroFuncionário

        public DataTable gridFuncionarioDAO(int i)
        {
            ConecctionBase conexao = new ConecctionBase();

            String sql = "select * from dbo.Funcionario where id_funcionario="+i+"";

            DataTable retornoEmp;
            try
            {
                SqlConnection cn = new SqlConnection();
                conexao.conexao();
                cn=conexao.abrirConexao();
                retornoEmp = conexao.executeQuery(sql, cn);
                conexao.fecharConexao(conexao.abrirConexao());

                /* SqlConnection cn = new SqlConnection();

                 conexao.conexao();
                 cn = conexao.abrirConexao();
                 retornoEmp = conexao.executeQuery(sql, cn);
                 conexao.fecharConexao(cn);*/

                return retornoEmp;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

    }
}
