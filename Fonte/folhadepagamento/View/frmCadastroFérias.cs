using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using folhadepagamento.VO;
using folhadepagamento.Control;
using folhadepagamento.Util;
using folhadepagamento.Model;
using System.Data.SqlClient;

namespace folhadepagamento.View
{
    public partial class frmCadastroFérias : Form
    {
        public frmCadastroFérias()
        {
            InitializeComponent();
        }

        private void frmCadastroFérias_Load(object sender, EventArgs e)
        {

            //Carrega a Combo inicial com o nome dos Funcionários
            cmbConsultarFunc.DataSource = new FuncionarioDAO().buscarfuncionarioDAO();
            cmbConsultarFunc.ValueMember = "id_funcionario";
            cmbConsultarFunc.DisplayMember = "nome_func";


            //Carrega a combo do nome Funcionarios para verificar os que foram cadastrados
            cmbFuncFerias.DataSource = new FuncionarioDAO().buscarfuncionarioDAO();
            cmbFuncFerias.ValueMember = "id_funcionario";
            cmbFuncFerias.DisplayMember = "nome_func";

          }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private bool validaErros()
        {
            if (txQtdDias.Text.Trim() == String.Empty)
                return true;            

            return false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaErros())
            {
                //Exibe a mensagem padrão de preencher todos os campos
                PadraoMensagem mensagem = new PadraoMensagem();
                mensagem.PreencherCampo();    
            }
            else
            {
                //Recebe os dados da Tela
                FeriasVO ferias        = new FeriasVO();

                ferias.DtEntradaFerias = dtpInicioFerias.Value;
                ferias.DtRetornoFerias = dtpRetornoFerias.Value;
                ferias.QtdDiasFerias   = int.Parse(txQtdDias.Text);
                ferias.IdFuncFerias    = int.Parse(cmbConsultarFunc.SelectedValue.ToString());

                //Chama  o método do control passando os dados da tela como parâmetro
                Boolean retorno;
                FeriasControl feriasControl = new FeriasControl();

                retorno = feriasControl.CadastrarFerias(ferias);

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
        }

        private void btnPesquisarFerias_Click(object sender, EventArgs e)
        {

            int i = 0;
            i = int.Parse(cmbFuncFerias.SelectedValue.ToString());

            //Conexão com a base de dados
            //MW7QIYIBB6JUNW\\SQLEXPRESS
            string conec = "Data Source=CLAUDIAEFELIPE;Initial Catalog=folha;User ID='sa';Password='dDfFgGhH001';Language=Portuguese";
            SqlConnection cn = new SqlConnection(conec);
            SqlCommand sqlComm = new SqlCommand("select fe.dt_entrada_ferias, fe.dt_retorno_ferias, fe.qtd_dias_ferias,"
                        + "func.nome_func, func.dt_entrada_func from dbo.ferias fe inner join dbo.Funcionario func "
                        + "on func.id_funcionario = fe.Funcionario_id_funcionario and func.id_funcionario=" + i + ";", cn);
            
            SqlDataAdapter gridPopula = new SqlDataAdapter();
            gridPopula.SelectCommand = sqlComm;

            DataTable loadGrid = new DataTable();
            gridPopula.Fill(loadGrid);

            
            BindingSource bdSource = new BindingSource();
            bdSource.DataSource = loadGrid;
            gridConsultarFerias.DataSource = bdSource;
            gridPopula.Update(loadGrid);

            cn.Close();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {

            Int32 rowToDelete = this.gridConsultarFerias.Rows.GetFirstRow(
            DataGridViewElementStates.Selected);
            if (rowToDelete > -1)
            {
                int i = 1;

                i = i+ rowToDelete;

                this.gridConsultarFerias.Rows.RemoveAt(rowToDelete);

                //Conexão com a base de dados
                string conec = "Data Source= MW7QIYIBB6JUNW\\SQLEXPRESS;Initial Catalog = folha;User ID='sa';Password='dDfFgGhH001';Language=Portuguese";
                SqlConnection cn = new SqlConnection(conec);
                SqlCommand sqlComm = new SqlCommand("delete from ferias where id_ferias ="+i, cn);

                /*SqlDataAdapter gridPopula = new SqlDataAdapter();
                gridPopula.SelectCommand = sqlComm;

                DataTable loadGrid = new DataTable();
                gridPopula.Fill(loadGrid);


                BindingSource bdSource = new BindingSource();
                bdSource.DataSource = loadGrid;
                gridConsultarFerias.DataSource = bdSource;
                gridPopula.Update(loadGrid);
                */
                cn.Close();

            }
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
        }
    }
}
