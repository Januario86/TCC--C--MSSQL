using System;
using System.Collections.Generic;
using System.Text;

namespace folhadepagamento.VO
{
    class LoginVO
    {
        private string _IdLogin;
        private string _IdSenha;
        private string _IdRecuperaSenha;

        public string Login
        {
            get { return _IdLogin; }
            set { _IdLogin = value; }
        }

        public string Senha
        {
            get { return _IdSenha; }
            set { _IdSenha = value; }
        }

        public string RecuperaSenha
        {
            get { return _IdRecuperaSenha; }
            set { _IdRecuperaSenha = value; }
        }
    }
}