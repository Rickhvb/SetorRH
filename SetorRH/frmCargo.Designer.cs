namespace SetorRH
{
    partial class frmCargo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbCargos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbRecuperaCargos = new System.Windows.Forms.GroupBox();
            this.dgvCargos = new System.Windows.Forms.DataGridView();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbCargos.SuspendLayout();
            this.gpbRecuperaCargos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCargos
            // 
            this.gpbCargos.Controls.Add(this.label2);
            this.gpbCargos.Controls.Add(this.label1);
            this.gpbCargos.Controls.Add(this.txtNome);
            this.gpbCargos.Controls.Add(this.txtCodigo);
            this.gpbCargos.Location = new System.Drawing.Point(186, 45);
            this.gpbCargos.Name = "gpbCargos";
            this.gpbCargos.Size = new System.Drawing.Size(446, 142);
            this.gpbCargos.TabIndex = 0;
            this.gpbCargos.TabStop = false;
            this.gpbCargos.Text = "Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código*";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(36, 99);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Tag = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(36, 47);
            this.txtCodigo.MaxLength = 2;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(154, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Tag = "n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "*Campos com preenchimento obrigatório";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(238, 207);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 36);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(329, 207);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 36);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(420, 207);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 36);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(511, 207);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 36);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(602, 207);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 36);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gpbRecuperaCargos
            // 
            this.gpbRecuperaCargos.Controls.Add(this.dgvCargos);
            this.gpbRecuperaCargos.Controls.Add(this.txtConsulta);
            this.gpbRecuperaCargos.Controls.Add(this.label4);
            this.gpbRecuperaCargos.Location = new System.Drawing.Point(186, 262);
            this.gpbRecuperaCargos.Name = "gpbRecuperaCargos";
            this.gpbRecuperaCargos.Size = new System.Drawing.Size(446, 218);
            this.gpbRecuperaCargos.TabIndex = 8;
            this.gpbRecuperaCargos.TabStop = false;
            // 
            // dgvCargos
            // 
            this.dgvCargos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCargos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCargos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargos.Location = new System.Drawing.Point(39, 55);
            this.dgvCargos.Name = "dgvCargos";
            this.dgvCargos.ReadOnly = true;
            this.dgvCargos.Size = new System.Drawing.Size(348, 153);
            this.dgvCargos.TabIndex = 9;
            this.dgvCargos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargos_CellClick);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(143, 19);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(244, 20);
            this.txtConsulta.TabIndex = 8;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            this.txtConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsulta_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Consulta por Nome:";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(147, 207);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 36);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 602);
            this.Controls.Add(this.gpbRecuperaCargos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpbCargos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cargos";
            this.Load += new System.EventHandler(this.frmCargo_Load);
            this.gpbCargos.ResumeLayout(false);
            this.gpbCargos.PerformLayout();
            this.gpbRecuperaCargos.ResumeLayout(false);
            this.gpbRecuperaCargos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.GroupBox gpbCargos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gpbRecuperaCargos;
        private System.Windows.Forms.DataGridView dgvCargos;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSair;
    }
}