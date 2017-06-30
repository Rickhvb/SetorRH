using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace View
{
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void controlaBotoes(bool booLiberaBtNovo)
        {
            if (booLiberaBtNovo == true)
            {
                btnNovo.Enabled = true;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSair.Enabled = true;
                gpbRecuperaFuncionarios.Enabled = true;

                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                gpbFuncionarios.Enabled = false;

            }
            else
            {
                btnNovo.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSair.Enabled = false;
                gpbRecuperaFuncionarios.Enabled = false;

                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                gpbFuncionarios.Enabled = true;
            }
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            controlaBotoes(true);
        }

        private void AtualizaGrid()
        {
            try
            {
                //dgvFuncionarios.DataSource = clsFuncionario.recuperarTodos();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=RICK-PC\SQLEXPRESSSERVER;Initial Catalog=SetorRH;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("select * from funcionario", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = dr;
                dgvFuncionarios.DataSource = source;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Não foi possível recuperar os dados.  \nContate o administrador. \n\n" + ex.Message);
            }
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = ClsFuncionario.recuperarTodosFiltro(txtConsulta.Text);
        }

        private void txtConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dgvFuncionarios.DataSource = clsFuncionario.recuperarTodosFiltro(txtConsulta.Text);
            }
        }

        private bool validarDados()
        {
            string strMensagem = "";
            foreach (Control c in gpbFuncionarios.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "" && c.Tag.ToString() != "n")
                    {
                        strMensagem = strMensagem + "O campo " + c.Tag.ToString() + " não foi inserido corretamente.\n";
                    }
                }
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


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validarDados() && verificaDataAdmissao() && verificaDataDemissao())
            {
                try
                {
                    clsFuncionario objFuncionario = new clsFuncionario();
                    objFuncionario.Nome = txtNome.Text;
                    objFuncionario.Rg = txtRG.Text;
                    objFuncionario.Endereco = txtEndereco.Text;
                    objFuncionario.Sexo = txtSexo.Text;
                    objFuncionario.DataAdmissao = Convert.ToDateTime(txtAdmissao.Text);
                    objFuncionario.DataDemissao = Convert.ToDateTime(txtDemissao.Text);
                    objFuncionario.Cargo = Convert.ToInt32(txtCargo.Text);
                    objFuncionario.Setor = Convert.ToInt32(txtSetor.Text);

                    if ((String.IsNullOrEmpty(txtCodigo.Text)))
                    {
                        int n = objFuncionario.Salvar(objFuncionario);
                        MessageBox.Show("Dados salvos com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        objFuncionario.NumeroRegistro = Convert.ToInt32(txtCodigo.Text);
                        objFuncionario.Alterar();
                        MessageBox.Show("Dados alterados com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    controlaBotoes(true);
                    AtualizaGrid();
                    zeraDados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dados do funcionário não foram salvos. \n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                /*txtCPF.Text = dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCodigo.Text = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNome.Text = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDatadeNascimento.Text = dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEndereco.Text = dgvClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtNumero.Text = dgvClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtBairro.Text = dgvClientes.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtCidade.Text = dgvClientes.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtEstado.Text = dgvClientes.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtEmail.Text = dgvClientes.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtTelefone.Text = dgvClientes.Rows[e.RowIndex].Cells[10].Value.ToString();*/
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            zeraDados();
            controlaBotoes(false);
            txtNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            zeraDados();
            controlaBotoes(true);
        }

        private void zeraDados()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtRG.Text = "";
            txtSexo.Text = "";
            txtCodigo.Text = "";
            txtAdmissao.Text = "";
            txtDemissao.Text = "";
            txtCargo.Text = "";
            txtSetor.Text = "";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (this.dgvFuncionarios.Rows.Count > 0)
            {
                if (txtNome.Text != "")
                {
                    controlaBotoes(false);
                }
                else
                {
                    MessageBox.Show(this, "Selecione um registro para alterar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Sem dados registrados para alterar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.dgvFuncionarios.Rows.Count > 0)
            {
                if (txtNome.Text != "")
                {
                    DialogResult result = MessageBox.Show("Confirma a exclusão dos dados selecionados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            clsFuncionario objFuncionario = new clsFuncionario();
                            objFuncionario.NumeroRegistro = Convert.ToInt32(txtCodigo.Text);
                            objFuncionario.Excluir();
                            controlaBotoes(true);
                            AtualizaGrid();
                            zeraDados();
                            MessageBox.Show("Dados excluídos com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Dados do Funcionário não foram excluídos. \n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        zeraDados();
                    }
                }
                else
                {
                    MessageBox.Show(this, "Selecione um registro para excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Sem dados registrados para excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private Boolean verificaDataAdmissao()
        {
            if (txtAdmissao.TextLength < 10 && txtAdmissao.TextLength > 0 || txtAdmissao.Text.Contains(" "))
            {
                MessageBox.Show("Data Inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errMsgErro.SetError(txtAdmissao, "Data não preenchida corretamente\nFormato: dd/mm/aaaa");
                return false;
            }
            else
            {
                errMsgErro.SetError(txtAdmissao, "");
                return true;
            }
        }

        private Boolean verificaDataDemissao()
        {
            if (txtDemissao.TextLength < 10 && txtDemissao.TextLength > 0 || txtDemissao.Text.Contains(" "))
            {
                MessageBox.Show("Data Inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errMsgErro.SetError(txtDemissao, "Data não preenchida corretamente\nFormato: dd/mm/aaaa");
                return false;
            }
            else
            {
                errMsgErro.SetError(txtDemissao, "");
                return true;
            }
        }


        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }




        private void txtAdmissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8 && e.KeyChar != (Char)9)
            {
                e.KeyChar = (Char)0;
                MessageBox.Show("Data inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtDatadeNascimento.Focus();
            }
            if ((char.IsNumber(e.KeyChar) == true))
            {
                switch (txtAdmissao.TextLength)
                {
                    case 0:
                        txtAdmissao.Text = "";
                        break;
                    case 2:
                        txtAdmissao.Text = txtAdmissao.Text + "-";
                        txtAdmissao.SelectionStart = 4;
                        break;
                    case 5:
                        txtAdmissao.Text = txtAdmissao.Text + "-";
                        txtAdmissao.SelectionStart = 10;
                        break;
                }
            }
        }

        private void txtDemissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8 && e.KeyChar != (Char)9)
            {
                e.KeyChar = (Char)0;
                MessageBox.Show("Data inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtDatadeNascimento.Focus();
            }
            if ((char.IsNumber(e.KeyChar) == true))
            {
                switch (txtDemissao.TextLength)
                {
                    case 0:
                        txtDemissao.Text = "";
                        break;
                    case 2:
                        txtDemissao.Text = txtDemissao.Text + "-";
                        txtDemissao.SelectionStart = 4;
                        break;
                    case 5:
                        txtDemissao.Text = txtDemissao.Text + "-";
                        txtDemissao.SelectionStart = 10;
                        break;
                }
            }
        }

    }
}
