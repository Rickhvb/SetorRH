using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DadosSistema
    {

        SqlConnection cnnConexao = null;
        SqlCommand cmdComando = null;
        SqlDataAdapter daAdaptador = null;
        DataTable Dtt = null;
        string strConexao = string.Empty;

        
        public DataTable getDadosTable(SqlParameter[] parParametros, string nomeProcedimento)
        {
            Dtt = null;
            try
            {
                Dtt = new DataTable();
                cnnConexao = new SqlConnection(strConexao);
                cmdComando = new SqlCommand();//(parTSQL, cnnConexion);
                cmdComando.Connection = cnnConexao;
                cmdComando.CommandType = CommandType.StoredProcedure;
                cmdComando.CommandText = nomeProcedimento;
                cmdComando.Parameters.AddRange(parParametros);
                daAdaptador = new SqlDataAdapter(cmdComando);
                daAdaptador.Fill(Dtt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnnConexao.Dispose();
                cmdComando.Dispose();
                daAdaptador.Dispose();
            }
            return Dtt;
        }
        

        public DadosSistema()
        {
            strConexao = @"Data Source=RICK-PC\SQLEXPRESSSERVER;Initial Catalog=SetorRH;Integrated Security=True";

        }



        public void Executar(string nomeProcedimento, string[] nomeParametros, params Object[] ValParametros)
        {
            
            try
            {
                cnnConexao = new SqlConnection(strConexao);
                SqlCommand cmdComando = new SqlCommand(nomeProcedimento, cnnConexao);
                
                cnnConexao.Open();
                cmdComando.Connection = cnnConexao;
                cmdComando.CommandType = CommandType.StoredProcedure;
                if (nomeProcedimento.Length != 0
                && nomeParametros.Length == ValParametros.Length)
                {
                    int i = 0;
                    foreach (string parametro in nomeParametros)
                        cmdComando.Parameters.AddWithValue(parametro, ValParametros[i++]);
                    cmdComando.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                cnnConexao.Dispose();
                cmdComando.Dispose();

            }

        }


    }
}
