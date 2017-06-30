using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using System.Data.SqlClient;

namespace Controlador
{
    public class clsFalta
    {

        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        private int duracao;

        public int Duracao
        {
            get { return duracao; }
            set { duracao = value; }
        }

        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private int funcionario;

        public int Funcionario
        {
            get { return funcionario; }
            set { funcionario = value; }
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
                parParameter[0].SqlValue = "T";

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

        public void Salvar(clsFalta falta)
        {
            DadosSistema dados = new DadosSistema();
            string[] parametros = {
                                    "@OPERACAO",
                                    "@NUMERO_REGISTRO",
                                    "@TIPO",
                                    "@DURACAO",
                                    "@DATA"
            }; try
            {
                dados.Executar("FALTA_I_A", parametros, "I",
                                       falta.funcionario, falta.tipo, falta.duracao, falta.data);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable Setores()
        {

            DadosSistema Geral = null;
            DataTable tblDados = null;

            tblDados = new DataTable();

            try
            {
                Geral = new DadosSistema();

                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@OPERACAO";
                parParameter[0].SqlDbType = SqlDbType.Char;
                parParameter[0].SqlValue = "SETOR";
                tblDados = Geral.getDadosTable(parParameter, "SETOR_LISTA");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDados;
        }

        public static DataTable Funcionarios()
        {

            DadosSistema Geral = null;
            DataTable tblDados = null;

            tblDados = new DataTable();

            try
            {
                Geral = new DadosSistema();

                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@OPERACAO";
                parParameter[0].SqlDbType = SqlDbType.Char;
                parParameter[0].SqlValue = "FUNCIONARIOS";
                tblDados = Geral.getDadosTable(parParameter, "SETOR_LISTA");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDados;
        }

        public  DataTable FuncionarioRelatorio(DateTime data1, DateTime data2, string tipo, string operacao)
        {

            DadosSistema Geral = null;
            DataTable tblDados = null;

            tblDados = new DataTable();

            try
            {
                Geral = new DadosSistema();

                SqlParameter[] parParameter = new SqlParameter[4];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@OPERACAO";
                parParameter[0].SqlDbType = SqlDbType.Char;
                parParameter[0].SqlValue = operacao;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@DATA1";
                parParameter[1].SqlDbType = SqlDbType.DateTime;
                parParameter[1].SqlValue = data1;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@DATA2";
                parParameter[2].SqlDbType = SqlDbType.DateTime;
                parParameter[2].SqlValue = data2;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@TIPO";
                parParameter[3].SqlDbType = SqlDbType.Char;
                parParameter[3].SqlValue = tipo;
                tblDados = Geral.getDadosTable(parParameter, "RELATORIO");

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
                parParameter[0].SqlValue = "Q";

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
    }
}
