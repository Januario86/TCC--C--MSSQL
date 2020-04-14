using System;
using System.Collections.Generic;
using System.Text;
using folhadepagamento.VO;
using folhadepagamento.Model;


namespace folhadepagamento.Control
{
    class FaltaControl
    {
        //Autor Felipe Januário - 29/09/2015
        //Método responsável por cadastrar os Dados referente as faltas
        //frmCadastroFaltaFuncionário
        public Boolean CadastrarFaltas(FaltaVO dadosTela)
        {
            try
            {
                //Chama a classe DAO
                faltaDAO faltaDAO = new faltaDAO();
                faltaDAO.CadastrarFaltasDAO(dadosTela);

                return true;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }




    }
}
