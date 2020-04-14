namespace folhadepagamento.View
{
    partial class frmCadastroLicencaMedica
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
            this.TbcLincecas = new System.Windows.Forms.TabControl();
            this.TbpHoraExtra = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbTipoLincencaFunc = new System.Windows.Forms.ComboBox();
            this.LblTipodeLicença = new System.Windows.Forms.Label();
            this.dtLicencaEntrada = new System.Windows.Forms.DateTimePicker();
            this.LblDtInicio = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCancelarAtualizacao = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbFuncLicenca = new System.Windows.Forms.ComboBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblLicenca = new System.Windows.Forms.Label();
            this.gridFuncionarioLi = new System.Windows.Forms.DataGridView();
            this.btnPesquisarLic = new System.Windows.Forms.Button();
            this.cmbFuncLi = new System.Windows.Forms.ComboBox();
            this.btnAlterarLice = new System.Windows.Forms.Button();
            this.btnExcluirLice = new System.Windows.Forms.Button();
            this.TbcLincecas.SuspendLayout();
            this.TbpHoraExtra.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionarioLi)).BeginInit();
            this.SuspendLayout();
            // 
            // TbcLincecas
            // 
            this.TbcLincecas.Controls.Add(this.TbpHoraExtra);
            this.TbcLincecas.Controls.Add(this.tabPage1);
            this.TbcLincecas.Location = new System.Drawing.Point(20, 13);
            this.TbcLincecas.Name = "TbcLincecas";
            this.TbcLincecas.SelectedIndex = 0;
            this.TbcLincecas.Size = new System.Drawing.Size(775, 486);
            this.TbcLincecas.TabIndex = 4;
            // 
            // TbpHoraExtra
            // 
            this.TbpHoraExtra.Controls.Add(this.panel2);
            this.TbpHoraExtra.Controls.Add(this.btnVoltar);
            this.TbpHoraExtra.Controls.Add(this.btnCancelarAtualizacao);
            this.TbpHoraExtra.Controls.Add(this.btnSalvar);
            this.TbpHoraExtra.Controls.Add(this.panel1);
            this.TbpHoraExtra.Location = new System.Drawing.Point(4, 22);
            this.TbpHoraExtra.Name = "TbpHoraExtra";
            this.TbpHoraExtra.Padding = new System.Windows.Forms.Padding(3);
            this.TbpHoraExtra.Size = new System.Drawing.Size(767, 460);
            this.TbpHoraExtra.TabIndex = 0;
            this.TbpHoraExtra.Text = "Licenças ";
            this.TbpHoraExtra.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbTipoLincencaFunc);
            this.panel2.Controls.Add(this.LblTipodeLicença);
            this.panel2.Controls.Add(this.dtLicencaEntrada);
            this.panel2.Controls.Add(this.LblDtInicio);
            this.panel2.Location = new System.Drawing.Point(8, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 315);
            this.panel2.TabIndex = 4;
            // 
            // cmbTipoLincencaFunc
            // 
            this.cmbTipoLincencaFunc.AutoCompleteCustomSource.AddRange(new string[] {
            "Maternidade",
            "Médica"});
            this.cmbTipoLincencaFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoLincencaFunc.FormattingEnabled = true;
            this.cmbTipoLincencaFunc.Items.AddRange(new object[] {
            "Médica",
            "Maternidade"});
            this.cmbTipoLincencaFunc.Location = new System.Drawing.Point(154, 75);
            this.cmbTipoLincencaFunc.Name = "cmbTipoLincencaFunc";
            this.cmbTipoLincencaFunc.Size = new System.Drawing.Size(197, 21);
            this.cmbTipoLincencaFunc.TabIndex = 21;
            this.cmbTipoLincencaFunc.SelectedIndexChanged += new System.EventHandler(this.cmbTipoLincencaFunc_SelectedIndexChanged);
            // 
            // LblTipodeLicença
            // 
            this.LblTipodeLicença.AutoSize = true;
            this.LblTipodeLicença.Location = new System.Drawing.Point(151, 50);
            this.LblTipodeLicença.Name = "LblTipodeLicença";
            this.LblTipodeLicença.Size = new System.Drawing.Size(84, 13);
            this.LblTipodeLicença.TabIndex = 6;
            this.LblTipodeLicença.Text = "Tipo de Licença";
            // 
            // dtLicencaEntrada
            // 
            this.dtLicencaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLicencaEntrada.Location = new System.Drawing.Point(13, 75);
            this.dtLicencaEntrada.Name = "dtLicencaEntrada";
            this.dtLicencaEntrada.Size = new System.Drawing.Size(108, 20);
            this.dtLicencaEntrada.TabIndex = 2;
            // 
            // LblDtInicio
            // 
            this.LblDtInicio.AutoSize = true;
            this.LblDtInicio.Location = new System.Drawing.Point(10, 50);
            this.LblDtInicio.Name = "LblDtInicio";
            this.LblDtInicio.Size = new System.Drawing.Size(70, 13);
            this.LblDtInicio.TabIndex = 2;
            this.LblDtInicio.Text = "Data Entrada";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(282, 415);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 30);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarAtualizacao
            // 
            this.btnCancelarAtualizacao.Location = new System.Drawing.Point(142, 415);
            this.btnCancelarAtualizacao.Name = "btnCancelarAtualizacao";
            this.btnCancelarAtualizacao.Size = new System.Drawing.Size(101, 30);
            this.btnCancelarAtualizacao.TabIndex = 4;
            this.btnCancelarAtualizacao.Text = "Cancelar";
            this.btnCancelarAtualizacao.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(6, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 28);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbFuncLicenca);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 72);
            this.panel1.TabIndex = 0;
            // 
            // cmbFuncLicenca
            // 
            this.cmbFuncLicenca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncLicenca.FormattingEnabled = true;
            this.cmbFuncLicenca.Location = new System.Drawing.Point(13, 29);
            this.cmbFuncLicenca.Name = "cmbFuncLicenca";
            this.cmbFuncLicenca.Size = new System.Drawing.Size(338, 21);
            this.cmbFuncLicenca.TabIndex = 20;
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExcluirLice);
            this.tabPage1.Controls.Add(this.btnAlterarLice);
            this.tabPage1.Controls.Add(this.lblLicenca);
            this.tabPage1.Controls.Add(this.gridFuncionarioLi);
            this.tabPage1.Controls.Add(this.btnPesquisarLic);
            this.tabPage1.Controls.Add(this.cmbFuncLi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 460);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Consultar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblLicenca
            // 
            this.lblLicenca.AutoSize = true;
            this.lblLicenca.Location = new System.Drawing.Point(21, 28);
            this.lblLicenca.Name = "lblLicenca";
            this.lblLicenca.Size = new System.Drawing.Size(65, 13);
            this.lblLicenca.TabIndex = 3;
            this.lblLicenca.Text = "Funcionário:";
            // 
            // gridFuncionarioLi
            // 
            this.gridFuncionarioLi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFuncionarioLi.Location = new System.Drawing.Point(24, 114);
            this.gridFuncionarioLi.Name = "gridFuncionarioLi";
            this.gridFuncionarioLi.Size = new System.Drawing.Size(704, 187);
            this.gridFuncionarioLi.TabIndex = 2;
            // 
            // btnPesquisarLic
            // 
            this.btnPesquisarLic.Location = new System.Drawing.Point(440, 57);
            this.btnPesquisarLic.Name = "btnPesquisarLic";
            this.btnPesquisarLic.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarLic.TabIndex = 1;
            this.btnPesquisarLic.Text = "Pesquisar";
            this.btnPesquisarLic.UseVisualStyleBackColor = true;
            this.btnPesquisarLic.Click += new System.EventHandler(this.btnPesquisarLic_Click);
            // 
            // cmbFuncLi
            // 
            this.cmbFuncLi.FormattingEnabled = true;
            this.cmbFuncLi.Location = new System.Drawing.Point(24, 57);
            this.cmbFuncLi.Name = "cmbFuncLi";
            this.cmbFuncLi.Size = new System.Drawing.Size(345, 21);
            this.cmbFuncLi.TabIndex = 0;
            // 
            // btnAlterarLice
            // 
            this.btnAlterarLice.Location = new System.Drawing.Point(24, 344);
            this.btnAlterarLice.Name = "btnAlterarLice";
            this.btnAlterarLice.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarLice.TabIndex = 4;
            this.btnAlterarLice.Text = "Alterar";
            this.btnAlterarLice.UseVisualStyleBackColor = true;
            // 
            // btnExcluirLice
            // 
            this.btnExcluirLice.Location = new System.Drawing.Point(143, 344);
            this.btnExcluirLice.Name = "btnExcluirLice";
            this.btnExcluirLice.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirLice.TabIndex = 5;
            this.btnExcluirLice.Text = "Excluir";
            this.btnExcluirLice.UseVisualStyleBackColor = true;
            // 
            // frmCadastroLicencaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 512);
            this.Controls.Add(this.TbcLincecas);
            this.Name = "frmCadastroLicencaMedica";
            this.Text = "::: Cadastro de Licença Médica :::";
            this.Load += new System.EventHandler(this.frmCadastroLicencaMedica_Load);
            this.TbcLincecas.ResumeLayout(false);
            this.TbpHoraExtra.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionarioLi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbcLincecas;
        private System.Windows.Forms.TabPage TbpHoraExtra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtLicencaEntrada;
        private System.Windows.Forms.Label LblDtInicio;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCancelarAtualizacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblTipodeLicença;
        private System.Windows.Forms.ComboBox cmbFuncLicenca;
        private System.Windows.Forms.ComboBox cmbTipoLincencaFunc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblLicenca;
        private System.Windows.Forms.DataGridView gridFuncionarioLi;
        private System.Windows.Forms.Button btnPesquisarLic;
        private System.Windows.Forms.ComboBox cmbFuncLi;
        private System.Windows.Forms.Button btnExcluirLice;
        private System.Windows.Forms.Button btnAlterarLice;
    }
}