using System;
using System.Collections.Generic;
using System.Text;

namespace folhadepagamento.VO
{
    class FaltaVO
     {
        private DateTime _DataFalta;
        private string   _MotivoFalta;
        private int _idFuncionario;

        public DateTime DataFalta
        {
            get { return _DataFalta; }
            set { _DataFalta = value; }
        }

        public string MotivoFalta
        {
            get { return _MotivoFalta; }
            set { _MotivoFalta = value; }
        }

        public int IdFuncFerias
        {
            get { return _idFuncionario; }
            set { _idFuncionario = value; }
        }
    }
}
