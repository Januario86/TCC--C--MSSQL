namespace folhadepagamento.View
{
    partial class frmCadastroEmpregador
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
            this.TbcFuncionário = new System.Windows.Forms.TabControl();
            this.TbpCliente1 = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.LblCPFCNPJ = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCel = new System.Windows.Forms.MaskedTextBox();
            this.txtNumeroEmp = new System.Windows.Forms.TextBox();
            this.lblNumeroEmp = new System.Windows.Forms.Label();
            this.cmbUFEmp = new System.Windows.Forms.ComboBox();
            this.LblEndereco = new System.Windows.Forms.Label();
            this.LblCEP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.LblUF = new System.Windows.Forms.Label();
            this.LblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.LblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.gridEmpregador = new System.Windows.Forms.DataGridView();
            this.btnConsultarEmpregador = new System.Windows.Forms.Button();
            this.cmbEmpregadorConsultar = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TbcFuncionário.SuspendLayout();
            this.TbpCliente1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpregador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbcFuncionário
            // 
            this.TbcFuncionário.Controls.Add(this.TbpCliente1);
            this.TbcFuncionário.Controls.Add(this.tabPage1);
            this.TbcFuncionário.Location = new System.Drawing.Point(22, 8);
            this.TbcFuncionário.Name = "TbcFuncionário";
            this.TbcFuncionário.SelectedIndex = 0;
            this.TbcFuncionário.Size = new System.Drawing.Size(775, 486);
            this.TbcFuncionário.TabIndex = 1;
            // 
            // TbpCliente1
            // 
            this.TbpCliente1.Controls.Add(this.btnLimpar);
            this.TbpCliente1.Controls.Add(this.btnSalvar);
            this.TbpCliente1.Controls.Add(this.panel1);
            this.TbpCliente1.Controls.Add(this.panel2);
            this.TbpCliente1.Location = new System.Drawing.Point(4, 22);
            this.TbpCliente1.Name = "TbpCliente1";
            this.TbpCliente1.Padding = new System.Windows.Forms.Padding(3);
            this.TbpCliente1.Size = new System.Drawing.Size(767, 460);
            this.TbpCliente1.TabIndex = 0;
            this.TbpCliente1.Text = "Empregador";
            this.TbpCliente1.UseVisualStyleBackColor = true;
            this.TbpCliente1.Click += new System.EventHandler(this.TbpCliente1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(200, 420);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 34);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(14, 420);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 34);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCPFCNPJ);
            this.panel1.Controls.Add(this.LblCPFCNPJ);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Location = new System.Drawing.Point(5, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 72);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtCPFCNPJ
            // 
            this.txtCPFCNPJ.Location = new System.Drawing.Point(371, 28);
            this.txtCPFCNPJ.Mask = "000000000-00";
            this.txtCPFCNPJ.Name = "txtCPFCNPJ";
            this.txtCPFCNPJ.Size = new System.Drawing.Size(160, 20);
            this.txtCPFCNPJ.TabIndex = 29;
            // 
            // LblCPFCNPJ
            // 
            this.LblCPFCNPJ.AutoSize = true;
            this.LblCPFCNPJ.Location = new System.Drawing.Point(368, 13);
            this.LblCPFCNPJ.Name = "LblCPFCNPJ";
            this.LblCPFCNPJ.Size = new System.Drawing.Size(59, 13);
            this.LblCPFCNPJ.TabIndex = 3;
            this.LblCPFCNPJ.Text = "CPF/CNPJ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(301, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(10, 13);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(64, 13);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Empregador";
            this.LblNome.Click += new System.EventHandler(this.LblNome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCep);
            this.panel2.Controls.Add(this.txtTelefone);
            this.panel2.Controls.Add(this.txtCel);
            this.panel2.Controls.Add(this.txtNumeroEmp);
            this.panel2.Controls.Add(this.lblNumeroEmp);
            this.panel2.Controls.Add(this.cmbUFEmp);
            this.panel2.Controls.Add(this.LblEndereco);
            this.panel2.Controls.Add(this.LblCEP);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.LblEmail);
            this.panel2.Controls.Add(this.txtEndereco);
            this.panel2.Controls.Add(this.LblUF);
            this.panel2.Controls.Add(this.LblCidade);
            this.panel2.Controls.Add(this.txtCidade);
            this.panel2.Controls.Add(this.LblBairro);
            this.panel2.Controls.Add(this.txtBairro);
            this.panel2.Location = new System.Drawing.Point(6, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 165);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(628, 78);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(70, 20);
            this.txtCep.TabIndex = 30;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(12, 30);
            this.txtTelefone.Mask = "(099) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 28;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(152, 31);
            this.txtCel.Mask = "(099) 0000-0000";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(100, 20);
            this.txtCel.TabIndex = 4;
            // 
            // txtNumeroEmp
            // 
            this.txtNumeroEmp.Location = new System.Drawing.Point(254, 125);
            this.txtNumeroEmp.Name = "txtNumeroEmp";
            this.txtNumeroEmp.Size = new System.Drawing.Size(41, 20);
            this.txtNumeroEmp.TabIndex = 27;
            // 
            // lblNumeroEmp
            // 
            this.lblNumeroEmp.AutoSize = true;
            this.lblNumeroEmp.Location = new System.Drawing.Point(251, 108);
            this.lblNumeroEmp.Name = "lblNumeroEmp";
            this.lblNumeroEmp.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroEmp.TabIndex = 26;
            this.lblNumeroEmp.Text = "Número";
            this.lblNumeroEmp.UseMnemonic = false;
            // 
            // cmbUFEmp
            // 
            this.cmbUFEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUFEmp.FormattingEnabled = true;
            this.cmbUFEmp.Location = new System.Drawing.Point(152, 125);
            this.cmbUFEmp.Name = "cmbUFEmp";
            this.cmbUFEmp.Size = new System.Drawing.Size(59, 21);
            this.cmbUFEmp.TabIndex = 25;
            this.cmbUFEmp.SelectedIndexChanged += new System.EventHandler(this.cmbUFEmp_SelectedIndexChanged);
            // 
            // LblEndereco
            // 
            this.LblEndereco.AutoSize = true;
            this.LblEndereco.Location = new System.Drawing.Point(8, 61);
            this.LblEndereco.Name = "LblEndereco";
            this.LblEndereco.Size = new System.Drawing.Size(53, 13);
            this.LblEndereco.TabIndex = 16;
            this.LblEndereco.Text = "Endereço";
            // 
            // LblCEP
            // 
            this.LblCEP.AutoSize = true;
            this.LblCEP.Location = new System.Drawing.Point(625, 61);
            this.LblCEP.Name = "LblCEP";
            this.LblCEP.Size = new System.Drawing.Size(28, 13);
            this.LblCEP.TabIndex = 24;
            this.LblCEP.Text = "CEP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(314, 31);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(432, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Celular";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(311, 14);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(36, 13);
            this.LblEmail.TabIndex = 14;
            this.LblEmail.Text = "E-Mail";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(8, 78);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(437, 20);
            this.txtEndereco.TabIndex = 3;
            // 
            // LblUF
            // 
            this.LblUF.AutoSize = true;
            this.LblUF.Location = new System.Drawing.Point(149, 108);
            this.LblUF.Name = "LblUF";
            this.LblUF.Size = new System.Drawing.Size(21, 13);
            this.LblUF.TabIndex = 22;
            this.LblUF.Text = "UF";
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.Location = new System.Drawing.Point(8, 108);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(40, 13);
            this.LblCidade.TabIndex = 20;
            this.LblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(8, 125);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(134, 20);
            this.txtCidade.TabIndex = 6;
            // 
            // LblBairro
            // 
            this.LblBairro.AutoSize = true;
            this.LblBairro.Location = new System.Drawing.Point(468, 61);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.Size = new System.Drawing.Size(34, 13);
            this.LblBairro.TabIndex = 18;
            this.LblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(464, 78);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(126, 20);
            this.txtBairro.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.gridEmpregador);
            this.tabPage1.Controls.Add(this.btnConsultarEmpregador);
            this.tabPage1.Controls.Add(this.cmbEmpregadorConsultar);
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnAlterar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 460);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Consultar Empregador";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Empregador :";
            // 
            // gridEmpregador
            // 
            this.gridEmpregador.AllowUserToAddRows = false;
            this.gridEmpregador.AllowUserToDeleteRows = false;
            this.gridEmpregador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpregador.Location = new System.Drawing.Point(32, 125);
            this.gridEmpregador.Name = "gridEmpregador";
            this.gridEmpregador.Size = new System.Drawing.Size(704, 211);
            this.gridEmpregador.TabIndex = 27;
            // 
            // btnConsultarEmpregador
            // 
            this.btnConsultarEmpregador.Location = new System.Drawing.Point(468, 65);
            this.btnConsultarEmpregador.Name = "btnConsultarEmpregador";
            this.btnConsultarEmpregador.Size = new System.Drawing.Size(110, 26);
            this.btnConsultarEmpregador.TabIndex = 26;
            this.btnConsultarEmpregador.Text = "Pesquisar";
            this.btnConsultarEmpregador.UseVisualStyleBackColor = true;
            this.btnConsultarEmpregador.Click += new System.EventHandler(this.btnConsultarEmpregador_Click);
            // 
            // cmbEmpregadorConsultar
            // 
            this.cmbEmpregadorConsultar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpregadorConsultar.FormattingEnabled = true;
            this.cmbEmpregadorConsultar.Location = new System.Drawing.Point(32, 69);
            this.cmbEmpregadorConsultar.Name = "cmbEmpregadorConsultar";
            this.cmbEmpregadorConsultar.Size = new System.Drawing.Size(338, 21);
            this.cmbEmpregadorConsultar.TabIndex = 25;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(173, 369);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 26);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(31, 369);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 26);
            this.btnAlterar.TabIndex = 23;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CLI_CEP";
            this.dataGridViewTextBoxColumn11.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CLI_BAIRRO";
            this.dataGridViewTextBoxColumn10.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CLI_CIDADE";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CLI_UF";
            this.dataGridViewTextBoxColumn8.HeaderText = "UF";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CLI_ENDERECO";
            this.dataGridViewTextBoxColumn7.HeaderText = "Endereco";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CLI_REFERENCIA";
            this.dataGridViewTextBoxColumn6.HeaderText = "Referencia";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CLI_CPFCNPJ";
            this.dataGridViewTextBoxColumn5.HeaderText = "CPFCNPJ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CLI_EMAIL";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CLI_CELULAR";
            this.dataGridViewTextBoxColumn3.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CLI_TELEFONE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CLI_NOME";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCadastroEmpregador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 519);
            this.Controls.Add(this.TbcFuncionário);
            this.Name = "frmCadastroEmpregador";
            this.Text = " Empregador";
            this.Load += new System.EventHandler(this.DadosCadastrais_Load);
            this.TbcFuncionário.ResumeLayout(false);
            this.TbpCliente1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpregador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbcFuncionário;
        private System.Windows.Forms.TabPage TbpCliente1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblCPFCNPJ;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblEndereco;
        private System.Windows.Forms.Label LblCEP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label LblUF;
        private System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label LblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbUFEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtNumeroEmp;
        private System.Windows.Forms.Label lblNumeroEmp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridEmpregador;
        private System.Windows.Forms.Button btnConsultarEmpregador;
        private System.Windows.Forms.ComboBox cmbEmpregadorConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCel;
        private System.Windows.Forms.MaskedTextBox txtCPFCNPJ;
        private System.Windows.Forms.MaskedTextBox txtCep;
    }
}