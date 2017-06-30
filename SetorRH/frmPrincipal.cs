using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SetorRH.Visao;

namespace SetorRH
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            frmAutenticacao frmAutenticacao = new frmAutenticacao();
            frmAutenticacao.Visible = false;
            frmAutenticacao.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmAutenticacao frmAutenticacao = new frmAutenticacao();
            frmAutenticacao.Visible = false;
            frmAutenticacao.Close();
            toolStripStatusLabel4.Text = nome;

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "SetorRH",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        private void funcionáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFuncionario frmFuncionario = new frmFuncionario();
            frmFuncionario.ShowDialog();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void faltasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmFaltas frmFaltas = new frmFaltas();
            frmFaltas.ShowDialog();
        }

        private void setoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmSetor frmSetor = new frmSetor();
            frmSetor.ShowDialog();
        }

        private void cargosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCargo frmCargo = new frmCargo();
            frmCargo.ShowDialog();
        }

        public string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void faltasPorFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorio objRel = new frmRelatorio();
            objRel.ShowDialog();

        }
       
    }
}
