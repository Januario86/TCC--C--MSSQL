namespace folhadepagamento.View
{
    partial class frmRecisao
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
            this.tbpConsultar = new System.Windows.Forms.TabPage();
            this.gridEmpregador = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpfHoraConsulta = new System.Windows.Forms.TextBox();
            this.txtFuncHoraConsulta = new System.Windows.Forms.TextBox();
            this.lblConsultarNomefunc = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TbpRecisao = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblAvisoPrevio = new System.Windows.Forms.Label();
            this.cmbAviso = new System.Windows.Forms.ComboBox();
            this.LblUltimoSalario = new System.Windows.Forms.Label();
            this.txtUltimoSalario = new System.Windows.Forms.TextBox();
            this.LblMotivoRecisao = new System.Windows.Forms.Label();
            this.cmbMotivoSaida = new System.Windows.Forms.ComboBox();
            this.dtpDataSaidaRecisao = new System.Windows.Forms.DateTimePicker();
            this.LblDtSaidaRecisao = new System.Windows.Forms.Label();
            this.dtpEntradaRecisao = new System.Windows.Forms.DateTimePicker();
            this.LblDtEntradaRecisao = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbNomeFunc = new System.Windows.Forms.ComboBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.TbcRecisao = new System.Windows.Forms.TabControl();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.tbpConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpregador)).BeginInit();
            this.TbpRecisao.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TbcRecisao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpConsultar
            // 
            this.tbpConsultar.Controls.Add(this.gridEmpregador);
            this.tbpConsultar.Controls.Add(this.label2);
            this.tbpConsultar.Controls.Add(this.txtCpfHoraConsulta);
            this.tbpConsultar.Controls.Add(this.txtFuncHoraConsulta);
            this.tbpConsultar.Controls.Add(this.lblConsultarNomefunc);
            this.tbpConsultar.Controls.Add(this.btnExcluir);
            this.tbpConsultar.Controls.Add(this.btnAlterar);
            this.tbpConsultar.Controls.Add(this.button3);
            this.tbpConsultar.Controls.Add(this.label5);
            this.tbpConsultar.Location = new System.Drawing.Point(4, 22);
            this.tbpConsultar.Name = "tbpConsultar";
            this.tbpConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsultar.Size = new System.Drawing.Size(767, 460);
            this.tbpConsultar.TabIndex = 3;
            this.tbpConsultar.Text = "Consultar ";
            this.tbpConsultar.UseVisualStyleBackColor = true;
            // 
            // gridEmpregador
            // 
            this.gridEmpregador.AllowUserToAddRows = false;
            this.gridEmpregador.AllowUserToDeleteRows = false;
            this.gridEmpregador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.gridEmpregador.Location = new System.Drawing.Point(11, 159);
            this.gridEmpregador.MultiSelect = false;
            this.gridEmpregador.Name = "gridEmpregador";
            this.gridEmpregador.ReadOnly = true;
            this.gridEmpregador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmpregador.Size = new System.Drawing.Size(744, 168);
            this.gridEmpregador.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "Empregador";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "CPF";
            // 
            // txtCpfHoraConsulta
            // 
            this.txtCpfHoraConsulta.Location = new System.Drawing.Point(295, 75);
            this.txtCpfHoraConsulta.Name = "txtCpfHoraConsulta";
            this.txtCpfHoraConsulta.Size = new System.Drawing.Size(161, 20);
            this.txtCpfHoraConsulta.TabIndex = 20;
            // 
            // txtFuncHoraConsulta
            // 
            this.txtFuncHoraConsulta.Location = new System.Drawing.Point(11, 75);
            this.txtFuncHoraConsulta.Name = "txtFuncHoraConsulta";
            this.txtFuncHoraConsulta.Size = new System.Drawing.Size(179, 20);
            this.txtFuncHoraConsulta.TabIndex = 14;
            // 
            // lblConsultarNomefunc
            // 
            this.lblConsultarNomefunc.AutoSize = true;
            this.lblConsultarNomefunc.Location = new System.Drawing.Point(11, 59);
            this.lblConsultarNomefunc.Name = "lblConsultarNomefunc";
            this.lblConsultarNomefunc.Size = new System.Drawing.Size(62, 13);
            this.lblConsultarNomefunc.TabIndex = 18;
            this.lblConsultarNomefunc.Text = "Funcionário";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(155, 375);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 26);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(13, 375);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 26);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 25);
            this.button3.TabIndex = 13;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 12;
            // 
            // TbpRecisao
            // 
            this.TbpRecisao.Controls.Add(this.panel2);
            this.TbpRecisao.Controls.Add(this.btnVoltar);
            this.TbpRecisao.Controls.Add(this.btnSalvar);
            this.TbpRecisao.Controls.Add(this.panel1);
            this.TbpRecisao.Location = new System.Drawing.Point(4, 22);
            this.TbpRecisao.Name = "TbpRecisao";
            this.TbpRecisao.Padding = new System.Windows.Forms.Padding(3);
            this.TbpRecisao.Size = new System.Drawing.Size(767, 460);
            this.TbpRecisao.TabIndex = 0;
            this.TbpRecisao.Text = "Recisão ";
            this.TbpRecisao.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbNao);
            this.panel2.Controls.Add(this.rdbSim);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.LblAvisoPrevio);
            this.panel2.Controls.Add(this.cmbAviso);
            this.panel2.Controls.Add(this.LblUltimoSalario);
            this.panel2.Controls.Add(this.txtUltimoSalario);
            this.panel2.Controls.Add(this.LblMotivoRecisao);
            this.panel2.Controls.Add(this.cmbMotivoSaida);
            this.panel2.Controls.Add(this.dtpDataSaidaRecisao);
            this.panel2.Controls.Add(this.LblDtSaidaRecisao);
            this.panel2.Controls.Add(this.dtpEntradaRecisao);
            this.panel2.Controls.Add(this.LblDtEntradaRecisao);
            this.panel2.Location = new System.Drawing.Point(8, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 315);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Férias Vencidas";
            // 
            // LblAvisoPrevio
            // 
            this.LblAvisoPrevio.AutoSize = true;
            this.LblAvisoPrevio.Location = new System.Drawing.Point(10, 70);
            this.LblAvisoPrevio.Name = "LblAvisoPrevio";
            this.LblAvisoPrevio.Size = new System.Drawing.Size(66, 13);
            this.LblAvisoPrevio.TabIndex = 9;
            this.LblAvisoPrevio.Text = "Aviso Prévio";
            // 
            // cmbAviso
            // 
            this.cmbAviso.FormattingEnabled = true;
            this.cmbAviso.Items.AddRange(new object[] {
            "Indenizado",
            "Trabalhado"});
            this.cmbAviso.Location = new System.Drawing.Point(13, 86);
            this.cmbAviso.Name = "cmbAviso";
            this.cmbAviso.Size = new System.Drawing.Size(145, 21);
            this.cmbAviso.TabIndex = 8;
            // 
            // LblUltimoSalario
            // 
            this.LblUltimoSalario.AutoSize = true;
            this.LblUltimoSalario.Location = new System.Drawing.Point(493, 14);
            this.LblUltimoSalario.Name = "LblUltimoSalario";
            this.LblUltimoSalario.Size = new System.Drawing.Size(71, 13);
            this.LblUltimoSalario.TabIndex = 7;
            this.LblUltimoSalario.Text = "Último Salário";
            // 
            // txtUltimoSalario
            // 
            this.txtUltimoSalario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUltimoSalario.Location = new System.Drawing.Point(496, 31);
            this.txtUltimoSalario.Name = "txtUltimoSalario";
            this.txtUltimoSalario.Size = new System.Drawing.Size(102, 20);
            this.txtUltimoSalario.TabIndex = 4;
            // 
            // LblMotivoRecisao
            // 
            this.LblMotivoRecisao.AutoSize = true;
            this.LblMotivoRecisao.Location = new System.Drawing.Point(309, 15);
            this.LblMotivoRecisao.Name = "LblMotivoRecisao";
            this.LblMotivoRecisao.Size = new System.Drawing.Size(86, 13);
            this.LblMotivoRecisao.TabIndex = 6;
            this.LblMotivoRecisao.Text = "Motivo da Saída";
            // 
            // cmbMotivoSaida
            // 
            this.cmbMotivoSaida.FormattingEnabled = true;
            this.cmbMotivoSaida.Items.AddRange(new object[] {
            "Pedido de Demissão",
            "Dispensa sem Justa Causa",
            "Dispensa com Justa Causa"});
            this.cmbMotivoSaida.Location = new System.Drawing.Point(312, 31);
            this.cmbMotivoSaida.Name = "cmbMotivoSaida";
            this.cmbMotivoSaida.Size = new System.Drawing.Size(145, 21);
            this.cmbMotivoSaida.TabIndex = 5;
            // 
            // dtpDataSaidaRecisao
            // 
            this.dtpDataSaidaRecisao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataSaidaRecisao.Location = new System.Drawing.Point(146, 32);
            this.dtpDataSaidaRecisao.Name = "dtpDataSaidaRecisao";
            this.dtpDataSaidaRecisao.Size = new System.Drawing.Size(108, 20);
            this.dtpDataSaidaRecisao.TabIndex = 3;
            // 
            // LblDtSaidaRecisao
            // 
            this.LblDtSaidaRecisao.AutoSize = true;
            this.LblDtSaidaRecisao.Location = new System.Drawing.Point(143, 15);
            this.LblDtSaidaRecisao.Name = "LblDtSaidaRecisao";
            this.LblDtSaidaRecisao.Size = new System.Drawing.Size(62, 13);
            this.LblDtSaidaRecisao.TabIndex = 4;
            this.LblDtSaidaRecisao.Text = "Data Saída";
            // 
            // dtpEntradaRecisao
            // 
            this.dtpEntradaRecisao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntradaRecisao.Location = new System.Drawing.Point(13, 31);
            this.dtpEntradaRecisao.Name = "dtpEntradaRecisao";
            this.dtpEntradaRecisao.Size = new System.Drawing.Size(108, 20);
            this.dtpEntradaRecisao.TabIndex = 2;
            // 
            // LblDtEntradaRecisao
            // 
            this.LblDtEntradaRecisao.AutoSize = true;
            this.LblDtEntradaRecisao.Location = new System.Drawing.Point(10, 14);
            this.LblDtEntradaRecisao.Name = "LblDtEntradaRecisao";
            this.LblDtEntradaRecisao.Size = new System.Drawing.Size(70, 13);
            this.LblDtEntradaRecisao.TabIndex = 2;
            this.LblDtEntradaRecisao.Text = "Data Entrada";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(147, 414);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 31);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(8, 414);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 31);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbNomeFunc);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 72);
            this.panel1.TabIndex = 0;
            // 
            // cmbNomeFunc
            // 
            this.cmbNomeFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeFunc.FormattingEnabled = true;
            this.cmbNomeFunc.Location = new System.Drawing.Point(13, 29);
            this.cmbNomeFunc.Name = "cmbNomeFunc";
            this.cmbNomeFunc.Size = new System.Drawing.Size(338, 21);
            this.cmbNomeFunc.TabIndex = 20;
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
            // TbcRecisao
            // 
            this.TbcRecisao.Controls.Add(this.TbpRecisao);
            this.TbcRecisao.Controls.Add(this.tbpConsultar);
            this.TbcRecisao.Location = new System.Drawing.Point(12, 18);
            this.TbcRecisao.Name = "TbcRecisao";
            this.TbcRecisao.SelectedIndex = 0;
            this.TbcRecisao.Size = new System.Drawing.Size(775, 486);
            this.TbcRecisao.TabIndex = 4;
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Location = new System.Drawing.Point(246, 86);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(45, 17);
            this.rdbNao.TabIndex = 15;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseVisualStyleBackColor = true;
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Location = new System.Drawing.Point(198, 86);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(42, 17);
            this.rdbSim.TabIndex = 14;
            this.rdbSim.TabStop = true;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            // 
            // frmRecisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.TbcRecisao);
            this.Name = "frmRecisao";
            this.Text = "::: Recisão :::";
            this.Load += new System.EventHandler(this.frmRecisao_Load);
            this.tbpConsultar.ResumeLayout(false);
            this.tbpConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpregador)).EndInit();
            this.TbpRecisao.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TbcRecisao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCpfHoraConsulta;
        private System.Windows.Forms.TextBox txtFuncHoraConsulta;
        private System.Windows.Forms.Label lblConsultarNomefunc;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage TbpRecisao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblAvisoPrevio;
        private System.Windows.Forms.ComboBox cmbAviso;
        private System.Windows.Forms.Label LblUltimoSalario;
        private System.Windows.Forms.TextBox txtUltimoSalario;
        private System.Windows.Forms.Label LblMotivoRecisao;
        private System.Windows.Forms.ComboBox cmbMotivoSaida;
        private System.Windows.Forms.DateTimePicker dtpDataSaidaRecisao;
        private System.Windows.Forms.Label LblDtSaidaRecisao;
        private System.Windows.Forms.DateTimePicker dtpEntradaRecisao;
        private System.Windows.Forms.Label LblDtEntradaRecisao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TabControl TbcRecisao;
        private System.Windows.Forms.ComboBox cmbNomeFunc;
        private System.Windows.Forms.DataGridView gridEmpregador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.RadioButton rdbSim;
    }
}