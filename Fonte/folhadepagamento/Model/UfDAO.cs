using System;
using System.Collections.Generic;
using System.Text;
using folhadepagamento.VO;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace folhadepagamento.Model
{
    class UfDAO
    {
        //Autor: Felipe Januário 18-08-2015
        //Método Responsável por buscar UF na base
        //frmCadastroFuncionário
        public DataTable buscarUfDAO()
        {
            ConecctionBase conexao = new ConecctionBase();

            String sql = "select id_uf,dsc_uf,uf_uf from dbo.uf order by dsc_uf";
            DataTable retorno;

            try
            {
                SqlConnection cn = new SqlConnection();
                conexao.conexao();
                cn=conexao.abrirConexao();
                retorno = conexao.executeQuery(sql,cn);
                conexao.fecharConexao(conexao.abrirConexao());

                return retorno;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
    }
}
