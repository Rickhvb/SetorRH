using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetorRH
{
    public partial class frmFaltas : Form
    {
        public frmFaltas()
        {
            InitializeComponent();
        }

        private void frmFaltas_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            zeraDados();
            controlaBotoes(true);
        }

        private void controlaBotoes(bool booLiberaBtNovo)
        {
            if (booLiberaBtNovo == true)
            {
                btnAlterar.Enabled = true;
                btnSair.Enabled = true;
                gpbRecuperaFaltas.Enabled = true;

                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                gpbFaltas.Enabled = false;

            }
            else
            {
                btnAlterar.Enabled = false;
                btnSair.Enabled = false;
                gpbRecuperaFaltas.Enabled = false;

                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                gpbFaltas.Enabled = true;
            }
        }

        private bool validarDados()
        {
            string strMensagem = "";
            foreach (Control c in gpbFaltas.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "" && c.Tag.ToString() != "n")
                    {
                        strMensagem = strMensagem + "O campo " + c.Tag.ToString() + " não foi inserido corretamente.\n";
                    }
                }
            }
            if (verificaData() == false)
            {
                strMensagem = strMensagem + "O campo Data não foi inserido corretamente.\n";
            }
            if (numDuracao.Value <= 0)
            {
                strMensagem = strMensagem + "Duração deve ser maior do que zero.\n";
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

        private Boolean verificaData()
        {
            if (maskedData.TextLength != 10 || maskedData.Text.Contains(" "))
            {
                MessageBox.Show("Data Inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (this.dgvFaltas.Rows.Count > 0)
            {
                if (txtNome.Text != "")
                {
                    controlaBotoes(false);
                }
                else
                {
                    MessageBox.Show(this, "Selecione um funcionário para cadastrar faltas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Sem dados registrados para cadastrar horas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void zeraDados()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            maskedData.Text = "";
            numDuracao.Value = 1;
            rbtJustificada.Checked = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validarDados())
            {
                try
                {
                    clsFalta objFalta = new clsFalta();
                    objFalta.Funcionario = Convert.ToInt32(txtCodigo.Text);
                    objFalta.Data = Convert.ToDateTime(maskedData.Text);
                    objFalta.Duracao = Convert.ToInt32(numDuracao.Value);
                    objFalta.Tipo = txtTipo.Text;
                    objFalta.Salvar(objFalta);
                    //MessageBox.Show("Dados salvos com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Dados nao foram salvos. \n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                controlaBotoes(true);
                AtualizaGrid();
                zeraDados();
                MessageBox.Show("Dados salvos com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void AtualizaGrid()
        {
            try
            {
                dgvFaltas.DataSource = clsFalta.recuperarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Não foi possível recuperar os dados.  \nContate o administrador. \n\n" + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            controlaBotoes(true);
            zeraDados();
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

        private void dgvFaltas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text = dgvFaltas.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dgvFaltas.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            dgvFaltas.DataSource = clsFalta.recuperarTodosFiltro(txtConsulta.Text);
        }

        private void txtConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dgvFaltas.DataSource = clsFalta.recuperarTodosFiltro(txtConsulta.Text);
            }
        }

        private void rbtJustificada_CheckedChanged(object sender, EventArgs e)
        {
            txtTipo.Text = "Justificável";
        }

        private void rbtNJustificada_CheckedChanged(object sender, EventArgs e)
        {
            txtTipo.Text = "Não Justificável";
        }

        private void maskedData_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
                MessageBox.Show("Data inválida");
        }
    }
}
