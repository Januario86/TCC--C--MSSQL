using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using folhadepagamento.View;


namespace folhadepagamento.View
{
    public partial class frmFormPrincipal : Form
    {
        public frmFormPrincipal()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastroEmpregador frmCadastrarEmpregador = new frmCadastroEmpregador();
            frmCadastrarEmpregador.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionários frmCadastrarFuncionario = new frmCadastroFuncionários();
            frmCadastrarFuncionario.Show();
        }

        private void tabFuncionario_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionários frmCadastrarFuncionario = new frmCadastroFuncionários();
            frmCadastrarFuncionario.Show();
        }

        private void frmFormPrincipal_Load(object sender, EventArgs e)
        {
            //frmCadastroFuncionários frmCadastrarFuncionario = new frmCadastroFuncionários();
            //frmCadastrarFuncionario.Show();
           ;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmCadastroFuncionários frmCadastrarFuncionario = new frmCadastroFuncionários();
            frmCadastrarFuncionario.Show();

           

        }

        private void empregadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEmpregador frmEmpregador = new frmCadastroEmpregador();
            frmEmpregador.Show();
        }

        private void empregadorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultarEmpregador frmEmpregador = new frmConsultarEmpregador();
            frmEmpregador.Show();
        }

        private void licençaMédicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroLicencaMedica frmLicenca = new frmCadastroLicencaMedica();
            frmLicenca.Show();
        }

        private void horaExtraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoraExtra frmHoraExtra = new frmHoraExtra();
            frmHoraExtra.Show();
        }

        private void faltasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recisãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecisao frmrecisao = new frmRecisao();

            frmrecisao.Show();

        }

        private void fériasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFérias frmFerias = new frmCadastroFérias();
            frmFerias.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorios Relatorio = new frmRelatorios();
            Relatorio.Show();
        }

        private void faltasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCadastroFaltas frmFaltas = new frmCadastroFaltas();
            frmFaltas.Show();
        }
    }
}
