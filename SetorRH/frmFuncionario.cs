using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using System.Data.SqlClient;
using System.Globalization;

namespace SetorRH.Visao
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
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
            AtualizaComboBox();
            zeraDados();
            controlaBotoes(true);
        }

        private void AtualizaGrid()
        {
            try
            {
                dgvFuncionarios.DataSource = clsFuncionario.recuperarTodos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Não foi possível recuperar os dados.  \nContate o administrador. \n\n" + ex.Message);
            }
        }

        private void AtualizaComboBox()
        {
            cmbSetor.DataSource = clsSetor.recuperarTodos();
            cmbSetor.DisplayMember = "Nome";
            cmbSetor.ValueMember = "NUMERO";

            cmbCargo.DataSource = clsCargo.recuperarTodos();
            cmbCargo.DisplayMember = "NOME";
            cmbCargo.ValueMember = "NUMERO";
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = clsFuncionario.recuperarTodosFiltro(txtConsulta.Text);
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
            if (txtSenha.Text == "" && txtSenha2.Text == "" && cmbSetor.Text == "RH")
            {
                strMensagem = strMensagem + "O campo Senha não foi inserido corretamente.\n";
            }
            if (cmbSetor.Text == "")
            {
                strMensagem = strMensagem + "O campo Setor não foi inserido corretamente.\n";
            }
            if (cmbCargo.Text == "")
            {
                strMensagem = strMensagem + "O campo Cargo não foi inserido corretamente.\n";
            }
            if (verificaDataAdmissao() == false)
            {
                strMensagem = strMensagem + "O campo Admissão não foi inserido corretamente.\n";
            }
            if (rbtDemissao.Checked == true && verificaDataDemissao()== false)
            {
                strMensagem = strMensagem + "O campo Demissão não foi inserido corretamente.\n";
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
            if (validarDados() && verificaSenha())
            {
                clsFuncionario objFuncionario = new clsFuncionario();
                objFuncionario.Nome = txtNome.Text;
                objFuncionario.Rg = txtRG.Text;
                objFuncionario.Endereco = txtEndereco.Text;
                objFuncionario.Sexo = txtSexo.Text;
                objFuncionario.DataAdmissao = Convert.ToDateTime(maskedAdmissao.Text);
                objFuncionario.Cargo = Convert.ToInt32(cmbCargo.SelectedValue.ToString());
                objFuncionario.Setor = Convert.ToInt32(cmbSetor.SelectedValue.ToString());
                objFuncionario.Senha = txtSenha.Text;

                if (maskedDemissao.Text != null && maskedDemissao.Text != "  /  /")
                {
                    objFuncionario.DataDemissao = Convert.ToDateTime(maskedDemissao.Text);
                    try
                    {
                        if ((String.IsNullOrEmpty(txtCodigo.Text)))
                        {
                            objFuncionario.Salvar(objFuncionario);
                            //MessageBox.Show("Dados salvos com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            objFuncionario.NumeroRegistro = Convert.ToInt32(txtCodigo.Text);
                            objFuncionario.Alterar(objFuncionario);
                            //MessageBox.Show("Dados alterados com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Dados do funcionário não foram salvos. \n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    controlaBotoes(true);
                    AtualizaGrid();
                    zeraDados();
                    MessageBox.Show("Dados salvos com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    try
                    {
                        if ((String.IsNullOrEmpty(txtCodigo.Text)))
                        {
                            objFuncionario.SalvarSemDemissao(objFuncionario);
                            //MessageBox.Show("Dados salvos com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            objFuncionario.NumeroRegistro = Convert.ToInt32(txtCodigo.Text);
                            objFuncionario.AlterarSemDemissao(objFuncionario);
                            //MessageBox.Show("Dados alterados com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Dados do funcionário não foram salvos. \n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    controlaBotoes(true);
                    AtualizaGrid();
                    zeraDados();
                    MessageBox.Show("Dados salvos com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void btnNovo_Click(object sender, EventArgs e)
        {

            AtualizaComboBox();
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
            maskedAdmissao.Text = "";
            maskedDemissao.Text = "";
            cmbCargo.Text = null;
            cmbSetor.Text = null;
            rdbSexo.Checked = false;
            rdbSexo2.Checked = false;
            txtSenha.Text = "";
            txtSenha2.Text = "";
            txtSenha.Visible = false;
            txtSenha2.Visible = false;
            lblSenha.Visible = false;
            lblSenha2.Visible = false;
            lblData1.Visible = false;
            maskedAdmissao.Visible = false;
            lblData2.Visible = false;
            maskedDemissao.Visible = false;
            rbtAdmissao.Checked = false;
            rbtDemissao.Checked = false;

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
                            objFuncionario.Excluir(objFuncionario);
                            controlaBotoes(true);
                            AtualizaGrid();
                            zeraDados();
                            //MessageBox.Show("Dados excluídos com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show("Dados do Funcionário não foram excluídos. \n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        controlaBotoes(true);
                        AtualizaGrid();
                        zeraDados();
                        MessageBox.Show("Dados excluídos com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            if (maskedAdmissao.TextLength != 10 || maskedAdmissao.Text.Contains(" "))
            {
                MessageBox.Show("Data Inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errMsgErro.SetError(maskedAdmissao, "Data não preenchida corretamente\nFormato: dd/mm/aaaa");
                return false;
            }
            else
            {
                errMsgErro.SetError(maskedAdmissao, "");
                return true;
            }
        }

        private Boolean verificaSenha()
        {
            string strMensagem = "";
            if (txtSenha.Text != txtSenha2.Text)
            {
                strMensagem = strMensagem + "Senhas não conferem.\n";
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

        private Boolean verificaDataDemissao()
        {
            if (maskedDemissao.TextLength != 10 || maskedDemissao.Text.Contains(" "))
            {
                MessageBox.Show("Data Inválida!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errMsgErro.SetError(maskedDemissao, "Data não preenchida corretamente\nFormato: dd/mm/aaaa");
                return false;
            }
            else
            {
                errMsgErro.SetError(maskedDemissao, "");
                return true;
            }
        }


        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        
        
        private void dgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRG.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                var date1 = DateTime.Parse(dgvFuncionarios.Rows[e.RowIndex].Cells[5].Value.ToString());
                maskedAdmissao.Text = date1.ToShortDateString();
                txtEndereco.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[3].Value.ToString();

                if (dgvFuncionarios.Rows[e.RowIndex].Cells[6].Value.ToString() == "")
                {
                    maskedDemissao.Text = "";
                }
                else
                {
                    var date2 = DateTime.Parse(dgvFuncionarios.Rows[e.RowIndex].Cells[6].Value.ToString());
                    maskedDemissao.Text = date2.ToShortDateString();
                }
                
                cmbSetor.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[7].Value.ToString();
                cmbCargo.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtSexo.Text = dgvFuncionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (txtSexo.Text == "M")
                {
                    rdbSexo.Checked = true;
                }else
                {
                    rdbSexo2.Checked = true;
                }
            }

        }
        
        private void rdbSexo_CheckedChanged(object sender, EventArgs e)
        {
            txtSexo.Text = "M";

        }

        private void rdbSexo2_CheckedChanged(object sender, EventArgs e)
        {
            txtSexo.Text = "F";
        }
        

        private void cmbSetor_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbSetor.Text == "RH")
            {
                txtSenha.Text = "";
                txtSenha2.Text = "";
                txtSenha.Visible = true;
                txtSenha2.Visible = true;
                lblSenha.Visible = true;
                lblSenha2.Visible = true;
            }
            else
            {
                txtSenha.Visible = false;
                txtSenha2.Visible = false;
                lblSenha.Visible = false;
                lblSenha2.Visible = false;
            }
        }
        

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8 && e.KeyChar != (Char)9)
            {
                e.KeyChar = (Char)0;

            }
            if ((char.IsNumber(e.KeyChar) == true))
            {
                switch (txtRG.TextLength)
                {
                    case 0:
                        txtRG.Text = "";
                        break;
                    case 2:
                        txtRG.Text = txtRG.Text + ".";
                        txtRG.SelectionStart = 5;
                        break;
                    case 6:
                        txtRG.Text = txtRG.Text + ".";
                        txtRG.SelectionStart = 9;
                        break;
                    case 10:
                        txtRG.Text = txtRG.Text + "-";
                        txtRG.SelectionStart = 12;
                        break;
                }
            }
        }
        

        private void rbtAdmissao_CheckedChanged(object sender, EventArgs e)
        {
            lblData1.Visible = true;
            maskedAdmissao.Visible = true;
            lblData2.Visible = false;
            maskedDemissao.Visible = false;
        }

        private void rbtDemissao_CheckedChanged(object sender, EventArgs e)
        {
            lblData1.Visible = true;
            maskedAdmissao.Visible = true;
            lblData2.Visible = true;
            maskedDemissao.Visible = true;
        }

        private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
                MessageBox.Show("Data inválida");
        }

        private void maskedTextBox2_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
                MessageBox.Show("Data inválida");
        }

        private void cmbSetor_KeyUp(object sender, KeyEventArgs e)
        {
            if (cmbSetor.Text == "RH")
            {
                txtSenha.Text = "";
                txtSenha2.Text = "";
                txtSenha.Visible = true;
                txtSenha2.Visible = true;
                lblSenha.Visible = true;
                lblSenha2.Visible = true;
            }
            else
            {
                txtSenha.Visible = false;
                txtSenha2.Visible = false;
                lblSenha.Visible = false;
                lblSenha2.Visible = false;
            }
        }

        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
