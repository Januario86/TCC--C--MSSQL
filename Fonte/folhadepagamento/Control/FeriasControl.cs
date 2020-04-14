using System;
using System.Collections.Generic;
using System.Text;
using folhadepagamento.VO;
using folhadepagamento.Model;

namespace folhadepagamento.Control
{
    class FeriasControl
    {
        //Autor Felipe Januário - 10/09/2015
        //Método responsável por cadastrar os Dados referente as ferias
        //frmCadastroFuncionário
        public Boolean CadastrarFerias(FeriasVO dadosTela)
        {
            try
            {
                //Chama a classe DAO
                FeriasDAO feriasDAO = new FeriasDAO();
                feriasDAO.CadastrarFeriasDAO(dadosTela);
                           

               
                return true;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }


    }
}
