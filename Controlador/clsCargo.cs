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
    public class clsCargo
    {

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public clsCargo() { }

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
                parParameter[1].ParameterName = "@NUMERO";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = 1;

                tblDados = Geral.getDadosTable(parParameter, "CARGO_S_D");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDados;
        }

        public void Salvar (clsCargo cargo)
        {
            DadosSistema dados = new DadosSistema();
        string[] parametros = {
                                    "@OPERACAO",
                                    "@NUMERO",
                                    "@NOME"
            };try
            {
                dados.Executar("CARGO_I_A", parametros, "I",
                                       cargo.numero, cargo.nome);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(clsCargo cargo)
        {
            DadosSistema dados = new DadosSistema();
            string[] parametros = {
                                    "@OPERACAO",
                                    "@NUMERO",
                                    "@NOME"
            }; try
            {
                dados.Executar("CARGO_I_A", parametros, "A",
                                       cargo.numero, cargo.nome);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Excluir(clsCargo cargo)
        {
            DadosSistema dados = new DadosSistema();
            string[] parametros = {
                                    "@OPERACAO",
                                    "@NUMERO"
            }; try
            {
                dados.Executar("CARGO_S_D", parametros, "E",
                                       cargo.numero);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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

                tblDados = Geral.getDadosTable(parParameter, "CARGO_P");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return tblDados;

        }
        
        
    }
}
