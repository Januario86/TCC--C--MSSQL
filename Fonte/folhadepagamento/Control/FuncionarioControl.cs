using System;
using System.Collections.Generic;
using System.Text;
using folhadepagamento.VO;
using folhadepagamento.Model;
using System.Data;
using System.Data.OleDb;

namespace folhadepagamento.Control
{
    class FuncionarioControl
    {
        //Autor Felipe Januário - 13/08/2015
        //Método responsável por cadastrar os Dados referentes ao Funcionário
        //frmCadastroFuncionário
        public Boolean CadastrarFuncionario(FuncionarioVO funcionarioVO)
        {
            try
            {            
                   //Chama a classe control para 
                   FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
                   funcionarioDAO.Cadastrarfuncionario(funcionarioVO);
                     return true;               
            }
            catch (Exception e)
            {
                throw (e);
            }
        }     


    }
}
