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
    class EmpregadorDAO
    {
        //Autor: Felipe Januário 17-08-2015
        //Método Responsável por inserir os dados do Funcionário na Base
        //frmCadastroFuncionário

        public void CadastrarEmpregadorDAO(EmpregadorVO empregadorVO)
        {
            ConecctionBase conexao = new ConecctionBase();
           
            String sql =
                
                " INSERT INTO Empregador ("
                + "dsc_empregador,cpf_empregador,tel_empregador,cel_empregador,email_empregador,"
                + "end_empregador,bairro_empregador,cep_empregador,uf_empregador,cidade_empregador,numero_empregador)"
                + "VALUES('"
                + empregadorVO.NomeEmpregador + "',"+empregadorVO.CpfEmpregador +","
                + empregadorVO.TelEmpregador +","+ empregadorVO.CelEmpregador+ ",'"
                + empregadorVO.EmailEmpregador + "','"+ empregadorVO.EndEmpregador+ "','" +empregadorVO.bairroEmpregador + "',"
                + empregadorVO.CepEmpregador+ ",'"+ empregadorVO.UfEmpregador + "','"
                + empregadorVO.CidadeEmpregador + "','"+ empregadorVO.NumeroEmpregador
                + "')";
            try
            {
                SqlConnection cn = new SqlConnection();
                conexao.conexao();
                cn=conexao.abrirConexao();
                conexao.executeNonQuery(sql,cn);
                conexao.fecharConexao(cn);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }


        //Autor: Felipe Januário 26-08-2015
        //Método Responsável por carregar os dados do Empregador
        //frmCadastroFuncionário
       
        public DataTable buscaEmpregadorDAO()
        {
            ConecctionBase conexao = new ConecctionBase();

            String sql = "select id_Empregador,dsc_empregador,cpf_empregador,cnpj_empregador,tel_empregador,cel_empregador,"
                         +"email_empregador,end_empregador,bairro_empregador,cep_empregador,uf_empregador,cidade_empregador,"
                         +"numero_empregador from dbo.Empregador";

            DataTable retornoFunc;
            try
            {
                SqlConnection cn = new SqlConnection();
                conexao.conexao();
               cn= conexao.abrirConexao();
                retornoFunc = conexao.executeQuery(sql, cn);
                conexao.fecharConexao(conexao.abrirConexao());

                return retornoFunc;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        //Autor: Felipe Januário 26-08-2015
        //Método Responsável por carregar os dados do Empregador
        //frmCadastroFuncionário

        public DataTable gridEmpregadorDAO(int i)
        {
            ConecctionBase conexao = new ConecctionBase();

            String sql =  "select id_Empregador,dsc_empregador,cpf_empregador,cnpj_empregador,tel_empregador,cel_empregador,"
                        + "email_empregador,end_empregador,bairro_empregador,cep_empregador,uf_empregador,cidade_empregador,"
                        + "numero_empregador from dbo.Empregador where id_empregador="+i+"";

            DataTable retornoEmp;
              
           try
            {
                SqlConnection cn = new SqlConnection();
                conexao.conexao();
                cn=conexao.abrirConexao();
                retornoEmp = conexao.executeQuery(sql, cn);
                conexao.fecharConexao(conexao.abrirConexao());
                
                return retornoEmp;
            }

            catch (Exception e)
            {
                throw (e);
            }
        }
    }
}

