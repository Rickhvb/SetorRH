using Controlador;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using SetorRH.Relatorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SetorRH
{
    public partial class frmRelatorio : Form
    {
        
        public frmRelatorio()
        {
            InitializeComponent();
        }
        
        
        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            txtRelatorio.Text = "";
            txtSelecao.Text = "";

        }

        private void crvRelatorioFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
            if (validarDados())
            {
               
             try
             {
                    ReportDocument cryRpt = new ReportDocument();
                    if (txtRelatorio.Text == "Funcionario")
                    {

                        if (txtSelecao.Text == "Data")
                        {

                            string caminho = @"C:\Users\Rick\Desktop\SetorRH\SetorRH\Relatorios\" + "FuncionarioData.rpt";
                            cryRpt.Load(caminho);
                            crvRelatorio.ReportSource = cryRpt;
                            crvRelatorio.Refresh();

                        }
                        else if (txtSelecao.Text == "Tipo")
                        {
                            string caminho = @"C:\Users\Rick\Desktop\SetorRH\SetorRH\Relatorios\" + "FuncionarioTipo.rpt";
                            cryRpt.Load(caminho);
                            crvRelatorio.ReportSource = cryRpt;
                            crvRelatorio.Refresh();
                        }
                        else if (txtSelecao.Text == "TipoData")
                        {

                            string caminho = @"C:\Users\Rick\Desktop\SetorRH\SetorRH\Relatorios\" + "FuncionarioTipoData.rpt";
                            cryRpt.Load(caminho);
                            crvRelatorio.ReportSource = cryRpt;
                            crvRelatorio.Refresh();

                        }
                        else if (txtSelecao.Text == "Todas")
                        {
                            string caminho = @"C:\Users\Rick\Desktop\SetorRH\SetorRH\Relatorios\" + "FuncionarioTodas.rpt";
                            cryRpt.Load(caminho);
                            crvRelatorio.ReportSource = cryRpt;
                            crvRelatorio.Refresh();
                        }

                    }
                    else if (txtRelatorio.Text == "Cargo")
                    {
                        if (txtSelecao.Text == "Data")
                        {

                            string caminho = @"C:\Users\Rick\Desktop\SetorRH\SetorRH\Relatorios\" + "CargoData.rpt";
                            cryRpt.Load(caminho);
                            crvRelatorio.ReportSource = cryRpt;
                            crvRelatorio.Refresh();

                        }
                        else if (txtSelecao.Text == "Tipo")
                        {
                            string caminho = @"C:\Users\Rick\Desktop\SetorRH\SetorRH\Relatorios\" + "CargoTipo.rpt";
                            cryRpt.Load(caminho);
                            crvRelatorio.ReportSource = cryRpt;
                            crvRelatorio.Refresh();
                        }
                        else if (txtSelecao.Text == "TipoData")
                        {

                            string caminho = @"C:\Users\Rick\Desktop\SetorRH\SetorRH\Relatorios\" + "CargoTipoData.rpt";
                            cryRpt.Load(caminho);
                            crvRelatorio.ReportSource = cryRpt;
                            crvRelatorio.Refresh();

                        }
                        else if (txtSelecao.Text == "Todas")
                        {
                            string caminho = @"C:\Users\Rick\Desktop\SetorRH\SetorRH\Relatorios\" + "CargoTodas.rpt";
                            cryRpt.Load(caminho);
                            crvRelatorio.ReportSource = cryRpt;
                            crvRelatorio.Refresh();
                        }
                    }
                    else if (txtRelatorio.Text == "Setor")
                    {
                        if (txtSelecao.Text == "Data")
                        {

                            string caminho = @"C:\Users\Rick\Desktop\SetorRH\SetorRH\Relatorios\" + "SetorData.rpt";
                            cryRpt.Load(caminho);
                            crvRelatorio.ReportSource = cryRpt;
                            crvRelatorio.Refresh();

                        }
                        else if (txtSelecao.Text == "Tipo")
                        {
                            string caminho = @"C:\Users\Rick\Desktop\SetorRH\SetorRH\Relatorios\" + "SetorTipo.rpt";
                            cryRpt.Load(caminho);
                            crvRelatorio.ReportSource = cryRpt;
                            crvRelatorio.Refresh();
                        }
                        else if (txtSelecao.Text == "TipoData")
                        {

                            string caminho = @"C:\Users\Rick\Desktop\SetorRH\SetorRH\Relatorios\" + "SetorTipoData.rpt";
                            cryRpt.Load(caminho);
                            crvRelatorio.ReportSource = cryRpt;
                            crvRelatorio.Refresh();

                        }
                        else if (txtSelecao.Text == "Todas")
                        {
                            string caminho = @"C:\Users\Rick\Desktop\SetorRH\SetorRH\Relatorios\" + "SetorTodas.rpt";
                            cryRpt.Load(caminho);
                            crvRelatorio.ReportSource = cryRpt;
                            crvRelatorio.Refresh();
                        }
                    }

                }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message + "\n" + ex.InnerException.ToString());
             }
            }
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", "Atenção",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool validarDados()
        {
            string strMensagem = "";
            
            if (txtRelatorio.Text == "")
            {
                strMensagem = strMensagem + "Selecione o Tipo de Relatório.\n";
            }
            if (txtSelecao.Text == "")
            {
                strMensagem = strMensagem + "Selecione o Tipo de Seleção.\n";
            }
            if (strMensagem == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(strMensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        
        
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void rbdSetor_CheckedChanged(object sender, EventArgs e)
        {
            txtRelatorio.Text = "Setor";
        }

        private void rbtFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            txtRelatorio.Text = "Funcionario";
        }

        private void rbtCargo_CheckedChanged(object sender, EventArgs e)
        {
            txtRelatorio.Text = "Cargo";
        }

        private void rbtTipo_CheckedChanged(object sender, EventArgs e)
        {
            txtSelecao.Text = "Tipo";
        }

        private void rbtData_CheckedChanged(object sender, EventArgs e)
        {
            txtSelecao.Text = "Data";
        }

        private void rbtTipoEData_CheckedChanged(object sender, EventArgs e)
        {
            txtSelecao.Text = "TipoData";
        }

        private void rbtTodas_CheckedChanged(object sender, EventArgs e)
        {
            txtSelecao.Text = "Todas";
        }
    }
}
