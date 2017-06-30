namespace SetorRH
{
    partial class frmRelatorio
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
            this.crvRelatorio = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbdSetor = new System.Windows.Forms.RadioButton();
            this.txtRelatorio = new System.Windows.Forms.TextBox();
            this.rbtCargo = new System.Windows.Forms.RadioButton();
            this.rbtFuncionario = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtData = new System.Windows.Forms.RadioButton();
            this.rbtTipo = new System.Windows.Forms.RadioButton();
            this.txtSelecao = new System.Windows.Forms.TextBox();
            this.rbtTipoEData = new System.Windows.Forms.RadioButton();
            this.rbtTodas = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvRelatorio
            // 
            this.crvRelatorio.ActiveViewIndex = -1;
            this.crvRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRelatorio.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRelatorio.Location = new System.Drawing.Point(29, 141);
            this.crvRelatorio.Name = "crvRelatorio";
            this.crvRelatorio.Size = new System.Drawing.Size(1868, 832);
            this.crvRelatorio.TabIndex = 0;
            this.crvRelatorio.Load += new System.EventHandler(this.crvRelatorioFuncionario_Load);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(1034, 57);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(82, 35);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(1143, 57);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 35);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbdSetor);
            this.panel1.Controls.Add(this.txtRelatorio);
            this.panel1.Controls.Add(this.rbtCargo);
            this.panel1.Controls.Add(this.rbtFuncionario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(439, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 123);
            this.panel1.TabIndex = 20;
            // 
            // rbdSetor
            // 
            this.rbdSetor.AutoSize = true;
            this.rbdSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdSetor.Location = new System.Drawing.Point(12, 83);
            this.rbdSetor.Name = "rbdSetor";
            this.rbdSetor.Size = new System.Drawing.Size(121, 20);
            this.rbdSetor.TabIndex = 21;
            this.rbdSetor.TabStop = true;
            this.rbdSetor.Text = "Faltas por Setor";
            this.rbdSetor.UseVisualStyleBackColor = true;
            this.rbdSetor.CheckedChanged += new System.EventHandler(this.rbdSetor_CheckedChanged);
            // 
            // txtRelatorio
            // 
            this.txtRelatorio.Location = new System.Drawing.Point(210, 42);
            this.txtRelatorio.Name = "txtRelatorio";
            this.txtRelatorio.Size = new System.Drawing.Size(36, 20);
            this.txtRelatorio.TabIndex = 20;
            this.txtRelatorio.Tag = "Tipo de Relatório";
            this.txtRelatorio.Visible = false;
            // 
            // rbtCargo
            // 
            this.rbtCargo.AutoSize = true;
            this.rbtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCargo.Location = new System.Drawing.Point(12, 37);
            this.rbtCargo.Name = "rbtCargo";
            this.rbtCargo.Size = new System.Drawing.Size(126, 20);
            this.rbtCargo.TabIndex = 18;
            this.rbtCargo.TabStop = true;
            this.rbtCargo.Text = "Faltas por Cargo";
            this.rbtCargo.UseVisualStyleBackColor = true;
            this.rbtCargo.CheckedChanged += new System.EventHandler(this.rbtCargo_CheckedChanged);
            // 
            // rbtFuncionario
            // 
            this.rbtFuncionario.AutoSize = true;
            this.rbtFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFuncionario.Location = new System.Drawing.Point(12, 60);
            this.rbtFuncionario.Name = "rbtFuncionario";
            this.rbtFuncionario.Size = new System.Drawing.Size(159, 20);
            this.rbtFuncionario.TabIndex = 19;
            this.rbtFuncionario.TabStop = true;
            this.rbtFuncionario.Text = "Faltas por Funcionário";
            this.rbtFuncionario.UseVisualStyleBackColor = true;
            this.rbtFuncionario.CheckedChanged += new System.EventHandler(this.rbtFuncionario_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Selecione o Tipo de Relatório";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbtData);
            this.panel2.Controls.Add(this.rbtTipo);
            this.panel2.Controls.Add(this.txtSelecao);
            this.panel2.Controls.Add(this.rbtTipoEData);
            this.panel2.Controls.Add(this.rbtTodas);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(748, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 123);
            this.panel2.TabIndex = 21;
            // 
            // rbtData
            // 
            this.rbtData.AutoSize = true;
            this.rbtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtData.Location = new System.Drawing.Point(12, 31);
            this.rbtData.Name = "rbtData";
            this.rbtData.Size = new System.Drawing.Size(113, 20);
            this.rbtData.TabIndex = 22;
            this.rbtData.TabStop = true;
            this.rbtData.Text = "Listar por Data";
            this.rbtData.UseVisualStyleBackColor = true;
            this.rbtData.CheckedChanged += new System.EventHandler(this.rbtData_CheckedChanged);
            // 
            // rbtTipo
            // 
            this.rbtTipo.AutoSize = true;
            this.rbtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTipo.Location = new System.Drawing.Point(12, 51);
            this.rbtTipo.Name = "rbtTipo";
            this.rbtTipo.Size = new System.Drawing.Size(112, 20);
            this.rbtTipo.TabIndex = 21;
            this.rbtTipo.TabStop = true;
            this.rbtTipo.Text = "Listar por Tipo";
            this.rbtTipo.UseVisualStyleBackColor = true;
            this.rbtTipo.CheckedChanged += new System.EventHandler(this.rbtTipo_CheckedChanged);
            // 
            // txtSelecao
            // 
            this.txtSelecao.Location = new System.Drawing.Point(190, 68);
            this.txtSelecao.Name = "txtSelecao";
            this.txtSelecao.Size = new System.Drawing.Size(44, 20);
            this.txtSelecao.TabIndex = 20;
            this.txtSelecao.Tag = "Tipo de Seleção";
            this.txtSelecao.Visible = false;
            // 
            // rbtTipoEData
            // 
            this.rbtTipoEData.AutoSize = true;
            this.rbtTipoEData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTipoEData.Location = new System.Drawing.Point(12, 71);
            this.rbtTipoEData.Name = "rbtTipoEData";
            this.rbtTipoEData.Size = new System.Drawing.Size(155, 20);
            this.rbtTipoEData.TabIndex = 18;
            this.rbtTipoEData.TabStop = true;
            this.rbtTipoEData.Text = "Listar por Tipo e Data";
            this.rbtTipoEData.UseVisualStyleBackColor = true;
            this.rbtTipoEData.CheckedChanged += new System.EventHandler(this.rbtTipoEData_CheckedChanged);
            // 
            // rbtTodas
            // 
            this.rbtTodas.AutoSize = true;
            this.rbtTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTodas.Location = new System.Drawing.Point(12, 91);
            this.rbtTodas.Name = "rbtTodas";
            this.rbtTodas.Size = new System.Drawing.Size(101, 20);
            this.rbtTodas.TabIndex = 19;
            this.rbtTodas.TabStop = true;
            this.rbtTodas.Text = "Listar Todas";
            this.rbtTodas.UseVisualStyleBackColor = true;
            this.rbtTodas.CheckedChanged += new System.EventHandler(this.rbtTodas_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Selecione a Seleção";
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1004);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.crvRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRelatorio";
            this.Text = "Relatório de Faltas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRelatorio;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbdSetor;
        private System.Windows.Forms.TextBox txtRelatorio;
        private System.Windows.Forms.RadioButton rbtCargo;
        private System.Windows.Forms.RadioButton rbtFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtData;
        private System.Windows.Forms.RadioButton rbtTipo;
        private System.Windows.Forms.TextBox txtSelecao;
        private System.Windows.Forms.RadioButton rbtTipoEData;
        private System.Windows.Forms.RadioButton rbtTodas;
        private System.Windows.Forms.Label label2;
    }
}