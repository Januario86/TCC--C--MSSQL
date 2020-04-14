using System;
using System.Collections.Generic;
using System.Text;

namespace folhadepagamento.VO
{
    class ContratoTrabalhoVO
    {
        private int _ContratoTrabalho;
        private int _QtdHorasPorDia;
        private int _QtdDiasPorSemana;
        private DateTime _DataPagamento;
        private DateTime _HoraSaida;
        private char _ValeTransporte;
        private double _ValorDiarioVale;
        private int _QtdDiasTrabalho;
        private int _NroDependentes;
        private double _salario;
        private double _ValorVale;
        private int _QtdDiasValeTrans;
        private int _rgFunc;
        private string _carteira;
        private string _serie;
        private string _orgaoEmissor;
        private string _CEI;

        public int ContratoTrabalho
        {
            get { return _ContratoTrabalho; }
            set { _ContratoTrabalho = value; }

        }

        public int QtdHorasPorDia
        {
            get { return _QtdHorasPorDia; }
            set { _QtdHorasPorDia= value; }

        }

        public int QtdDiasPorSemana
        {
            get { return _QtdDiasPorSemana; }
            set { _QtdDiasPorSemana = value; }
        }

        public DateTime  DataPagamento
        {
            get { return _DataPagamento; }
            set { _DataPagamento = value; }

        }

        public DateTime HoraSaida
        {
            get { return _HoraSaida ; }
            set { _HoraSaida= value; }

        }

        public char ValeTransporte 
        {
            get { return _ValeTransporte ; }
            set { _ValeTransporte= value; }
        }

        public double ValorDiarioVale
        {
            get { return _ValorDiarioVale ; }
            set { _ValorDiarioVale = value; }

        }

        public int QtdDiarioTrabalho
        {
            get { return _QtdDiasTrabalho ; }
            set { _QtdDiasTrabalho = value; }

        }
        
        public int NroDependentes
        {
            get { return _NroDependentes ; }
            set { _NroDependentes = value; }

        }

        public double salario
        {
            get { return _salario ; }
            set { _salario = value; }

        }

        public double ValorVale 
        {
            get { return _ValorVale; }
            set { _ValorVale = value; }

        }

        public int QtdDiasValeTrans
        {
            get { return _QtdDiasValeTrans; }
            set { _QtdDiasValeTrans = value; }

        }

        public int rgFunc
        {
            get { return _rgFunc; }
            set { _rgFunc = value; }

        }
        public string carteira
        {
            get { return _carteira; }
            set { _carteira = value; }

        }
        public string serie
        {
            get { return _serie; }
            set { _serie = value; }

        }
        public string orgaoEmissor
        {
            get { return _orgaoEmissor; }
            set { _orgaoEmissor = value; }

        }
        public string CEI
        {
            get { return _CEI; }
            set { _CEI = value; }

        }

    }
}
