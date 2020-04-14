using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using folhadepagamento.VO;
using folhadepagamento.Control;
using folhadepagamento.Model;
using folhadepagamento.Util;
using System.Data.SqlClient;


namespace folhadepagamento.View
{
    public partial class frmCadastroEmpregador : Form
    {
        

        public frmCadastroEmpregador()
        {
            InitializeComponent();
        }

        private void DadosCadastrais_Load(object sender, EventArgs e)
        {
            //Validação de campos númericos

           /* this.txtTelefone.Validating += new System.ComponentModel.CancelEventHandler(this.Telefone_Validating);
            this.txtCel.Validating  += new System.ComponentModel.CancelEventHandler(this.Celular_Validating);
            this.txtCep.Validating      += new System.ComponentModel.CancelEventHandler(this.Cep_Validating);
            this.txtNumeroEmp.Validating += new System.ComponentModel.CancelEventHandler(this.Num_Validating);

            //Valida Campos Alfanúmericos
            this.txtNome.Validating     += new System.ComponentModel.CancelEventHandler(this.Nome_Validating);
            this.txtCPFCNPJ.Validating  += new System.ComponentModel.CancelEventHandler(this.CPF_Validating);
            */

            //Carrega Combo UF
            cmbUFEmp.DataSource = new UfDAO().buscarUfDAO();
            cmbUFEmp.ValueMember = "id_uf";
            cmbUFEmp.DisplayMember = "uf_uf";


            //Carregad Combo Empregador para Consultas
            cmbEmpregadorConsultar.DataSource = new EmpregadorDAO().buscaEmpregadorDAO();
            cmbEmpregadorConsultar.ValueMember = "id_Empregador";
            cmbEmpregadorConsultar.DisplayMember = "dsc_empregador";

            /*
            cmbEmpregador.DataSource = new EmpregadorDAO().buscaEmpregadorDAO();
            cmbEmpregador.ValueMember = "id_Empregador";
            cmbEmpregador.DisplayMember = "dsc_empregador";
            */

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void LblNome_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void TbpCliente1_Click(object sender, EventArgs e)
        {
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtCel.Text = "";
            txtEmail.Text = "";
            txtCPFCNPJ.Text = "";
            cmbUFEmp.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtEndereco.Text = "";
            txtCep.Text = "";
            txtCidade.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            EmpregadorVO empregadorVO   = new EmpregadorVO();
            List<EmpregadorVO> listaEmp = new List<EmpregadorVO>();           
            
            empregadorVO.CelEmpregador      = txtCel.Text;
            empregadorVO.CepEmpregador      = txtCep.Text;
            empregadorVO.CidadeEmpregador   = txtCidade.Text;
            empregadorVO.CpfEmpregador      = txtCPFCNPJ.Text;
            empregadorVO.EmailEmpregador    = txtEmail.Text;
            empregadorVO.EndEmpregador      = txtEndereco.Text;
            empregadorVO.NomeEmpregador     = txtNome.Text;
            empregadorVO.TelEmpregador      = txtTelefone.Text;
            empregadorVO.bairroEmpregador   = txtBairro.Text;
            empregadorVO.NumeroEmpregador   = txtNumeroEmp.Text;
            empregadorVO.UfEmpregador       = cmbUFEmp.SelectedValue.ToString();            
            

            //VALIDAÇÃO
            // listaEmp.Add(empregadorVO);
            //Cria a lista de objetos para preenchimento do EmpregadorVO
            /* for (i=0; i<listaEmp.Count;i++)
                {                                                                                                   
            }*/

            //Chama o control passando os dados da tela
            Boolean retorno;
            EmpregadorControl empregadorControl = new EmpregadorControl();
            retorno = empregadorControl.CadastrarEmpregador(empregadorVO);

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

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbUF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void txtCPFCNPJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbUFEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TbpCliente2_Click(object sender, EventArgs e)
        {

        }

        private void cmbEmpregador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtGridResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
        /*
        //Valida Telefone
        protected void Telefone_Validating(object sender,System.ComponentModel.CancelEventArgs e)
        {
            try
            {   int tel = Int32.Parse(txtTelefone.Text);
                errorProvider1.SetError(txtTelefone, "");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtTelefone, "Preencher telefone somente com números.");
            }
        }

        //Valida Celular
        protected void Celular_Validating(object sender,System.ComponentModel.CancelEventArgs e)
        {
            try
            {   int tel = Int32.Parse(txtCel.Text);
                errorProvider1.SetError(txtCel, "");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCel,"Preencher Celular somente com números.");
            }
        }

        //Valida Campo Empregador
        protected void Nome_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                String x = txtNome.Text;
                errorProvider1.SetError(txtNome,"");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNome,"Favor preencher empregador.");
            }
        }

        //Valida CPF/CNPJ
        protected void CPF_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                int x = Int32.Parse(txtCPFCNPJ.Text);
                errorProvider1.SetError(txtCPFCNPJ, "");
              
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCPFCNPJ, "Preencher CPF/CNPJ somente com números.");                
            }            
        }

        //Valida Cep
        protected void Cep_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                int x = Int32.Parse(txtCep.Text);
                errorProvider1.SetError(txtCep, "");

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCep, "Preencher CEP somente com números.");
            }
        }

        //Valida Número
        protected void Num_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                int x = Int32.Parse(txtNumeroEmp.Text);
                errorProvider1.SetError(txtNumeroEmp, "");

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNumeroEmp, "Preencher CEP somente com números.");
            }
        }*/

        public void btnConsultarEmpregador_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = int.Parse(cmbEmpregadorConsultar.SelectedValue.ToString());

            //Conecta na base de dados
            string conec = "Data Source=MW7QIYIBB6JUNW\\SQLEXPRESS;Initial Catalog=folha;User ID='sa';Password='dDfFgGhH001';Language=Portuguese";
            SqlConnection cn = new SqlConnection(conec);
            SqlCommand sqlComm = new SqlCommand("select id_Empregador, dsc_empregador, cpf_empregador, cnpj_empregador, tel_empregador, cel_empregador,"
                        + "email_empregador,end_empregador,bairro_empregador,cep_empregador,uf_empregador,cidade_empregador,"
                        + "numero_empregador from dbo.Empregador where id_empregador=" + i + ";", cn);

            //Executa a query p popular a GRID

            SqlDataAdapter gridPopula = new SqlDataAdapter();
            
            gridPopula.SelectCommand = sqlComm;

            //Carrega a Grid
            
            DataTable loadGrid = new DataTable();
            gridPopula.Fill(loadGrid);

            //Popula a GRID
            BindingSource bdSource = new BindingSource();
            bdSource.DataSource = loadGrid;
            gridEmpregador.DataSource = bdSource;
            gridPopula.Update(loadGrid);

        }// Fim do Botão empregador

        public void btnAlterar_Click(object sender, EventArgs e)
        {
            /* // vamos salvar os dados do DataGridView para a tabela do
            // banco de dados
            // Dica: Se estiver usando SQL Server, troque "Odbc" por
            // "Sql" (Ex: SqlCommandBuilder)
            // obtém a conexão com o banco de dados
            
            conn = ConexaoODBC.obterConexao();*/

            //Conecta na base de dados
            /*string conec = "Data Source=MW7QIYIBB6JUNW\\SQLEXPRESS;Initial Catalog=folha;User ID='sa';Password='dDfFgGhH001';Language=Portuguese";
            SqlConnection cn = new SqlConnection(conec);

            SqlDataAdapter gridAlterar = new SqlDataAdapter();
            gridAlterar = gridPopula;

            if (conec != null)
                {
                    SqlCommandBuilder cm = new SqlCommandBuilder(gridAlterar);
                    cm.GetUpdateCommand();
                     gridAlterar.Update(loadGrid.Tables["dbo.Empregador"]);*/

                      
          /*  for (int i = 0; i< gridEmpregador.RowCount;i++)
            {
                List<String> updateEmpregador = new List<String>();

                //(this.gridEmpregador.Rows[i].Cells[i].Value.ToString());
                updateEmpregador.Add(this.gridEmpregador.Rows[i].Cells[i].ToString());                           
                                         

            }

            */
            
        }
        

    }
}
