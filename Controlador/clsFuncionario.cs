using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Modelo;

using System.IO;
using System.Data.SqlClient;

namespace Controlador
{
    public class clsFuncionario
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

        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
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


        public clsFuncionario()
        {

        }
        public void Salvar(clsFuncionario funcionario)
        {
            DadosSistema dados = new DadosSistema();
            string[] parametros = {
                                    "@OPERACAO",
                                    "@NUMERO_REGISTRO",
                                    "@NOME",
                                    "@RG",
                                    "@SEXO",
                                    "@ENDERECO",
                                    "@SETOR",
                                    "@CARGO",
                                    "@SENHA",
                                    "@DATA_ADMISSAO",
                                    "@DATA_DEMISSAO"
            };try
            {
             dados.Executar("FUNCIONARIO_I_A", parametros, "I",
                                    funcionario.numeroRegistro, funcionario.nome, funcionario.rg, funcionario.sexo, funcionario.endereco,
                                    funcionario.setor, funcionario.cargo, funcionario.senha, funcionario.dataAdmissao, funcionario.dataDemissao);
            
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SalvarSemDemissao(clsFuncionario funcionario)
        {
            DadosSistema dados = new DadosSistema();
            string[] parametros = {
                                    "@OPERACAO",
                                    "@NUMERO_REGISTRO",
                                    "@NOME",
                                    "@RG",
                                    "@SEXO",
                                    "@ENDERECO",
                                    "@SETOR",
                                    "@CARGO",
                                    "@SENHA",
                                    "@DATA_ADMISSAO"
            }; try
            {
                dados.Executar("FUNCIONARIO_DEM", parametros, "S",
                                       funcionario.numeroRegistro, funcionario.nome, funcionario.rg, funcionario.sexo, funcionario.endereco,
                                       funcionario.setor, funcionario.cargo, funcionario.senha, funcionario.dataAdmissao);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(clsFuncionario funcionario)
        {
            DadosSistema dados = new DadosSistema();
            string[] parametros = {
                                    "@OPERACAO",
                                    "@REGISTRO"
            }; try
            {
                dados.Executar("FUNCIONARIO_S_D", parametros, "E",
                                       funcionario.numeroRegistro);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public void Alterar(clsFuncionario funcionario)
        {
            DadosSistema dados = new DadosSistema();
            string[] parametros = {
                                    "@OPERACAO",
                                    "@NUMERO_REGISTRO",
                                    "@NOME",
                                    "@RG",
                                    "@SEXO",
                                    "@ENDERECO",
                                    "@SETOR",
                                    "@CARGO",
                                    "@SENHA",
                                    "@DATA_ADMISSAO",
                                    "@DATA_DEMISSAO"
            }; try
            {
                dados.Executar("FUNCIONARIO_I_A", parametros, "A",
                                       funcionario.numeroRegistro, funcionario.nome, funcionario.rg, funcionario.sexo, funcionario.endereco,
                                       funcionario.setor, funcionario.cargo, funcionario.senha, funcionario.dataAdmissao, funcionario.dataDemissao);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarSemDemissao(clsFuncionario funcionario)
        {
            DadosSistema dados = new DadosSistema();
            string[] parametros = {
                                    "@OPERACAO",
                                    "@NUMERO_REGISTRO",
                                    "@NOME",
                                    "@RG",
                                    "@SEXO",
                                    "@ENDERECO",
                                    "@SETOR",
                                    "@CARGO",
                                    "@SENHA",
                                    "@DATA_ADMISSAO"
            }; try
            {
                dados.Executar("FUNCIONARIO_DEM", parametros, "D",
                                       funcionario.numeroRegistro, funcionario.nome, funcionario.rg, funcionario.sexo, funcionario.endereco,
                                       funcionario.setor, funcionario.cargo, funcionario.senha, funcionario.dataAdmissao);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static DataTable recuperarTodos()
        {
            
            DadosSistema Geral = null;
            DataTable tblDados = null;

            tblDados = new DataTable();

            try
            {
                Geral = new DadosSistema();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@OPERACAO";
                parParameter[0].SqlDbType = SqlDbType.Char;
                parParameter[0].SqlValue = "Q";

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@REGISTRO";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = 1;

                tblDados = Geral.getDadosTable(parParameter, "FUNCIONARIO_S_D");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDados;
        }

        public static DataTable recuperarTodosComCargoSetor()
        {

            DadosSistema Geral = null;
            DataTable tblDados = null;

            tblDados = new DataTable();

            try
            {
                Geral = new DadosSistema();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@OPERACAO";
                parParameter[0].SqlDbType = SqlDbType.Char;
                parParameter[0].SqlValue = "Q";

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@REGISTRO";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = 1;

                tblDados = Geral.getDadosTable(parParameter, "FUNCIONARIO_CARGO");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDados;
        }


        public static DataTable recuperarTodosFiltro(string filtro)
        {
            DadosSistema Geral = null;
            DataTable tblDados = null;

            tblDados = new DataTable();

            try
            {
                Geral = new DadosSistema();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@OPERACAO";
                parParameter[0].SqlDbType = SqlDbType.Char;
                parParameter[0].SqlValue = "P";

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@NOME";
                parParameter[1].SqlDbType = SqlDbType.Text;
                parParameter[1].SqlValue = filtro;

                tblDados = Geral.getDadosTable(parParameter, "FUNCIONARIO_P");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDados;

        }
        

        public static DataTable recuperarSenha(string login, string senha)
        {
            DadosSistema Geral = null;
            DataTable tblDados = null;

            tblDados = new DataTable();

            try
            {
                Geral = new DadosSistema();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@SENHA";
                parParameter[0].SqlDbType = SqlDbType.Char;
                parParameter[0].SqlValue = senha;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@REGISTRO";
                parParameter[1].SqlDbType = SqlDbType.Char;
                parParameter[1].SqlValue = login;

                tblDados = Geral.getDadosTable(parParameter, "FUNCIONARIO_SENHA");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDados;
        }
        

    }
}
