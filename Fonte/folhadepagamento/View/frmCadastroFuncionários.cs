using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using folhadepagamento.VO;
using System.Data.OleDb;
using folhadepagamento.Control;
using folhadepagamento.Model;
using folhadepagamento.Util;
using System.Data.SqlClient;

namespace folhadepagamento.View
{
    public partial class frmCadastroFuncionários : Form
    {
        public frmCadastroFuncionários()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmFormPrincipal FormPrincipal = new frmFormPrincipal();      
            //frmCadastroFuncionários Funcionarios = new frmCadastroFuncionários();

            FormPrincipal.Show();
            this.Close();         
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNomeConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void dtGridResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {           
           //Pega os dados da Tela e passa para o insert na base tabela Funcionario
            FuncionarioVO funcionarioVO = new FuncionarioVO();

            //Valida Nome
            if (txtNomeFunc.Text=="") {
                MessageBox.Show("Favor preencher o campo Nome!");
                this.Close();
            }
            else {funcionarioVO.NomeFunc = txtNomeFunc.Text; }

            //valida CPF
            if (txtCPF.Text == "")
            {
                MessageBox.Show("Favor preencher o campo CPF!");
                this.Close();

            }
            else {funcionarioVO.Cpf = txtCPF.Text;}
                        
            funcionarioVO.Bairro            = txtBairro.Text;
            funcionarioVO.Celular           = txtCel.Text;
            funcionarioVO.Cep               = txtCep.Text;
            funcionarioVO.Cidade            = txtCidade.Text;
            funcionarioVO.Endereco          = txtEndereco.Text;
            funcionarioVO.Email             = txtEmail.Text;
            funcionarioVO.DataAdmissao      = dtpNascimento.Value;
            funcionarioVO.Telefone          = txtTel.Text;
            funcionarioVO.NumeroFunc        = txtNumeroFunc.Text;
            funcionarioVO.Uf                = cmbUF.SelectedValue.ToString();
            funcionarioVO.NomeEmpregador    = cmbNomeEmpregador.SelectedValue.ToString();

                                   
            //Validação para transporte
            if (rbtValeNao.Checked)
            {
                funcionarioVO.ValeTransporte = rbtValeNao.Text;
                funcionarioVO.QtdDiasValeTrans = 0;
                funcionarioVO.ValorDiarioVale  = 0.0;
            }
            else
            {
                funcionarioVO.ValeTransporte = rbtValeSim.Text;
                funcionarioVO.QtdDiasValeTrans = int.Parse(txtQdtDiasVale.Text);
                funcionarioVO.ValorDiarioVale  = double.Parse(txtValorDiario.Text);
            }

            //Recebe os valores da parte de contrato de trabalho

            funcionarioVO.DataPagamento = dtPagamento.Value;
            
            //Valida RG
                if (txtRgFunc.Text == "")
                    {
                        MessageBox.Show("Favor preencher o campo RG!");
                    }
                else { funcionarioVO.rgFunc = int.Parse(txtRgFunc.Text); }

            //valida qtd horas p dia
               if (txtQdtHorasPordia.Text == "")
                    {
                        MessageBox.Show("Favor preencher o campo Jornada Diária!");
                    }
                else { funcionarioVO.QtdHorasPorDia = int.Parse(txtQdtHorasPordia.Text); }

            //Valida qtd dia trabalhados na semana
            if (txtQtdDiasPorSemana.Text == "")
                    {

                       MessageBox.Show("Favor preencher o campo Jornada semanal!");
                }
                else { funcionarioVO.QtdDiasPorSemana = int.Parse(txtQtdDiasPorSemana.Text); }

            //valida carteira 
            if (txtCarteira.Text=="")
            {

                MessageBox.Show("Favor preencher o campo Carteira!");
            }
            else { funcionarioVO.carteira = txtCarteira.Text; }

            //valida serie 
            if (txtSerie.Text == "")
            {

                MessageBox.Show("Favor preencher o campo serie!");
            }
            else { funcionarioVO.serie = txtSerie.Text; }

            //valida Salario 
            if (dbSalario.Text == "")
            {

                MessageBox.Show("Favor preencher o campo Salário!");
            }
            else { funcionarioVO.SalarioBase = double.Parse(dbSalario.Text); }

            //valida orgão Emissor 
            if (txtOrgaoEmissor.Text == "")
            {

                MessageBox.Show("Favor preencher o campo Orgão Emissor!");
            }
            else { funcionarioVO.orgaoEmissor = txtOrgaoEmissor.Text;}

            // funcionarioVO.QtdDiarioTrabalho    = int.Parse(txtQtdDiasPorSemana.Text);
            //  funcionarioVO.QtdHorasPorDia       = int.Parse(txtQdtHorasPordia.Text);
            
            //--------------------------------------------
            //Chama o control passando os dados da tela
            Boolean retorno;
            FuncionarioControl funcionarioControl = new FuncionarioControl();
               retorno= funcionarioControl.CadastrarFuncionario(funcionarioVO);
          
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

        }

