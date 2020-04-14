using System;
using System.Collections.Generic;
using System.Text;
using folhadepagamento.VO;
using folhadepagamento.Model;


namespace folhadepagamento.Control
{
    class RecisaoControl
    {
        //Autor Felipe Januário - 28/10/2015
        //Método responsável por cadastrar os Dados referentes a Recisão
        //frmCadastroFuncionário
        public Boolean CadastrarRecisao(RecisaoVO recisaoVO)
        {
            try
            {
                //Chama a classe DAO             

                // FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
                // funcionarioDAO.Cadastrarfuncionario(funcionarioVO, contratoVO);
                return true;

            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        //Autor Felipe Januário - 28/10/2015
        //Método responsável por calcular os Dados referentes ao Recisão
        //frmCadastroFuncionário
        public Boolean CalcularRecisao(RecisaoVO recisaoVO)
        {
            try
            {
                int periodo = 0;
                int entrada = 0;
                int saida = 0;

                entrada = int.Parse(recisaoVO.dtEntrada.ToString());
                saida   = int.Parse(recisaoVO.dtSaida.ToString());
                periodo = entrada - saida;
                

                return true;

            }
            catch (Exception e)
            {
                throw (e);
            }




        }

    }
}
