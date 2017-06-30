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
    public partial class frmCargo : Form
    {
        public frmCargo()
        {
            InitializeComponent();
        }

        private void frmCargo_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            zeraDados();
            controlaBotoes(true);
        }

        private void controlaBotoes(bool booLiberaBtNovo)
        {
            if (booLiberaBtNovo == true)
            {
                btnNovo.Enabled = true;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSair.Enabled = true;
                gpbRecuperaCargos.Enabled = true;

                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;
                gpbCargos.Enabled = false;

            }
            else
            {
                btnNovo.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSair.Enabled = false;
                gpbRecuperaCargos.Enabled = false;

                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                gpbCargos.Enabled = true;
            }
        }

        private bool validarDados()
        {
            string strMensagem = "";
            foreach (Control c in gpbCargos.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "" && c.Tag.ToString() != "n")
                    {
                        strMensagem = strMensagem + "O campo " + c.Tag.ToString() + " não foi inserido corretamente.\n";
                    }
                }
            }


            DataTableReader Dados = new DataTableReader(clsCargo.recuperarTodos());
            bool logado = false;
            while (Dados.Read())
            {
                if (String.Compare(Dados.GetString(1).ToUpper(), Convert.ToString(txtNome.Text).ToUpper()) == 0)
                {
                    logado = true;
                    break;
                }
            }
            if (logado == true)
            {
                strMensagem = "Nome especificado já existe. \n";
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            controlaBotoes(false);
            txtNome.Focus();
            zeraDados();
        }

        private void zeraDados()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validarDados())
            {
                try
                {
                    clsCargo objCargo = new clsCargo();
                    //objCategoria.IntCodigo = Convert.ToInt16(txtCodigo.Text);
                    objCargo.Nome = txtNome.Text;
                    if (txtCodigo.Text == "")
                    {
                        objCargo.Numero = 0;
                        objCargo.Salvar(objCargo);
                        //MessageBox.Show("Dados salvos com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        objCargo.Numero = Convert.ToInt32(txtCodigo.Text);
                        objCargo.Alterar(objCargo);
                        //MessageBox.Show("Dados alterados com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    /*controlaBotoes(true);
                    AtualizaGrid();
                    zeraDados();*/
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
                dgvCargos.DataSource = clsCargo.recuperarTodos();
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (this.dgvCargos.Rows.Count > 0)
            {
                if (txtCodigo.Text != "")
                {
                    controlaBotoes(false);
                }
                else
                {
                    MessageBox.Show("Selecione um registro para alterar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Sem dados registrados para alterar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.dgvCargos.Rows.Count > 0)
            {
                if (txtCodigo.Text != "")
                {
                    DialogResult result = MessageBox.Show("Confirma a exclusão dos dados selecionados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            clsCargo objCargo = new clsCargo();
                            objCargo.Numero = Convert.ToInt32(txtCodigo.Text);
                            objCargo.Excluir(objCargo);
                            controlaBotoes(true);
                            AtualizaGrid();
                            zeraDados();
                            //MessageBox.Show("Dados excluídos com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show("Dados não foram excluídos. \n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        
                        DataTableReader Dados = new DataTableReader(clsFuncionario.recuperarTodosComCargoSetor());
                        bool ok = false;
                        while (Dados.Read())
                        {
                            if (Dados.GetInt32(8) == Convert.ToInt32(txtCodigo.Text))
                            {
                                ok = true;
                                break;
                            }
                        }
                        controlaBotoes(true);
                        AtualizaGrid();
                        zeraDados();
                        if (ok == true)
                        {
                            MessageBox.Show("Existe(m) funcionário(s) com este cargo.\nDados não foram excluídos. \n", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Dados excluídos com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text = dgvCargos.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNome.Text = dgvCargos.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            dgvCargos.DataSource = clsCargo.recuperarTodosFiltro(txtConsulta.Text);
        }

        private void txtConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dgvCargos.DataSource = clsCargo.recuperarTodosFiltro(txtConsulta.Text);
            }
        }
        
    }
}
