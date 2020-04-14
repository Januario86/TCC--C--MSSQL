namespace folhadepagamento.View
{
    partial class frmCadastroFérias
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
            this.cmbConsultarFunc = new System.Windows.Forms.ComboBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpRetornoFerias = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txQtdDias = new System.Windows.Forms.TextBox();
            this.LblNasc = new System.Windows.Forms.Label();
            this.dtpInicioFerias = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gridConsultarFerias = new System.Windows.Forms.DataGridView();
            this.cmbFuncFerias = new System.Windows.Forms.ComboBox();
            this.lblConsultarNomefunc = new System.Windows.Forms.Label();
            this.btnPesquisarFerias = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TbcFuncionario.SuspendLayout();
            this.TbpCliente1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultarFerias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbcFuncionario
            // 
            this.TbcFuncionario.Controls.Add(this.TbpCliente1);
            this.TbcFuncionario.Controls.Add(this.tabPage2);
            this.TbcFuncionario.Location = new System.Drawing.Point(30, 12);
            this.TbcFuncionario.Name = "TbcFuncionario";
            this.TbcFuncionario.SelectedIndex = 0;
            this.TbcFuncionario.Size = new System.Drawing.Size(764, 470);
            this.TbcFuncionario.TabIndex = 3;
            // 
            // TbpCliente1
            // 
            this.TbpCliente1.Controls.Add(this.btnVoltar);
            this.TbpCliente1.Controls.Add(this.btnCancelarAtualizacao);
            this.TbpCliente1.Controls.Add(this.btnSalvar);
            this.TbpCliente1.Controls.Add(this.panel1);
            this.TbpCliente1.Controls.Add(this.panel2);
            this.TbpCliente1.Location = new System.Drawing.Point(4, 22);
            this.TbpCliente1.Name = "TbpCliente1";
            this.TbpCliente1.Padding = new System.Windows.Forms.Padding(3);
            this.TbpCliente1.Size = new System.Drawing.Size(756, 444);
            this.TbpCliente1.TabIndex = 0;
            this.TbpCliente1.Text = "Funcionário";
            this.TbpCliente1.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(283, 387);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 31);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarAtualizacao
            // 
            this.btnCancelarAtualizacao.Location = new System.Drawing.Point(152, 387);
            this.btnCancelarAtualizacao.Name = "btnCancelarAtualizacao";
            this.btnCancelarAtualizacao.Size = new System.Drawing.Size(101, 31);
            this.btnCancelarAtualizacao.TabIndex = 4;
            this.btnCancelarAtualizacao.Text = "Cancelar";
            this.btnCancelarAtualizacao.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(27, 387);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 31);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbConsultarFunc);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 109);
            this.panel1.TabIndex = 0;
            // 
            // cmbConsultarFunc
            // 
            this.cmbConsultarFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultarFunc.FormattingEnabled = true;
            this.cmbConsultarFunc.Location = new System.Drawing.Point(13, 41);
            this.cmbConsultarFunc.Name = "cmbConsultarFunc";
            this.cmbConsultarFunc.Size = new System.Drawing.Size(338, 21);
            this.cmbConsultarFunc.TabIndex = 20;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpRetornoFerias);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txQtdDias);
            this.panel2.Controls.Add(this.LblNasc);
            this.panel2.Controls.Add(this.dtpInicioFerias);
            this.panel2.Location = new System.Drawing.Point(0, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 108);
            this.panel2.TabIndex = 1;
            // 
            // dtpRetornoFerias
            // 
            this.dtpRetornoFerias.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRetornoFerias.Location = new System.Drawing.Point(224, 31);
            this.dtpRetornoFerias.Name = "dtpRetornoFerias";
            this.dtpRetornoFerias.Size = new System.Drawing.Size(108, 20);
            this.dtpRetornoFerias.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data de Retorno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qtd dias";
            // 
            // txQtdDias
            // 
            this.txQtdDias.Location = new System.Drawing.Point(8, 31);
            this.txQtdDias.Name = "txQtdDias";
            this.txQtdDias.Size = new System.Drawing.Size(46, 20);
            this.txQtdDias.TabIndex = 0;
            // 
            // LblNasc
            // 
            this.LblNasc.AutoSize = true;
            this.LblNasc.Location = new System.Drawing.Point(97, 12);
            this.LblNasc.Name = "LblNasc";
            this.LblNasc.Size = new System.Drawing.Size(32, 13);
            this.LblNasc.TabIndex = 2;
            this.LblNasc.Text = "Inicio";
            // 
            // dtpInicioFerias
            // 
            this.dtpInicioFerias.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioFerias.Location = new System.Drawing.Point(100, 31);
            this.dtpInicioFerias.Name = "dtpInicioFerias";
            this.dtpInicioFerias.Size = new System.Drawing.Size(108, 20);
            this.dtpInicioFerias.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExcluir);
            this.tabPage2.Controls.Add(this.btnAlterar);
            this.tabPage2.Controls.Add(this.gridConsultarFerias);
            this.tabPage2.Controls.Add(this.cmbFuncFerias);
            this.tabPage2.Controls.Add(this.lblConsultarNomefunc);
            this.tabPage2.Controls.Add(this.btnPesquisarFerias);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 444);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Consultar Funcionário";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(156, 355);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(29, 355);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 23;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // gridConsultarFerias
            // 
            this.gridConsultarFerias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridConsultarFerias.Location = new System.Drawing.Point(14, 115);
            this.gridConsultarFerias.Name = "gridConsultarFerias";
            this.gridConsultarFerias.Size = new System.Drawing.Size(701, 189);
            this.gridConsultarFerias.TabIndex = 22;
            // 
            // cmbFuncFerias
            // 
            this.cmbFuncFerias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncFerias.FormattingEnabled = true;
            this.cmbFuncFerias.Location = new System.Drawing.Point(13, 63);
            this.cmbFuncFerias.Name = "cmbFuncFerias";
            this.cmbFuncFerias.Size = new System.Drawing.Size(397, 21);
            this.cmbFuncFerias.TabIndex = 21;
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
            // frmCadastroFérias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 479);
            this.Controls.Add(this.TbcFuncionario);
            this.Name = "frmCadastroFérias";
            this.Text = "::: Cadastro de Férias :::";
            this.Load += new System.EventHandler(this.frmCadastroFérias_Load);
            this.TbcFuncionario.ResumeLayout(false);
            this.TbpCliente1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultarFerias)).EndInit();
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
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.DateTimePicker dtpInicioFerias;
        private System.Windows.Forms.Label LblNasc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txQtdDias;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblConsultarNomefunc;
        private System.Windows.Forms.Button btnPesquisarFerias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpRetornoFerias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbConsultarFunc;
        private System.Windows.Forms.ComboBox cmbFuncFerias;
        private System.Windows.Forms.DataGridView gridConsultarFerias;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}