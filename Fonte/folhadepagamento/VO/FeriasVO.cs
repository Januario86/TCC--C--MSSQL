using System;
using System.Collections.Generic;
using System.Text;

namespace folhadepagamento.VO
{
    class FeriasVO
    {

        // id_funcionario
        // qtd_dias_ferias, dt_entrada_ferias, dt_retorno_ferias,

        private int _idFuncionario;
        private int _qtdDiasFerias;
        private DateTime _dtEntradaFerias;
        private DateTime _dtRetornoFerias;

        public int IdFuncFerias
        {
            get { return _idFuncionario; }
            set { _idFuncionario = value; }
        }

        public int QtdDiasFerias
        {
            get { return _qtdDiasFerias; }
            set { _qtdDiasFerias = value; }
        }

        public DateTime DtEntradaFerias
        {
            get { return _dtEntradaFerias; }
            set { _dtEntradaFerias = value; }
        }

        public DateTime DtRetornoFerias
        {
            get { return _dtRetornoFerias; }
            set { _dtRetornoFerias = value; }
        }

    }
}
