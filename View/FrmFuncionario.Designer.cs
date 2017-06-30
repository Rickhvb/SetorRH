namespace View
{
    partial class FrmFuncionario
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDemissao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdmissao = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.gpbRecuperaFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMsgErro)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbFuncionarios
            // 
            this.gpbFuncionarios.Controls.Add(this.label9);
            this.gpbFuncionarios.Controls.Add(this.txtRG);
            this.gpbFuncionarios.Controls.Add(this.label6);
            this.gpbFuncionarios.Controls.Add(this.txtSetor);
            this.gpbFuncionarios.Controls.Add(this.label8);
            this.gpbFuncionarios.Controls.Add(this.txtCargo);
            this.gpbFuncionarios.Controls.Add(this.label4);
            this.gpbFuncionarios.Controls.Add(this.txtSexo);
            this.gpbFuncionarios.Controls.Add(this.label3);
            this.gpbFuncionarios.Controls.Add(this.txtDemissao);
            this.gpbFuncionarios.Controls.Add(this.label1);
            this.gpbFuncionarios.Controls.Add(this.txtAdmissao);
            this.gpbFuncionarios.Controls.Add(this.label13);
            this.gpbFuncionarios.Controls.Add(this.txtCodigo);
            this.gpbFuncionarios.Controls.Add(this.txtEndereco);
            this.gpbFuncionarios.Controls.Add(this.label7);
            this.gpbFuncionarios.Controls.Add(this.label5);
            this.gpbFuncionarios.Controls.Add(this.txtNome);
            this.gpbFuncionarios.Location = new System.Drawing.Point(16, 22);
            this.gpbFuncionarios.Name = "gpbFuncionarios";
            this.gpbFuncionarios.Size = new System.Drawing.Size(817, 233);
            this.gpbFuncionarios.TabIndex = 0;
            this.gpbFuncionarios.TabStop = false;
            this.gpbFuncionarios.Text = "Dados do Funcionário";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(363, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "RG";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(363, 111);
            this.txtRG.MaxLength = 12;
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(127, 20);
            this.txtRG.TabIndex = 4;
            this.txtRG.Tag = "RG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Setor";
            // 
            // txtSetor
            // 
            this.txtSetor.Location = new System.Drawing.Point(26, 207);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(124, 20);
            this.txtSetor.TabIndex = 7;
            this.txtSetor.Tag = "Setor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cargo";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(23, 166);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(127, 20);
            this.txtCargo.TabIndex = 6;
            this.txtCargo.Tag = "Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sexo";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(502, 111);
            this.txtSexo.MaxLength = 1;
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(97, 20);
            this.txtSexo.TabIndex = 5;
            this.txtSexo.Tag = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data de Demissão";
            // 
            // txtDemissao
            // 
            this.txtDemissao.Location = new System.Drawing.Point(366, 207);
            this.txtDemissao.MaxLength = 10;
            this.txtDemissao.Name = "txtDemissao";
            this.txtDemissao.Size = new System.Drawing.Size(124, 20);
            this.txtDemissao.TabIndex = 9;
            this.txtDemissao.Tag = "n";
            this.txtDemissao.Text = "00-00-0000";
            this.txtDemissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDemissao_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data de Admissão";
            // 
            // txtAdmissao
            // 
            this.txtAdmissao.Location = new System.Drawing.Point(363, 166);
            this.txtAdmissao.MaxLength = 10;
            this.txtAdmissao.Name = "txtAdmissao";
            this.txtAdmissao.Size = new System.Drawing.Size(127, 20);
            this.txtAdmissao.TabIndex = 8;
            this.txtAdmissao.Tag = "Data de Admissão";
            this.txtAdmissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdmissao_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 13);
            this.label13.TabIndex = 10;
            this.label13.Tag = "n";
            this.label13.Text = "Código do Funcionário";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(20, 73);
            this.txtCodigo.MaxLength = 14;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(110, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.Tag = "n";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(20, 111);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(336, 20);
            this.txtEndereco.TabIndex = 3;
            this.txtEndereco.Tag = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 96);
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
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nome*";
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
            this.btnSalvar.Location = new System.Drawing.Point(170, 272);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 35);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar   ";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(566, 272);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 35);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair      ";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(467, 272);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 35);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir    ";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(368, 272);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 35);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar    ";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(269, 272);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 35);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar ";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(71, 272);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 35);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo     ";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Consulta por nome:";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(160, 13);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(469, 20);
            this.txtConsulta.TabIndex = 16;
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
            this.dgvFuncionarios.Size = new System.Drawing.Size(812, 172);
            this.dgvFuncionarios.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(623, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "*Campos com preenchimento obrigatório";
            // 
            // gpbRecuperaFuncionarios
            // 
            this.gpbRecuperaFuncionarios.Controls.Add(this.dgvFuncionarios);
            this.gpbRecuperaFuncionarios.Controls.Add(this.txtConsulta);
            this.gpbRecuperaFuncionarios.Controls.Add(this.label10);
            this.gpbRecuperaFuncionarios.Location = new System.Drawing.Point(12, 313);
            this.gpbRecuperaFuncionarios.Name = "gpbRecuperaFuncionarios";
            this.gpbRecuperaFuncionarios.Size = new System.Drawing.Size(824, 227);
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
            this.ClientSize = new System.Drawing.Size(848, 600);
            this.Controls.Add(this.gpbRecuperaFuncionarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.gpbFuncionarios);
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionários";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            this.gpbFuncionarios.ResumeLayout(false);
            this.gpbFuncionarios.PerformLayout();
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
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDemissao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdmissao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCargo;
    }
}