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
            return @"Data Source=localhost;Initial Catalog = SetorRH; User Id= Rick-PC\Rick; Password=";

        }

        public SqlConnection getConnection()
        {
            try
            {
                con = new SqlConnection(cadeiaConexao());
                this.con.Open();
                return this.con;
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
