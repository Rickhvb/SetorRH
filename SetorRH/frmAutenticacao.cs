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
    public partial class frmAutenticacao : Form
    {
        public frmAutenticacao()
        {
            InitializeComponent();
        }

        private void frmAutenticacao_Load(object sender, EventArgs e)
        {

        }

        private int ok = 0;

        public int Ok
        {
            get { return ok; }
            set { ok = value; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ok = 0;
            this.Close();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            
            string correto;
            string login = "";
            string senha = "";
            senha = Convert.ToString(txtSenha.Text);
            login = Convert.ToString(txtUsuario.Text);
            frmPrincipal frmPrincipal = new frmPrincipal();
            DataTableReader Dados = new DataTableReader(clsFuncionario.recuperarSenha(login, senha));
            bool logado = false;
            if (txtSenha.Text == "admin" && txtUsuario.Text == "admin")
            {
                logado = true;
                string nome = "Administrador";
                frmPrincipal.Nome = "        Logado como " + nome;
            }
            while (Dados.Read())
            {
                correto = Dados.GetValue(0).ToString();
                if ((correto == login
                    && String.Compare(Dados.GetString(2), Convert.ToString(txtSenha.Text)) == 0))
                {
                    logado = true;
                    string nome = Dados.GetString(1);
                    frmPrincipal.Nome = "        Logado como " + nome;
                    break;
                }
            }
            if (logado)
            {
                this.Hide();
                frmPrincipal.ShowDialog();
                this.Visible = false;
                this.Close();
                ok = 1;

            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Erro ao autenticar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSenha.Text = "";
                txtUsuario.Text = "";
                txtUsuario.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.btnOK_Click(sender, e);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
