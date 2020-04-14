using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Drawing;


namespace folhadepagamento.VO
{
    class LicencaVO
    {

        private DateTime _dtEntrada;
        private string _tipoLicenca;
        private int _idFuncionarioLicenca;


        public int idFuncionario
        {
            get { return _idFuncionarioLicenca; }
            set { _idFuncionarioLicenca = value; }
        }

        public DateTime dtEntradaLicenca
        {
            get { return _dtEntrada; }
            set { _dtEntrada = value; }
        }

        public string TipoLicenca
        {
            get { return _tipoLicenca; }
            set { _tipoLicenca = value; }
        }

    }
}
