using System;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace test.Model
{
    class DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public async Task<List<Job>> GetJobAsync(int page, int pagesize)
        {
            SqlConnection conn = new SqlConnection();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(conn.ConnectionString))
            {
                var products = await connection.QueryAsync<Job>($"Select Companyname,Location,JobPosition,Salary,JobDescription from " +
                    $"JobDetail ORDER BY JobId OFFSET " + page + "*" + pagesize + " ROWS FETCH NEXT " + pagesize + " ROWS ONLY;");
                return products.AsList();
            }
        }
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        // open the connection
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }
      
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }

        } 
    }
}
