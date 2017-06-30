using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class DadosSistema
    {
        public DataTable getDadosTable(string nomeProcedimento, string[] nomeParametros, params Object[] valParametros)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            cmd.Connection = con.getConnection();
            cmd.CommandText = nomeProcedimento;
            cmd.CommandType = CommandType.StoredProcedure;
            if (nomeProcedimento.Length!=0 
                && nomeParametros.Length == valParametros.Length)
            {
                int i = 0;
                foreach (string parametro in nomeParametros)
                    cmd.Parameters.AddWithValue(parametro, valParametros[i++]);
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    return dt;
                }
                catch (Exception)
                {

                }
                
            }
            return dt;
        }

        public int Executar (string nomeProcedimento, string[] nomeParametros, params Object[] ValParametros)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.getConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            if (nomeProcedimento.Length != 0
                && nomeParametros.Length == ValParametros.Length)
            {
                int i = 0;
                foreach (string parametro in nomeParametros)
                    cmd.Parameters.AddWithValue(parametro, ValParametros[i++]);
                try
                {
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }

            }
            return 0;
        }


    }
}
