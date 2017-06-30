namespace SetorRH
{
    partial class frmFaltas
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
            this.gpbFaltas = new System.Windows.Forms.GroupBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtNJustificada = new System.Windows.Forms.RadioButton();
            this.rbtJustificada = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.numDuracao = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedData = new System.Windows.Forms.MaskedTextBox();
            this.lblData1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbRecuperaFaltas = new System.Windows.Forms.GroupBox();
            this.dgvFaltas = new System.Windows.Forms.DataGridView();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gpbFaltas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracao)).BeginInit();
            this.gpbRecuperaFaltas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaltas)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbFaltas
            // 
            this.gpbFaltas.Controls.Add(this.txtTipo);
            this.gpbFaltas.Controls.Add(this.panel1);
            this.gpbFaltas.Controls.Add(this.numDuracao);
            this.gpbFaltas.Controls.Add(this.label5);
            this.gpbFaltas.Controls.Add(this.maskedData);
            this.gpbFaltas.Controls.Add(this.lblData1);
            this.gpbFaltas.Controls.Add(this.label2);
            this.gpbFaltas.Controls.Add(this.label1);
            this.gpbFaltas.Controls.Add(this.txtNome);
            this.gpbFaltas.Controls.Add(this.txtCodigo);
            this.gpbFaltas.Location = new System.Drawing.Point(145, 45);
            this.gpbFaltas.Name = "gpbFaltas";
            this.gpbFaltas.Size = new System.Drawing.Size(549, 158);
            this.gpbFaltas.TabIndex = 0;
            this.gpbFaltas.TabStop = false;
            this.gpbFaltas.Text = "Falta";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(418, 98);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(38, 20);
            this.txtTipo.TabIndex = 19;
            this.txtTipo.Tag = "n";
            this.txtTipo.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtNJustificada);
            this.panel1.Controls.Add(this.rbtJustificada);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(295, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 64);
            this.panel1.TabIndex = 18;
            // 
            // rbtNJustificada
            // 
            this.rbtNJustificada.AutoSize = true;
            this.rbtNJustificada.Location = new System.Drawing.Point(18, 38);
            this.rbtNJustificada.Name = "rbtNJustificada";
            this.rbtNJustificada.Size = new System.Drawing.Size(100, 17);
            this.rbtNJustificada.TabIndex = 5;
            this.rbtNJustificada.Tag = "Tipo";
            this.rbtNJustificada.Text = "Não Justificável";
            this.rbtNJustificada.UseVisualStyleBackColor = true;
            this.rbtNJustificada.CheckedChanged += new System.EventHandler(this.rbtNJustificada_CheckedChanged);
            // 
            // rbtJustificada
            // 
            this.rbtJustificada.AutoSize = true;
            this.rbtJustificada.Checked = true;
            this.rbtJustificada.Location = new System.Drawing.Point(18, 14);
            this.rbtJustificada.Name = "rbtJustificada";
            this.rbtJustificada.Size = new System.Drawing.Size(77, 17);
            this.rbtJustificada.TabIndex = 4;
            this.rbtJustificada.TabStop = true;
            this.rbtJustificada.Tag = "Tipo";
            this.rbtJustificada.Text = "Justificável";
            this.rbtJustificada.UseVisualStyleBackColor = true;
            this.rbtJustificada.CheckedChanged += new System.EventHandler(this.rbtJustificada_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tipo*";
            // 
            // numDuracao
            // 
            this.numDuracao.Location = new System.Drawing.Point(149, 98);
            this.numDuracao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDuracao.Name = "numDuracao";
            this.numDuracao.Size = new System.Drawing.Size(120, 20);
            this.numDuracao.TabIndex = 3;
            this.numDuracao.Tag = "Duração";
            this.numDuracao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Duração* ( em horas )";
            // 
            // maskedData
            // 
            this.maskedData.Location = new System.Drawing.Point(36, 99);
            this.maskedData.Mask = "00/00/0000";
            this.maskedData.Name = "maskedData";
            this.maskedData.Size = new System.Drawing.Size(100, 20);
            this.maskedData.TabIndex = 2;
            this.maskedData.Tag = "n";
            this.maskedData.ValidatingType = typeof(System.DateTime);
            this.maskedData.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.maskedData_TypeValidationCompleted);
            // 
            // lblData1
            // 
            this.lblData1.AutoSize = true;
            this.lblData1.Location = new System.Drawing.Point(36, 83);
            this.lblData1.Name = "lblData1";
            this.lblData1.Size = new System.Drawing.Size(34, 13);
            this.lblData1.TabIndex = 14;
            this.lblData1.Text = "Data*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(143, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(188, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Tag = "n";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(36, 40);
            this.txtCodigo.MaxLength = 2;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(58, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Tag = "n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "*Campos com preenchimento obrigatório";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(315, 219);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 36);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(430, 219);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 36);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(547, 219);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 36);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gpbRecuperaFaltas
            // 
            this.gpbRecuperaFaltas.Controls.Add(this.label7);
            this.gpbRecuperaFaltas.Controls.Add(this.dgvFaltas);
            this.gpbRecuperaFaltas.Controls.Add(this.txtConsulta);
            this.gpbRecuperaFaltas.Controls.Add(this.label4);
            this.gpbRecuperaFaltas.Location = new System.Drawing.Point(145, 262);
            this.gpbRecuperaFaltas.Name = "gpbRecuperaFaltas";
            this.gpbRecuperaFaltas.Size = new System.Drawing.Size(549, 276);
            this.gpbRecuperaFaltas.TabIndex = 8;
            this.gpbRecuperaFaltas.TabStop = false;
            // 
            // dgvFaltas
            // 
            this.dgvFaltas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFaltas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFaltas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFaltas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvFaltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaltas.Location = new System.Drawing.Point(39, 84);
            this.dgvFaltas.Name = "dgvFaltas";
            this.dgvFaltas.ReadOnly = true;
            this.dgvFaltas.Size = new System.Drawing.Size(471, 181);
            this.dgvFaltas.TabIndex = 11;
            this.dgvFaltas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaltas_CellClick);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(162, 47);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(334, 20);
            this.txtConsulta.TabIndex = 10;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            this.txtConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsulta_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Consulta por Nome:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(206, 219);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 36);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Cadastrar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lista de Funcionários";
            // 
            // frmFaltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 602);
            this.Controls.Add(this.gpbRecuperaFaltas);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpbFaltas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFaltas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Faltas";
            this.Load += new System.EventHandler(this.frmFaltas_Load);
            this.gpbFaltas.ResumeLayout(false);
            this.gpbFaltas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracao)).EndInit();
            this.gpbRecuperaFaltas.ResumeLayout(false);
            this.gpbRecuperaFaltas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaltas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.GroupBox gpbFaltas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gpbRecuperaFaltas;
        private System.Windows.Forms.DataGridView dgvFaltas;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtNJustificada;
        private System.Windows.Forms.RadioButton rbtJustificada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numDuracao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedData;
        private System.Windows.Forms.Label lblData1;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label7;
    }
}