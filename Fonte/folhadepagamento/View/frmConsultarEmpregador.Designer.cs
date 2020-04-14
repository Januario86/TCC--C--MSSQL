namespace folhadepagamento.View
{
    partial class frmConsultarEmpregador
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridEmpregador = new System.Windows.Forms.DataGridView();
            this.btnConsultarEmpregador = new System.Windows.Forms.Button();
            this.cmbEmpregadorConsultar = new System.Windows.Forms.ComboBox();
            this.lblConsultarNomefunc = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.folhaDataSet = new folhadepagamento.folhaDataSet();
            this.TbcFuncionario = new System.Windows.Forms.TabControl();
            this.fkcontratoidfuncBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fkcontratoidfuncBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empregadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empregadorTableAdapter = new folhadepagamento.folhaDataSetTableAdapters.EmpregadorTableAdapter();
            this.empregadorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new folhadepagamento.folhaDataSetTableAdapters.FuncionarioTableAdapter();
            this.contrato_trabalhoTableAdapter = new folhadepagamento.folhaDataSetTableAdapters.Contrato_trabalhoTableAdapter();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpregador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folhaDataSet)).BeginInit();
            this.TbcFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fkcontratoidfuncBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkcontratoidfuncBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empregadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empregadorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.gridEmpregador);
            this.tabPage2.Controls.Add(this.btnConsultarEmpregador);
            this.tabPage2.Controls.Add(this.cmbEmpregadorConsultar);
            this.tabPage2.Controls.Add(this.lblConsultarNomefunc);
            this.tabPage2.Controls.Add(this.btnExcluir);
            this.tabPage2.Controls.Add(this.btnAlterar);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 467);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Consultar Funcionário";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // gridEmpregador
            // 
            this.gridEmpregador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpregador.Location = new System.Drawing.Point(14, 131);
            this.gridEmpregador.Name = "gridEmpregador";
            this.gridEmpregador.Size = new System.Drawing.Size(704, 211);
            this.gridEmpregador.TabIndex = 22;
            this.gridEmpregador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnConsultarEmpregador
            // 
            this.btnConsultarEmpregador.Location = new System.Drawing.Point(450, 71);
            this.btnConsultarEmpregador.Name = "btnConsultarEmpregador";
            this.btnConsultarEmpregador.Size = new System.Drawing.Size(110, 26);
            this.btnConsultarEmpregador.TabIndex = 21;
            this.btnConsultarEmpregador.Text = "Pesquisar";
            this.btnConsultarEmpregador.UseVisualStyleBackColor = true;
            this.btnConsultarEmpregador.Click += new System.EventHandler(this.btnConsultarEmpregador_Click);
            // 
            // cmbEmpregadorConsultar
            // 
            this.cmbEmpregadorConsultar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpregadorConsultar.FormattingEnabled = true;
            this.cmbEmpregadorConsultar.Location = new System.Drawing.Point(14, 75);
            this.cmbEmpregadorConsultar.Name = "cmbEmpregadorConsultar";
            this.cmbEmpregadorConsultar.Size = new System.Drawing.Size(338, 21);
            this.cmbEmpregadorConsultar.TabIndex = 19;
            this.cmbEmpregadorConsultar.SelectedIndexChanged += new System.EventHandler(this.cmbEmpregadorConsultar_SelectedIndexChanged);
            // 
            // lblConsultarNomefunc
            // 
            this.lblConsultarNomefunc.AutoSize = true;
            this.lblConsultarNomefunc.Location = new System.Drawing.Point(11, 59);
            this.lblConsultarNomefunc.Name = "lblConsultarNomefunc";
            this.lblConsultarNomefunc.Size = new System.Drawing.Size(35, 13);
            this.lblConsultarNomefunc.TabIndex = 18;
            this.lblConsultarNomefunc.Text = "Nome";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(155, 375);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 26);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(13, 375);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 26);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 12;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.folhaDataSet;
            // 
            // folhaDataSet
            // 
            this.folhaDataSet.DataSetName = "folhaDataSet";
            this.folhaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TbcFuncionario
            // 
            this.TbcFuncionario.Controls.Add(this.tabPage2);
            this.TbcFuncionario.Location = new System.Drawing.Point(21, 12);
            this.TbcFuncionario.Name = "TbcFuncionario";
            this.TbcFuncionario.SelectedIndex = 0;
            this.TbcFuncionario.Size = new System.Drawing.Size(775, 493);
            this.TbcFuncionario.TabIndex = 3;
            // 
            // fkcontratoidfuncBindingSource
            // 
            this.fkcontratoidfuncBindingSource.DataMember = "fk_contrato_id_func";
            this.fkcontratoidfuncBindingSource.DataSource = this.funcionarioBindingSource;
            // 
            // fkcontratoidfuncBindingSource1
            // 
            this.fkcontratoidfuncBindingSource1.DataMember = "fk_contrato_id_func";
            this.fkcontratoidfuncBindingSource1.DataSource = this.funcionarioBindingSource;
            // 
            // empregadorBindingSource
            // 
            this.empregadorBindingSource.DataMember = "Empregador";
            this.empregadorBindingSource.DataSource = this.folhaDataSet;
            // 
            // empregadorTableAdapter
            // 
            this.empregadorTableAdapter.ClearBeforeFill = true;
            // 
            // empregadorBindingSource1
            // 
            this.empregadorBindingSource1.DataMember = "Empregador";
            this.empregadorBindingSource1.DataSource = this.folhaDataSet;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // contrato_trabalhoTableAdapter
            // 
            this.contrato_trabalhoTableAdapter.ClearBeforeFill = true;
            // 
            // frmConsultarEmpregador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 525);
            this.Controls.Add(this.TbcFuncionario);
            this.Name = "frmConsultarEmpregador";
            this.Text = "::: ConsultarEmpregador :::";
            this.Load += new System.EventHandler(this.ConsultarEmpregador_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpregador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folhaDataSet)).EndInit();
            this.TbcFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fkcontratoidfuncBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fkcontratoidfuncBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empregadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empregadorBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnConsultarEmpregador;
        private System.Windows.Forms.ComboBox cmbEmpregadorConsultar;
        private System.Windows.Forms.Label lblConsultarNomefunc;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl TbcFuncionario;
        private folhaDataSet folhaDataSet;
        private System.Windows.Forms.BindingSource empregadorBindingSource;
        private folhaDataSetTableAdapters.EmpregadorTableAdapter empregadorTableAdapter;
        private System.Windows.Forms.BindingSource empregadorBindingSource1;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private folhaDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.BindingSource fkcontratoidfuncBindingSource;
        private folhaDataSetTableAdapters.Contrato_trabalhoTableAdapter contrato_trabalhoTableAdapter;
        private System.Windows.Forms.BindingSource fkcontratoidfuncBindingSource1;
        private System.Windows.Forms.DataGridView gridEmpregador;
    }
}