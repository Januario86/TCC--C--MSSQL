using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using folhadepagamento.Model;
using folhadepagamento.VO;
using folhadepagamento.Control;
using folhadepagamento.Util;
using System.Data.SqlClient;


namespace folhadepagamento.View
{
    public partial class frmRecisao : Form
    {
        public frmRecisao()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void frmRecisao_Load(object sender, EventArgs e)
        {
            cmbNomeFunc.DataSource      = new FuncionarioDAO().buscarfuncionarioDAO();
            cmbNomeFunc.ValueMember     = "id_funcionario";
            cmbNomeFunc.DisplayMember   = "nome_func";

            //xtCodigoAluno.Text = dt.Rows[0]["Cod_Aluno"].ToString();
            //txtNomeAluno.Text = dt.Rows[0]["Nome_Aluno"].ToString();
                        
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            //cria o objeto para receber os valores da tela
            RecisaoVO recisaoVO = new RecisaoVO();

            //validação
            int result = DateTime.Compare(dtpDataSaidaRecisao.Value, dtpEntradaRecisao.Value);
            //caso a data de Saída seja superior a data de entrada segue mensagem
            if (result < 0)
            {
               MessageBox.Show("Data de saída não pode ser superior a data de entrada");
            }
            //Caso data de saída seja inferior a data de Entrada
            else {

                //recebe os valores da tela
                recisaoVO.dtEntrada     = dtpEntradaRecisao.Value;
                recisaoVO.dtSaida       = dtpDataSaidaRecisao.Value;
                recisaoVO.avisoPrevio   = cmbAviso.SelectedValue.ToString();
                recisaoVO.motivoSaida   = cmbMotivoSaida.SelectedValue.ToString();
                recisaoVO.ultimoSalario = double.Parse(txtUltimoSalario.Text);

                //valida o Radio button das Férias Vencidas
                if (rdbSim.Checked)
                {
                    recisaoVO.feriasVencidas = rdbSim.Text;
                }
                else
                {
                    recisaoVO.feriasVencidas = rdbNao.Text;
                }

                //Chama o control passando os dados da tela
                Boolean retorno;

                RecisaoControl recisaoControl = new RecisaoControl();
                retorno = recisaoControl.CalcularRecisao(recisaoVO);
                
                //Classe de Mensagens
                PadraoMensagem mensagem = new PadraoMensagem();
                if (retorno == true)
                {
                    this.Close();
                    mensagem.cadastroSucesso();
                }
                else
                {
                    this.Close();
                    mensagem.cadastroFailed();
                }
            }//Encerra o primeiro if da validação de DATAS

        }
    }
}
