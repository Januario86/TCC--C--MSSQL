using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using folhadepagamento.Control;
using folhadepagamento.Model;
using folhadepagamento.VO;
using System.Data.SqlClient;
using folhadepagamento.Util;

namespace folhadepagamento.View
{
    public partial class frmCadastroFaltas : Form
    {
        public frmCadastroFaltas()
        {
            InitializeComponent();
        }

        private void TbpCliente1_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastroFaltas_Load(object sender, EventArgs e)
        {
          //Popula combo Funcionario Nome
            cmbConsultarFuncFalta.DataSource    = new FuncionarioDAO().buscarfuncionarioDAO();
            cmbConsultarFuncFalta.ValueMember   = "id_Funcionario";
            cmbConsultarFuncFalta.DisplayMember = "nome_func";
            

            //Popula combo para consulta
            cmbFuncFalta.DataSource = new FuncionarioDAO().buscarfuncionarioDAO();
            cmbFuncFalta.ValueMember = "id_Funcionario";
            cmbFuncFalta.DisplayMember = "nome_func";
        }

        private void cmbConsultarFunc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FaltaVO falta = new FaltaVO();

            falta.DataFalta    =  dtpFalta.Value;
            falta.MotivoFalta  =  cmbMotivoFalta.SelectedItem.ToString(); ;
            falta.IdFuncFerias =  int.Parse(cmbConsultarFuncFalta.SelectedValue.ToString());

            //Passa os dados da tela para serem inseridos na base de dados
            Boolean retorno;
            FaltaControl faltacontrol = new FaltaControl();
            retorno = faltacontrol.CadastrarFaltas(falta);

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisarFerias_Click(object sender, EventArgs e)
        {

            int i = 0;
            i = int.Parse(cmbFuncFalta.SelectedValue.ToString());

            //Conexão com a base de dados
            string conec = "Data Source=MW7QIYIBB6JUNW\\SQLEXPRESS;Initial Catalog=folha;User ID='sa';Password='dDfFgGhH001';Language=Portuguese";
            SqlConnection cn = new SqlConnection(conec);
            SqlCommand sqlComm = new SqlCommand("select dt_falta,motivo_falta,nome_func  from dbo.faltas;", cn);

            SqlDataAdapter gridPopula = new SqlDataAdapter();
            gridPopula.SelectCommand = sqlComm;

            DataTable loadGrid = new DataTable();
            gridPopula.Fill(loadGrid);

            BindingSource bdSource = new BindingSource();
            bdSource.DataSource = loadGrid;
            gridConsultarFalta.DataSource = bdSource;
            gridPopula.Update(loadGrid);

            cn.Close();

        }

         private void gridConsultarFalta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void gridConsultarFalta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FaltaVO novogrid     = new FaltaVO();
            novogrid.MotivoFalta = gridConsultarFalta.SelectedCells.ToString();
            novogrid.MotivoFalta = gridConsultarFalta.SelectedCells.Count.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
    }

