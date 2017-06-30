namespace SetorRH.Visao
{
    partial class frmFuncionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbFuncionarios = new System.Windows.Forms.GroupBox();
            this.pnlAdmissao = new System.Windows.Forms.Panel();
            this.maskedDemissao = new System.Windows.Forms.MaskedTextBox();
            this.rbtAdmissao = new System.Windows.Forms.RadioButton();
            this.maskedAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.lblData1 = new System.Windows.Forms.Label();
            this.rbtDemissao = new System.Windows.Forms.RadioButton();
            this.lblData2 = new System.Windows.Forms.Label();
            this.lblSenha2 = new System.Windows.Forms.Label();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.pnlSexo = new System.Windows.Forms.Panel();
            this.rdbSexo = new System.Windows.Forms.RadioButton();
            this.rdbSexo2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSetor = new System.Windows.Forms.ComboBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbRecuperaFuncionarios = new System.Windows.Forms.GroupBox();
            this.errMsgErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.sfdExportaClientes = new System.Windows.Forms.SaveFileDialog();
            this.ofdImportaClientes = new System.Windows.Forms.OpenFileDialog();
            this.gpbFuncionarios.SuspendLayout();
            this.pnlAdmissao.SuspendLayout();
            this.pnlSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.gpbRecuperaFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMsgErro)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbFuncionarios
            // 
            this.gpbFuncionarios.Controls.Add(this.pnlAdmissao);
            this.gpbFuncionarios.Controls.Add(this.lblSenha2);
            this.gpbFuncionarios.Controls.Add(this.txtSenha2);
            this.gpbFuncionarios.Controls.Add(this.lblSenha);
            this.gpbFuncionarios.Controls.Add(this.txtSenha);
            this.gpbFuncionarios.Controls.Add(this.txtSexo);
            this.gpbFuncionarios.Controls.Add(this.pnlSexo);
            this.gpbFuncionarios.Controls.Add(this.cmbSetor);
            this.gpbFuncionarios.Controls.Add(this.cmbCargo);
            this.gpbFuncionarios.Controls.Add(this.label9);
            this.gpbFuncionarios.Controls.Add(this.txtRG);
            this.gpbFuncionarios.Controls.Add(this.label6);
            this.gpbFuncionarios.Controls.Add(this.label8);
            this.gpbFuncionarios.Controls.Add(this.label13);
            this.gpbFuncionarios.Controls.Add(this.txtCodigo);
            this.gpbFuncionarios.Controls.Add(this.txtEndereco);
            this.gpbFuncionarios.Controls.Add(this.label7);
            this.gpbFuncionarios.Controls.Add(this.label5);
            this.gpbFuncionarios.Controls.Add(this.txtNome);
            this.gpbFuncionarios.Location = new System.Drawing.Point(16, 22);
            this.gpbFuncionarios.Name = "gpbFuncionarios";
            this.gpbFuncionarios.Size = new System.Drawing.Size(940, 244);
            this.gpbFuncionarios.TabIndex = 0;
            this.gpbFuncionarios.TabStop = false;
            this.gpbFuncionarios.Text = "Dados do Funcionário";
            // 
            // pnlAdmissao
            // 
            this.pnlAdmissao.Controls.Add(this.maskedDemissao);
            this.pnlAdmissao.Controls.Add(this.rbtAdmissao);
            this.pnlAdmissao.Controls.Add(this.maskedAdmissao);
            this.pnlAdmissao.Controls.Add(this.lblData1);
            this.pnlAdmissao.Controls.Add(this.rbtDemissao);
            this.pnlAdmissao.Controls.Add(this.lblData2);
            this.pnlAdmissao.Location = new System.Drawing.Point(663, 19);
            this.pnlAdmissao.Name = "pnlAdmissao";
            this.pnlAdmissao.Size = new System.Drawing.Size(201, 201);
            this.pnlAdmissao.TabIndex = 24;
            // 
            // maskedDemissao
            // 
            this.maskedDemissao.Location = new System.Drawing.Point(32, 148);
            this.maskedDemissao.Mask = "00/00/0000";
            this.maskedDemissao.Name = "maskedDemissao";
            this.maskedDemissao.Size = new System.Drawing.Size(100, 20);
            this.maskedDemissao.TabIndex = 14;
            this.maskedDemissao.Tag = "n";
            this.maskedDemissao.ValidatingType = typeof(System.DateTime);
            this.maskedDemissao.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.maskedTextBox2_TypeValidationCompleted);
            // 
            // rbtAdmissao
            // 
            this.rbtAdmissao.AutoSize = true;
            this.rbtAdmissao.Location = new System.Drawing.Point(32, 24);
            this.rbtAdmissao.Name = "rbtAdmissao";
            this.rbtAdmissao.Size = new System.Drawing.Size(109, 17);
            this.rbtAdmissao.TabIndex = 11;
            this.rbtAdmissao.TabStop = true;
            this.rbtAdmissao.Tag = "n";
            this.rbtAdmissao.Text = "Apenas Admissão";
            this.rbtAdmissao.UseVisualStyleBackColor = true;
            this.rbtAdmissao.CheckedChanged += new System.EventHandler(this.rbtAdmissao_CheckedChanged);
            // 
            // maskedAdmissao
            // 
            this.maskedAdmissao.Location = new System.Drawing.Point(32, 62);
            this.maskedAdmissao.Mask = "00/00/0000";
            this.maskedAdmissao.Name = "maskedAdmissao";
            this.maskedAdmissao.Size = new System.Drawing.Size(100, 20);
            this.maskedAdmissao.TabIndex = 12;
            this.maskedAdmissao.Tag = "n";
            this.maskedAdmissao.ValidatingType = typeof(System.DateTime);
            this.maskedAdmissao.Visible = false;
            this.maskedAdmissao.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.maskedTextBox1_TypeValidationCompleted);
            // 
            // lblData1
            // 
            this.lblData1.AutoSize = true;
            this.lblData1.Location = new System.Drawing.Point(32, 46);
            this.lblData1.Name = "lblData1";
            this.lblData1.Size = new System.Drawing.Size(34, 13);
            this.lblData1.TabIndex = 12;
            this.lblData1.Text = "Data*";
            this.lblData1.Visible = false;
            // 
            // rbtDemissao
            // 
            this.rbtDemissao.AutoSize = true;
            this.rbtDemissao.Location = new System.Drawing.Point(32, 111);
            this.rbtDemissao.Name = "rbtDemissao";
            this.rbtDemissao.Size = new System.Drawing.Size(95, 17);
            this.rbtDemissao.TabIndex = 13;
            this.rbtDemissao.TabStop = true;
            this.rbtDemissao.Tag = "n";
            this.rbtDemissao.Text = "Com Demissão";
            this.rbtDemissao.UseVisualStyleBackColor = true;
            this.rbtDemissao.CheckedChanged += new System.EventHandler(this.rbtDemissao_CheckedChanged);
            // 
            // lblData2
            // 
            this.lblData2.AutoSize = true;
            this.lblData2.Location = new System.Drawing.Point(32, 132);
            this.lblData2.Name = "lblData2";
            this.lblData2.Size = new System.Drawing.Size(34, 13);
            this.lblData2.TabIndex = 14;
            this.lblData2.Text = "Data*";
            this.lblData2.Visible = false;
            // 
            // lblSenha2
            // 
            this.lblSenha2.AutoSize = true;
            this.lblSenha2.Location = new System.Drawing.Point(130, 202);
            this.lblSenha2.Name = "lblSenha2";
            this.lblSenha2.Size = new System.Drawing.Size(91, 13);
            this.lblSenha2.TabIndex = 28;
            this.lblSenha2.Text = "Confirme a Senha";
            this.lblSenha2.Visible = false;
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(133, 218);
            this.txtSenha2.MaxLength = 10;
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.PasswordChar = '*';
            this.txtSenha2.Size = new System.Drawing.Size(91, 20);
            this.txtSenha2.TabIndex = 8;
            this.txtSenha2.Tag = "n";
            this.txtSenha2.Visible = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(19, 202);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 26;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Visible = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(19, 218);
            this.txtSenha.MaxLength = 10;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(91, 20);
            this.txtSenha.TabIndex = 7;
            this.txtSenha.Tag = "n";
            this.txtSenha.Visible = false;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(510, 157);
            this.txtSexo.MaxLength = 12;
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(45, 20);
            this.txtSexo.TabIndex = 24;
            this.txtSexo.Tag = "Sexo";
            this.txtSexo.Visible = false;
            // 
            // pnlSexo
            // 
            this.pnlSexo.Controls.Add(this.rdbSexo);
            this.pnlSexo.Controls.Add(this.rdbSexo2);
            this.pnlSexo.Controls.Add(this.label4);
            this.pnlSexo.Location = new System.Drawing.Point(419, 124);
            this.pnlSexo.Name = "pnlSexo";
            this.pnlSexo.Size = new System.Drawing.Size(91, 90);
            this.pnlSexo.TabIndex = 23;
            // 
            // rdbSexo
            // 
            this.rdbSexo.AutoSize = true;
            this.rdbSexo.Location = new System.Drawing.Point(12, 32);
            this.rdbSexo.Name = "rdbSexo";
            this.rdbSexo.Size = new System.Drawing.Size(73, 17);
            this.rdbSexo.TabIndex = 9;
            this.rdbSexo.TabStop = true;
            this.rdbSexo.Tag = "n";
            this.rdbSexo.Text = "Masculino";
            this.rdbSexo.UseVisualStyleBackColor = true;
            this.rdbSexo.CheckedChanged += new System.EventHandler(this.rdbSexo_CheckedChanged);
            // 
            // rdbSexo2
            // 
            this.rdbSexo2.AutoSize = true;
            this.rdbSexo2.Location = new System.Drawing.Point(12, 55);
            this.rdbSexo2.Name = "rdbSexo2";
            this.rdbSexo2.Size = new System.Drawing.Size(67, 17);
            this.rdbSexo2.TabIndex = 10;
            this.rdbSexo2.TabStop = true;
            this.rdbSexo2.Tag = "n";
            this.rdbSexo2.Text = "Feminino";
            this.rdbSexo2.UseVisualStyleBackColor = true;
            this.rdbSexo2.CheckedChanged += new System.EventHandler(this.rdbSexo2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sexo";
            // 
            // cmbSetor
            // 
            this.cmbSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetor.FormattingEnabled = true;
            this.cmbSetor.Location = new System.Drawing.Point(22, 174);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(205, 21);
            this.cmbSetor.TabIndex = 6;
            this.cmbSetor.Tag = "Setor";
            this.cmbSetor.DropDownClosed += new System.EventHandler(this.cmbSetor_DropDownClosed);
            this.cmbSetor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbSetor_KeyUp);
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(22, 124);
            this.cmbCargo.MaxDropDownItems = 20;
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(207, 21);
            this.cmbCargo.TabIndex = 5;
            this.cmbCargo.Tag = "Cargo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "RG";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(416, 78);
            this.txtRG.MaxLength = 12;
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(187, 20);
            this.txtRG.TabIndex = 4;
            this.txtRG.Tag = "RG";
            this.txtRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRG_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Setor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cargo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(413, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 13);
            this.label13.TabIndex = 10;
            this.label13.Tag = "n";
            this.label13.Text = "Código do Funcionário";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(413, 31);
            this.txtCodigo.MaxLength = 14;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(190, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.Tag = "n";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(19, 78);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(336, 20);
            this.txtEndereco.TabIndex = 3;
            this.txtEndereco.Tag = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(19, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(337, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Tag = "Nome";
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(247, 272);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 35);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(643, 272);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 35);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(544, 272);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 35);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(445, 272);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 35);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(346, 272);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 35);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(148, 272);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 35);
            this.btnNovo.TabIndex = 15;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Consulta por nome:";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(237, 19);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(469, 20);
            this.txtConsulta.TabIndex = 21;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            this.txtConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsulta_KeyPress);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFuncionarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFuncionarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(6, 48);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.Size = new System.Drawing.Size(932, 263);
            this.dgvFuncionarios.TabIndex = 22;
            this.dgvFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellClick);
            this.dgvFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(861, 590);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "* Apenas Números";
            // 
            // gpbRecuperaFuncionarios
            // 
            this.gpbRecuperaFuncionarios.Controls.Add(this.dgvFuncionarios);
            this.gpbRecuperaFuncionarios.Controls.Add(this.txtConsulta);
            this.gpbRecuperaFuncionarios.Controls.Add(this.label10);
            this.gpbRecuperaFuncionarios.Location = new System.Drawing.Point(12, 313);
            this.gpbRecuperaFuncionarios.Name = "gpbRecuperaFuncionarios";
            this.gpbRecuperaFuncionarios.Size = new System.Drawing.Size(944, 317);
            this.gpbRecuperaFuncionarios.TabIndex = 19;
            this.gpbRecuperaFuncionarios.TabStop = false;
            // 
            // errMsgErro
            // 
            this.errMsgErro.ContainerControl = this;
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 636);
            this.Controls.Add(this.gpbRecuperaFuncionarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gpbFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionários";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            this.gpbFuncionarios.ResumeLayout(false);
            this.gpbFuncionarios.PerformLayout();
            this.pnlAdmissao.ResumeLayout(false);
            this.pnlAdmissao.PerformLayout();
            this.pnlSexo.ResumeLayout(false);
            this.pnlSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.gpbRecuperaFuncionarios.ResumeLayout(false);
            this.gpbRecuperaFuncionarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMsgErro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFuncionarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbRecuperaFuncionarios;
        private System.Windows.Forms.ErrorProvider errMsgErro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.SaveFileDialog sfdExportaClientes;
        private System.Windows.Forms.OpenFileDialog ofdImportaClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblData2;
        private System.Windows.Forms.Label lblData1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSetor;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.RadioButton rdbSexo2;
        private System.Windows.Forms.RadioButton rdbSexo;
        private System.Windows.Forms.Panel pnlSexo;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label lblSenha2;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel pnlAdmissao;
        private System.Windows.Forms.RadioButton rbtAdmissao;
        private System.Windows.Forms.RadioButton rbtDemissao;
        private System.Windows.Forms.MaskedTextBox maskedDemissao;
        private System.Windows.Forms.MaskedTextBox maskedAdmissao;
    }
}