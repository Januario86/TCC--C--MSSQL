using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using folhadepagamento.VO;
using folhadepagamento.Control;

namespace folhadepagamento.VO
{
    class UfVO
    {
        private string _dscUF;
        private string _uf_uf;


        public string dscUF
        {
            get { return _dscUF; }
            set { _dscUF = value; }
        }

        public string uf_uf
        {
            get { return _uf_uf; }
            set { _uf_uf = value; }
        }
        
    }
}
