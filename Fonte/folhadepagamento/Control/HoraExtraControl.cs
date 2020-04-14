using System;
using System.Collections.Generic;
using System.Text;
using folhadepagamento.VO;
using folhadepagamento.Model;


namespace folhadepagamento.Control
{
    class HoraExtraControl
    {

        //Autor Felipe Januário - 02/09/2015
        //Método responsável por cadastrar os Dados referentes ao Funcionário
        //frmCadastroFuncionário
        public Boolean CadastrarhoraExtra(HoraExtraVO dadosTela)
        {
            try
            {
                //Chama a classe DAO para realizar o insert na base de dados

                HoraExtraDAO horaExtraDAO = new HoraExtraDAO();

                     horaExtraDAO.CadastrarHoraExtraDAO(dadosTela);

                return true;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
    }
}

