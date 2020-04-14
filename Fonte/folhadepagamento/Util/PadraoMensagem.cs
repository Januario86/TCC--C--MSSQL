using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace folhadepagamento.Util
{
    class PadraoMensagem
    {
        //Mensagem de cadastro

        public Boolean cadastroSucesso()
        {
            try
            {
                MessageBox.Show("Cadastro Efetuado com Sucesso");

                return true;
            }
            catch (Exception e)
            {
                throw (e);
            }    
        }

        public Boolean cadastroFailed()
        {
            try
            {
                MessageBox.Show("Não foi possível cadastrar");

                return true;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
        //inicio pesquisa
        public Boolean PesquisaInválida()
        {
            try
            {
                MessageBox.Show("Não foi possível realizar a Pesquisa, tente novamente!");

                return true;
            }
            catch (Exception e)
            {
                throw (e);
            }
         }//fim pesquisa 

        //Início Preencher Campo
        public Boolean PreencherCampo()
        {
            try
            {
                MessageBox.Show("Favor preencher todos os campos");

                return true;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
    }
}
