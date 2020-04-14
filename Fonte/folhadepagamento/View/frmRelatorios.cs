using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace folhadepagamento.View
{
    public partial class frmRelatorios : Form
    {
       // private object printDocument;

        public frmRelatorios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TbpRecibos_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'folhaDataSet.Funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.folhaDataSet.Funcionario);
            // TODO: This line of code loads data into the 'folhaDataSet.faltas' table. You can move, or remove it, as needed.
            this.faltasTableAdapter.Fill(this.folhaDataSet.faltas);

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void btnImprimirFunc_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage_2(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dtgRelFuncioarios.Width, this.dtgRelFuncioarios.Height);
            dtgRelFuncioarios.DrawToBitmap(bm, new Rectangle(0, 0, this.dtgRelFuncioarios.Width, this.dtgRelFuncioarios.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

       }


        private void printDocument2_PrintPage_2(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.gridfaltasImprimir.Width, this.gridfaltasImprimir.Height);
            gridfaltasImprimir.DrawToBitmap(bm, new Rectangle(0, 0, this.gridfaltasImprimir.Width, this.gridfaltasImprimir.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDocument2.Print();
        }
    }
}
