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
    public partial class frmCadastroLicencaMedica : Form
    {
        public frmCadastroLicencaMedica()
        {
            InitializeComponent();
        }

        private void dtGridResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtNomeFunc_TextChanged(object sender, EventArgs e)
        {
        }

        private void frmCadastroLicencaMedica_Load(object sender, EventArgs e)
        {
            //Carrega a Combo contendo as informações do Funcinoário
            cmbFuncLicenca.DataSource     = new FuncionarioDAO().buscarfuncionarioDAO();
            cmbFuncLicenca.ValueMember    = "id_funcionario";
            cmbFuncLicenca.DisplayMember  = "nome_func";

            //Carrega a Combo contendo as informações do Funcinoário
            cmbFuncLi.DataSource          = new FuncionarioDAO().buscarfuncionarioDAO();
            cmbFuncLi.ValueMember         = "id_funcionario";
            cmbFuncLi.DisplayMember       = "nome_func";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Pega os dados da tela
            LicencaVO licenca = new LicencaVO();
            licenca.dtEntradaLicenca    = dtLicencaEntrada.Value; 
            licenca.idFuncionario       = int.Parse(cmbFuncLicenca.SelectedValue.ToString());
            licenca.TipoLicenca         = cmbTipoLincencaFunc.SelectedItem.ToString();


            //Chama o control passando os dados para o insert
            Boolean retorno;
            LicencaControl licencaControl = new LicencaControl();
            retorno =licencaControl.CadastrarLicenca(licenca);

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

        private void btnPesquisarLic_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = int.Parse(cmbFuncLi.SelectedValue.ToString());

            //Conexão com a base de dados
            string conec = "Data Source=CLAUDIAEFELIPE;Initial Catalog=folha;User ID='sa';Password='dDfFgGhH001';Language=Portuguese";
            SqlConnection cn = new SqlConnection(conec);
            SqlCommand sqlComm = new SqlCommand(" select li.cpf_funcionario as 'CPF',li.dt_inicio_licenca as 'Data_Entrada',"
                                               + "func.nome_func as 'Nome',li.Tipo_licenca as 'Tipo_licenca'"
                                             + " from licenca_medica li  inner join Funcionario func"
                                            + " on li.Funcionario_id_funcionario = func.id_funcionario "
                                    + "and func.id_funcionario = " + i + "",cn);

            SqlDataAdapter gridPopula = new SqlDataAdapter();
            gridPopula.SelectCommand = sqlComm;

            DataTable loadGrid = new DataTable();
            gridPopula.Fill(loadGrid);

            BindingSource bdSource = new BindingSource();
            bdSource.DataSource = loadGrid;
            gridFuncionarioLi.DataSource = bdSource;
            gridPopula.Update(loadGrid);

            cn.Close();


        }

        private void cmbTipoLincencaFunc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
