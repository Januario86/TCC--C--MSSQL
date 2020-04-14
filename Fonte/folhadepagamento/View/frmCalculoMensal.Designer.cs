namespace folhadepagamento.View
{
    partial class frmCalculoMensal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbcCalculoMensal = new System.Windows.Forms.TabControl();
            this.TbpHoraExtra = new System.Windows.Forms.TabPage();
            this.dtGrdCalculo = new System.Windows.Forms.DataGridView();
            this.Func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FGTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empregador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraExtra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValeTransporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelarAtualizacao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGerar = new System.Windows.Forms.Button();
            this.LblMesReFCalculo = new System.Windows.Forms.Label();
            this.mesReferenciaCQ = new System.Windows.Forms.DateTimePicker();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.TbcCalculoMensal.SuspendLayout();
            this.TbpHoraExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdCalculo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbcCalculoMensal
            // 
            this.TbcCalculoMensal.Controls.Add(this.TbpHoraExtra);
            this.TbcCalculoMensal.Location = new System.Drawing.Point(9, 22);
            this.TbcCalculoMensal.Name = "TbcCalculoMensal";
            this.TbcCalculoMensal.SelectedIndex = 0;
            this.TbcCalculoMensal.Size = new System.Drawing.Size(775, 486);
            this.TbcCalculoMensal.TabIndex = 4;
            // 
            // TbpHoraExtra
            // 
            this.TbpHoraExtra.Controls.Add(this.dtGrdCalculo);
            this.TbpHoraExtra.Controls.Add(this.btnCancelarAtualizacao);
            this.TbpHoraExtra.Controls.Add(this.panel1);
            this.TbpHoraExtra.Location = new System.Drawing.Point(4, 22);
            this.TbpHoraExtra.Name = "TbpHoraExtra";
            this.TbpHoraExtra.Padding = new System.Windows.Forms.Padding(3);
            this.TbpHoraExtra.Size = new System.Drawing.Size(767, 460);
            this.TbpHoraExtra.TabIndex = 0;
            this.TbpHoraExtra.Text = "Cálculo Mensal";
            this.TbpHoraExtra.UseVisualStyleBackColor = true;
            // 
            // dtGrdCalculo
            // 
            this.dtGrdCalculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdCalculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Func,
            this.INSS,
            this.FGTS,
            this.Empregador,
            this.Salario,
            this.HoraExtra,
            this.ValeTransporte,
            this.Faltas,
            this.SalarioLiquido});
            this.dtGrdCalculo.Location = new System.Drawing.Point(10, 84);
            this.dtGrdCalculo.Name = "dtGrdCalculo";
            this.dtGrdCalculo.Size = new System.Drawing.Size(754, 308);
            this.dtGrdCalculo.TabIndex = 7;
            this.dtGrdCalculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdCalculo_CellContentClick);
            // 
            // Func
            // 
            this.Func.HeaderText = "Funcionário";
            this.Func.Name = "Func";
            // 
            // INSS
            // 
            this.INSS.HeaderText = "Percentual INSS";
            this.INSS.Name = "INSS";
            // 
            // FGTS
            // 
            this.FGTS.HeaderText = "Percentual FGTS";
            this.FGTS.Name = "FGTS";
            // 
            // Empregador
            // 
            this.Empregador.HeaderText = "Empregador";
            this.Empregador.Name = "Empregador";
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Salário Base";
            this.Salario.Name = "Salario";
            // 
            // HoraExtra
            // 
            this.HoraExtra.HeaderText = "Hora Extra";
            this.HoraExtra.Name = "HoraExtra";
            // 
            // ValeTransporte
            // 
            this.ValeTransporte.HeaderText = "Vale Transporte";
            this.ValeTransporte.Name = "ValeTransporte";
            // 
            // Faltas
            // 
            this.Faltas.HeaderText = "Faltas";
            this.Faltas.Name = "Faltas";
            // 
            // SalarioLiquido
            // 
            this.SalarioLiquido.HeaderText = "Salario Liquido";
            this.SalarioLiquido.Name = "SalarioLiquido";
            // 
            // btnCancelarAtualizacao
            // 
            this.btnCancelarAtualizacao.Location = new System.Drawing.Point(10, 417);
            this.btnCancelarAtualizacao.Name = "btnCancelarAtualizacao";
            this.btnCancelarAtualizacao.Size = new System.Drawing.Size(101, 26);
            this.btnCancelarAtualizacao.TabIndex = 4;
            this.btnCancelarAtualizacao.Text = "Cancelar";
            this.btnCancelarAtualizacao.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGerar);
            this.panel1.Controls.Add(this.LblMesReFCalculo);
            this.panel1.Controls.Add(this.mesReferenciaCQ);
            this.panel1.Controls.Add(this.txtNomeFunc);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 72);
            this.panel1.TabIndex = 0;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(481, 22);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(101, 26);
            this.btnGerar.TabIndex = 6;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            // 
            // LblMesReFCalculo
            // 
            this.LblMesReFCalculo.AutoSize = true;
            this.LblMesReFCalculo.Location = new System.Drawing.Point(329, 13);
            this.LblMesReFCalculo.Name = "LblMesReFCalculo";
            this.LblMesReFCalculo.Size = new System.Drawing.Size(82, 13);
            this.LblMesReFCalculo.TabIndex = 5;
            this.LblMesReFCalculo.Text = "Mês Referência";
            // 
            // mesReferenciaCQ
            // 
            this.mesReferenciaCQ.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mesReferenciaCQ.Location = new System.Drawing.Point(332, 28);
            this.mesReferenciaCQ.Name = "mesReferenciaCQ";
            this.mesReferenciaCQ.Size = new System.Drawing.Size(108, 20);
            this.mesReferenciaCQ.TabIndex = 4;
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(13, 28);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(301, 20);
            this.txtNomeFunc.TabIndex = 1;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(10, 13);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(62, 13);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Funcionário";
            // 
            // frmCalculoMensal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 547);
            this.Controls.Add(this.TbcCalculoMensal);
            this.Name = "frmCalculoMensal";
            this.Text = "::: Cálculo Mensal :::";
            this.Load += new System.EventHandler(this.frmCalculoMensal_Load);
            this.TbcCalculoMensal.ResumeLayout(false);
            this.TbpHoraExtra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdCalculo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbcCalculoMensal;
        private System.Windows.Forms.TabPage TbpHoraExtra;
        private System.Windows.Forms.Button btnCancelarAtualizacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.DataGridView dtGrdCalculo;
        private System.Windows.Forms.Label LblMesReFCalculo;
        private System.Windows.Forms.DateTimePicker mesReferenciaCQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Func;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FGTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empregador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraExtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValeTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faltas;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioLiquido;
        private System.Windows.Forms.Button btnGerar;
    }
}