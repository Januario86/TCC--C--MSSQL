using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Drawing;

namespace folhadepagamento.VO
{
    class RecisaoVO
    {

        private DateTime _dtEntrada;
        private DateTime _dtSaida;
        private string _motivoSaida;
        private double _ultimoSalario;
        private string _feriasVencidas;
        private string _avisoPrevio;


        public DateTime dtEntrada
        {
            get { return _dtEntrada; }
            set { _dtEntrada = value; }
        }

        public DateTime dtSaida
        {
            get { return _dtSaida; }
            set { _dtSaida = value; }
        }

        public string motivoSaida
        {
            get { return _motivoSaida; }
            set { _motivoSaida = value; }
        }

        public double ultimoSalario
        {
            get { return _ultimoSalario; }
            set { _ultimoSalario = value; }
        }

        public string feriasVencidas
        {
            get { return _feriasVencidas; }
            set { _feriasVencidas = value; }
        }

        public string avisoPrevio
        {
            get { return _avisoPrevio; }
            set { _avisoPrevio = value; }
        }

    }
    
}
