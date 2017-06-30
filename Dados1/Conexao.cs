using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Conexao
    {
        private SqlConnection con { get; set; }
        private string cadeiaConexao()
        {
            return @"Data Source=RICK-PC\SQLEXPRESSSERVER;Initial Catalog=SetorRH;Integrated Security=True";

        }

        public SqlConnection getConnection()
        {
            try
            {
                con = new SqlConnection(cadeiaConexao());
                con.Open();
                return con;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void encerraConexao()
        {
            if (this.con != null)
            {
                this.con.Close();
            }
        }
    }
}
