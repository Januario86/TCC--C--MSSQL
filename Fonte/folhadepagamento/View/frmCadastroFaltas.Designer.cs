namespace folhadepagamento.View
{
    partial class frmCadastroFaltas
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
            this.components = new System.ComponentModel.Container();
            this.TbcFuncionario = new System.Windows.Forms.TabControl();
            this.TbpCliente1 = new System.Windows.Forms.TabPage();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCancelarAtualizacao = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMotivoFalta = new System.Windows.Forms.ComboBox();
            this.dtpFalta = new System.Windows.Forms.DateTimePicker();
            this.cmbConsultarFuncFalta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gridConsultarFalta = new System.Windows.Forms.DataGridView();
            this.cmbFuncFalta = new System.Windows.Forms.ComboBox();
            this.lblConsultarNomefunc = new System.Windows.Forms.Label();
            this.btnPesquisarFerias = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TbcFuncionario.SuspendLayout();
            this.TbpCliente1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultarFalta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbcFuncionario
            // 
            this.TbcFuncionario.Controls.Add(this.TbpCliente1);
            this.TbcFuncionario.Controls.Add(this.tabPage2);
            this.TbcFuncionario.Location = new System.Drawing.Point(12, 12);
            this.TbcFuncionario.Name = "TbcFuncionario";
            this.TbcFuncionario.SelectedIndex = 0;
            this.TbcFuncionario.Size = new System.Drawing.Size(825, 470);
            this.TbcFuncionario.TabIndex = 4;
            // 
            // TbpCliente1
            // 
            this.TbpCliente1.Controls.Add(this.btnVoltar);
            this.TbpCliente1.Controls.Add(this.btnCancelarAtualizacao);
            this.TbpCliente1.Controls.Add(this.btnSalvar);
            this.TbpCliente1.Controls.Add(this.panel1);
            this.TbpCliente1.Location = new System.Drawing.Point(4, 22);
            this.TbpCliente1.Name = "TbpCliente1";
            this.TbpCliente1.Padding = new System.Windows.Forms.Padding(3);
            this.TbpCliente1.Size = new System.Drawing.Size(817, 444);
            this.TbpCliente1.TabIndex = 0;
            this.TbpCliente1.Text = "Funcionário";
            this.TbpCliente1.UseVisualStyleBackColor = true;
            this.TbpCliente1.Click += new System.EventHandler(this.TbpCliente1_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(288, 293);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 31);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarAtualizacao
            // 
            this.btnCancelarAtualizacao.Location = new System.Drawing.Point(145, 293);
            this.btnCancelarAtualizacao.Name = "btnCancelarAtualizacao";
            this.btnCancelarAtualizacao.Size = new System.Drawing.Size(101, 31);
            this.btnCancelarAtualizacao.TabIndex = 4;
            this.btnCancelarAtualizacao.Text = "Cancelar";
            this.btnCancelarAtualizacao.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(13, 293);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 31);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbMotivoFalta);
            this.panel1.Controls.Add(this.dtpFalta);
            this.panel1.Controls.Add(this.cmbConsultarFuncFalta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 109);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Motivo";
            // 
            // cmbMotivoFalta
            // 
            this.cmbMotivoFalta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivoFalta.FormattingEnabled = true;
            this.cmbMotivoFalta.Items.AddRange(new object[] {
            "SAÚDE",
            "ATESTADO",
            "SEM JUSTIFICATIVA",
            "LIBERADO"});
            this.cmbMotivoFalta.Location = new System.Drawing.Point(557, 41);
            this.cmbMotivoFalta.Name = "cmbMotivoFalta";
            this.cmbMotivoFalta.Size = new System.Drawing.Size(132, 21);
            this.cmbMotivoFalta.TabIndex = 21;
            this.cmbMotivoFalta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtpFalta
            // 
            this.dtpFalta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFalta.Location = new System.Drawing.Point(396, 42);
            this.dtpFalta.Name = "dtpFalta";
            this.dtpFalta.Size = new System.Drawing.Size(108, 20);
            this.dtpFalta.TabIndex = 5;
            // 
            // cmbConsultarFuncFalta
            // 
            this.cmbConsultarFuncFalta.DisplayMember = "id_funcionario";
            this.cmbConsultarFuncFalta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultarFuncFalta.FormattingEnabled = true;
            this.cmbConsultarFuncFalta.Location = new System.Drawing.Point(13, 41);
            this.cmbConsultarFuncFalta.Name = "cmbConsultarFuncFalta";
            this.cmbConsultarFuncFalta.Size = new System.Drawing.Size(338, 21);
            this.cmbConsultarFuncFalta.TabIndex = 20;
            this.cmbConsultarFuncFalta.ValueMember = "id_funcionario";
            this.cmbConsultarFuncFalta.SelectedIndexChanged += new System.EventHandler(this.cmbConsultarFunc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data ";
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExcluir);
            this.tabPage2.Controls.Add(this.btnAlterar);
            this.tabPage2.Controls.Add(this.gridConsultarFalta);
            this.tabPage2.Controls.Add(this.cmbFuncFalta);
            this.tabPage2.Controls.Add(this.lblConsultarNomefunc);
            this.tabPage2.Controls.Add(this.btnPesquisarFerias);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(817, 444);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Consultar Funcionário";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(156, 355);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(29, 355);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 23;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // gridConsultarFalta
            // 
            this.gridConsultarFalta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridConsultarFalta.Location = new System.Drawing.Point(14, 115);
            this.gridConsultarFalta.Name = "gridConsultarFalta";
            this.gridConsultarFalta.Size = new System.Drawing.Size(701, 189);
            this.gridConsultarFalta.TabIndex = 22;
            this.gridConsultarFalta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConsultarFalta_CellContentClick);
            // 
            // cmbFuncFalta
            // 
            this.cmbFuncFalta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncFalta.FormattingEnabled = true;
            this.cmbFuncFalta.Location = new System.Drawing.Point(13, 63);
            this.cmbFuncFalta.Name = "cmbFuncFalta";
            this.cmbFuncFalta.Size = new System.Drawing.Size(397, 21);
            this.cmbFuncFalta.TabIndex = 21;
            // 
            // lblConsultarNomefunc
            // 
            this.lblConsultarNomefunc.AutoSize = true;
            this.lblConsultarNomefunc.Location = new System.Drawing.Point(11, 32);
            this.lblConsultarNomefunc.Name = "lblConsultarNomefunc";
            this.lblConsultarNomefunc.Size = new System.Drawing.Size(35, 13);
            this.lblConsultarNomefunc.TabIndex = 18;
            this.lblConsultarNomefunc.Text = "Nome";
            // 
            // btnPesquisarFerias
            // 
            this.btnPesquisarFerias.Location = new System.Drawing.Point(496, 59);
            this.btnPesquisarFerias.Name = "btnPesquisarFerias";
            this.btnPesquisarFerias.Size = new System.Drawing.Size(113, 25);
            this.btnPesquisarFerias.TabIndex = 13;
            this.btnPesquisarFerias.Text = "Pesquisar";
            this.btnPesquisarFerias.UseVisualStyleBackColor = true;
            this.btnPesquisarFerias.Click += new System.EventHandler(this.btnPesquisarFerias_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCadastroFaltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 499);
            this.Controls.Add(this.TbcFuncionario);
            this.Name = "frmCadastroFaltas";
            this.Text = "::: Cadastro de Faltas :::";
            this.Load += new System.EventHandler(this.frmCadastroFaltas_Load);
            this.TbcFuncionario.ResumeLayout(false);
            this.TbpCliente1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultarFalta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbcFuncionario;
        private System.Windows.Forms.TabPage TbpCliente1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCancelarAtualizacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbConsultarFuncFalta;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.DateTimePicker dtpFalta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView gridConsultarFalta;
        private System.Windows.Forms.ComboBox cmbFuncFalta;
        private System.Windows.Forms.Label lblConsultarNomefunc;
        private System.Windows.Forms.Button btnPesquisarFerias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMotivoFalta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}