        private void LimparCampos()
        {
            txtNomeFunc.Text    = "";
            txtTel.Text    = "";
            txtCel.Text     = "";
            txtEmail.Text       = "";
            txtCPF.Text     = "";
            cmbUF.Text          = "";
            txtCidade.Text      = "";
            txtBairro.Text      = "";
            txtEndereco.Text    = "";
            txtCep.Text         = "";
            txtCarteira.Text = "";
            txtOrgaoEmissor.Text = "";
            txtQdtDiasVale.Text = "";
            txtQdtHorasPordia.Text = "";
            txtQtdDiasPorSemana.Text = "";
            txtRgFunc.Text = "";
            txtSerie.Text ="";
            txtValorDiario.Text = "";
            rbtValeNao.Text = "";
            rbtValeSim.Text = "";
        }

        private void LblNasc_Click(object sender, EventArgs e)
        {

        }

        private void txtCPFCNPJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCadastroFuncionários_Load(object sender, EventArgs e)
        {
            //Popula combo UF
            cmbUF.DataSource    = new UfDAO().buscarUfDAO();
            cmbUF.ValueMember   = "id_uf";
            cmbUF.DisplayMember = "uf_uf";

            //Popula combo Funcionario Nome
            cmbNomeFunc.DataSource      =   new FuncionarioDAO().buscarfuncionarioDAO();
            cmbNomeFunc.ValueMember     =   "id_Funcionario";
            cmbNomeFunc.DisplayMember   =   "nome_func";

            //Popula combo Empregador
            cmbNomeEmpregador.DataSource        =   new EmpregadorDAO().buscaEmpregadorDAO();
            cmbNomeEmpregador.ValueMember       =   "id_empregador";
            cmbNomeEmpregador.DisplayMember     =   "dsc_empregador";
                      

        }

        private void TbpCliente1_Click(object sender, EventArgs e)
        {
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelarAtualizacao_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbUF_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void dbSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int i = 0;
            i = int.Parse(cmbNomeFunc.SelectedValue.ToString());

            //Conexão com a base de dados
            string conec = "Data Source=CLAUDIAEFELIPE;Initial Catalog=folha;User ID='sa';Password='dDfFgGhH001';Language=Portuguese";
            SqlConnection cn = new SqlConnection(conec);
            SqlCommand sqlComm = new SqlCommand("select nome_func,bairro_func,cel_func,cep_func,cidade_func,"
                + "cpf_func,tel_func,email_func,dt_entrada_func,end_func,rg_func,"
                + "numero_func from dbo.funcionario where id_funcionario=" + i + ";", cn);

            SqlDataAdapter gridPopula = new SqlDataAdapter();
            gridPopula.SelectCommand = sqlComm;

            DataTable loadGrid = new DataTable();
            gridPopula.Fill(loadGrid);

            BindingSource bdSource = new BindingSource();
            bdSource.DataSource = loadGrid;
            gridFuncionarioCad.DataSource = bdSource;
            gridPopula.Update(loadGrid);

            cn.Close();



        }
        
        private void gridFuncionarioCad_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbNomeFunc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblCPFCNPJ_Click(object sender, EventArgs e)
        {

        }
    }
}
