using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ClsFuncionario
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int numeroRegistro;

        public int NumeroRegistro
        {
            get { return numeroRegistro; }
            set { numeroRegistro = value; }
        }

        private string rg;

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        private string endereco;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private DateTime dataAdmissao;

        public DateTime DataAdmissao
        {
            get { return dataAdmissao; }
            set { dataAdmissao = value; }
        }

        private DateTime dataDemissao;

        public DateTime DataDemissao
        {
            get { return dataDemissao; }
            set { dataDemissao = value; }
        }

        private int cargo;

        public int Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        private int setor;

        public int Setor
        {
            get { return setor; }
            set { setor = value; }
        }
    }
}
