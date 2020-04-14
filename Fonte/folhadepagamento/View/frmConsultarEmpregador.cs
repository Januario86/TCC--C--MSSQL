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
    public partial class frmConsultarEmpregador : Form
    {
        public frmConsultarEmpregador()
        {
            InitializeComponent();
        }

        private void dtGridResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
        }

        private void ConsultarEmpregador_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'folhaDataSet.Contrato_trabalho' table. You can move, or remove it, as needed.
            //  this.contrato_trabalhoTableAdapter.Fill(this.folhaDataSet.Contrato_trabalho);
            // TODO: This line of code loads data into the 'folhaDataSet.Funcionario' table. You can move, or remove it, as needed.
            //  this.funcionarioTableAdapter.Fill(this.folhaDataSet.Funcionario);
            // TODO: This line of code loads data into the 'folhaDataSet.Empregador' table. You can move, or remove it, as needed.
            //  this.empregadorTableAdapter.Fill(this.folhaDataSet.Empregador);
                        
            
            //Carrega a combom contendo as informações do Empregador

            cmbEmpregadorConsultar.DataSource       = new EmpregadorDAO().buscaEmpregadorDAO();
            cmbEmpregadorConsultar.ValueMember      = "id_Empregador";
            cmbEmpregadorConsultar.DisplayMember    = "dsc_empregador";
        }

        private void btnConsultarEmpregador_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = int.Parse(cmbEmpregadorConsultar.SelectedValue.ToString());

            //Conexão com a base de dados
            string conec = "Data Source=CLAUDIAEFELIPE;Initial Catalog=folha;User ID='sa';Password='dDfFgGhH001';Language=Portuguese";
            SqlConnection cn = new SqlConnection(conec);
            SqlCommand sqlComm = new SqlCommand("select id_Empregador, dsc_empregador, cpf_empregador, cnpj_empregador, tel_empregador, cel_empregador,"
                        + "email_empregador,end_empregador,bairro_empregador,cep_empregador,uf_empregador,cidade_empregador,"
                        + "numero_empregador from dbo.Empregador where id_empregador=" + i + ";",cn);



               SqlDataAdapter gridPopula = new SqlDataAdapter();
                    gridPopula.SelectCommand = sqlComm;
                
                DataTable loadGrid = new DataTable();
                    gridPopula.Fill(loadGrid);

                BindingSource bdSource = new BindingSource();
                    bdSource.DataSource         = loadGrid;
                    gridEmpregador.DataSource   = bdSource;
                    gridPopula.Update(loadGrid);

                cn.Close();

            
                   

        }

        private void cmbEmpregadorConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridEmpregador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                        

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           /* try
            {
                this.funcionarioTableAdapter.FillBy(this.folhaDataSet.Funcionario, parameterNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
