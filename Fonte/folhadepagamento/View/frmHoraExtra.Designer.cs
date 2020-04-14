namespace folhadepagamento.View
{
    partial class frmHoraExtra
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
            this.TbcHoraExtra = new System.Windows.Forms.TabControl();
            this.TbpHoraExtra = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtQtdHoras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.LblNasc = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCancelarAtualizacao = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbConsultarFuncHora = new System.Windows.Forms.ComboBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbFuncHora = new System.Windows.Forms.ComboBox();
            this.btnPesquisarFunc = new System.Windows.Forms.Button();
            this.lblConsultarNomefunc = new System.Windows.Forms.Label();
            this.gridHoraExtra = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.TbcHoraExtra.SuspendLayout();
            this.TbpHoraExtra.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHoraExtra)).BeginInit();
            this.SuspendLayout();
            // 
            // TbcHoraExtra
            // 
            this.TbcHoraExtra.Controls.Add(this.TbpHoraExtra);
            this.TbcHoraExtra.Controls.Add(this.tabPage1);
            this.TbcHoraExtra.Location = new System.Drawing.Point(12, 12);
            this.TbcHoraExtra.Name = "TbcHoraExtra";
            this.TbcHoraExtra.SelectedIndex = 0;
            this.TbcHoraExtra.Size = new System.Drawing.Size(783, 442);
            this.TbcHoraExtra.TabIndex = 3;
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
            this.TbpHoraExtra.Size = new System.Drawing.Size(775, 416);
            this.TbpHoraExtra.TabIndex = 0;
            this.TbpHoraExtra.Text = "Hora Extra";
            this.TbpHoraExtra.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtQtdHoras);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpNascimento);
            this.panel2.Controls.Add(this.LblNasc);
            this.panel2.Location = new System.Drawing.Point(8, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 209);
            this.panel2.TabIndex = 4;
            // 
            // txtQtdHoras
            // 
            this.txtQtdHoras.Location = new System.Drawing.Point(13, 34);
            this.txtQtdHoras.Name = "txtQtdHoras";
            this.txtQtdHoras.Size = new System.Drawing.Size(37, 20);
            this.txtQtdHoras.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantidade de horas";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(170, 31);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(108, 20);
            this.dtpNascimento.TabIndex = 2;
            // 
            // LblNasc
            // 
            this.LblNasc.AutoSize = true;
            this.LblNasc.Location = new System.Drawing.Point(167, 14);
            this.LblNasc.Name = "LblNasc";
            this.LblNasc.Size = new System.Drawing.Size(30, 13);
            this.LblNasc.TabIndex = 2;
            this.LblNasc.Text = "Data";
            this.LblNasc.Click += new System.EventHandler(this.LblNasc_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(256, 350);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 30);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarAtualizacao
            // 
            this.btnCancelarAtualizacao.Location = new System.Drawing.Point(137, 350);
            this.btnCancelarAtualizacao.Name = "btnCancelarAtualizacao";
            this.btnCancelarAtualizacao.Size = new System.Drawing.Size(101, 29);
            this.btnCancelarAtualizacao.TabIndex = 4;
            this.btnCancelarAtualizacao.Text = "Cancelar";
            this.btnCancelarAtualizacao.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(8, 350);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 30);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbConsultarFuncHora);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 72);
            this.panel1.TabIndex = 0;
            // 
            // cmbConsultarFuncHora
            // 
            this.cmbConsultarFuncHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultarFuncHora.FormattingEnabled = true;
            this.cmbConsultarFuncHora.Location = new System.Drawing.Point(13, 29);
            this.cmbConsultarFuncHora.Name = "cmbConsultarFuncHora";
            this.cmbConsultarFuncHora.Size = new System.Drawing.Size(338, 21);
            this.cmbConsultarFuncHora.TabIndex = 21;
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
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnAlterar);
            this.tabPage1.Controls.Add(this.gridHoraExtra);
            this.tabPage1.Controls.Add(this.lblConsultarNomefunc);
            this.tabPage1.Controls.Add(this.cmbFuncHora);
            this.tabPage1.Controls.Add(this.btnPesquisarFunc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 416);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Consultar Horas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbFuncHora
            // 
            this.cmbFuncHora.FormattingEnabled = true;
            this.cmbFuncHora.Location = new System.Drawing.Point(22, 57);
            this.cmbFuncHora.Name = "cmbFuncHora";
            this.cmbFuncHora.Size = new System.Drawing.Size(328, 21);
            this.cmbFuncHora.TabIndex = 24;
            // 
            // btnPesquisarFunc
            // 
            this.btnPesquisarFunc.Location = new System.Drawing.Point(392, 53);
            this.btnPesquisarFunc.Name = "btnPesquisarFunc";
            this.btnPesquisarFunc.Size = new System.Drawing.Size(110, 26);
            this.btnPesquisarFunc.TabIndex = 23;
            this.btnPesquisarFunc.Text = "Pesquisar";
            this.btnPesquisarFunc.UseVisualStyleBackColor = true;
            this.btnPesquisarFunc.Click += new System.EventHandler(this.btnPesquisarFunc_Click);
            // 
            // lblConsultarNomefunc
            // 
            this.lblConsultarNomefunc.AutoSize = true;
            this.lblConsultarNomefunc.Location = new System.Drawing.Point(19, 41);
            this.lblConsultarNomefunc.Name = "lblConsultarNomefunc";
            this.lblConsultarNomefunc.Size = new System.Drawing.Size(65, 13);
            this.lblConsultarNomefunc.TabIndex = 25;
            this.lblConsultarNomefunc.Text = "Funcionário:";
            // 
            // gridHoraExtra
            // 
            this.gridHoraExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHoraExtra.Location = new System.Drawing.Point(22, 110);
            this.gridHoraExtra.Name = "gridHoraExtra";
            this.gridHoraExtra.Size = new System.Drawing.Size(634, 182);
            this.gridHoraExtra.TabIndex = 26;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(164, 343);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 26);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(22, 343);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 26);
            this.btnAlterar.TabIndex = 27;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // frmHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 466);
            this.Controls.Add(this.TbcHoraExtra);
            this.Name = "frmHoraExtra";
            this.Text = "::: Hora Extra :::";
            this.Load += new System.EventHandler(this.frmHoraExtra_Load);
            this.TbcHoraExtra.ResumeLayout(false);
            this.TbpHoraExtra.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHoraExtra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbcHoraExtra;
        private System.Windows.Forms.TabPage TbpHoraExtra;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCancelarAtualizacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label LblNasc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtdHoras;
        private System.Windows.Forms.ComboBox cmbConsultarFuncHora;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbFuncHora;
        private System.Windows.Forms.Button btnPesquisarFunc;
        private System.Windows.Forms.Label lblConsultarNomefunc;
        private System.Windows.Forms.DataGridView gridHoraExtra;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
    }
}