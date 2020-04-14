using System;
using System.Collections.Generic;
using System.Text;
using folhadepagamento.VO;
using folhadepagamento.Model;
using System.Data;
using System.Data.OleDb;

namespace folhadepagamento.Control
{
    class EmpregadorControl
    {

        //Autor Felipe Januário - 17/08/2015
        //Método responsável por cadastrar os Dados referentes ao Empregador
        //frmCadastroEmpregador
        public Boolean CadastrarEmpregador(EmpregadorVO empregadorVO)
        {
            try
            {
                //Chama a classe DAO para 
                EmpregadorDAO EmpregadorDAO = new EmpregadorDAO();
                EmpregadorDAO.CadastrarEmpregadorDAO(empregadorVO);
                      return true;

            }
            catch (Exception e)
            {
                throw (e);
            }
        }


        //Autor Felipe Januário - 19/08/2015
        //Método responsável por consultar os Dados referentes ao Empregador
        //frmCadastroEmpregador
        public Boolean buscarEmpregador(EmpregadorVO empregadorVO)
        {
            try
            {  //Chama a classe DAO para 
                EmpregadorDAO EmpregadorDAO = new EmpregadorDAO();
                EmpregadorDAO.buscaEmpregadorDAO();
                return true;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        //Autor Felipe Januário - 22/09/2015
        //Método responsável por Popular a Grid Empregador
        //frmCadastroEmpregador

        public Boolean gridEmpregadorControl(int empregador)
        {
            try
            {
                //Chama a classe DAO
                EmpregadorDAO EmpregadorDAO = new EmpregadorDAO();
                EmpregadorDAO.gridEmpregadorDAO(empregador);
                return true;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

    }
}
