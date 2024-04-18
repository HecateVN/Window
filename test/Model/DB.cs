using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace test.Model
{
    class DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        // get the connection
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
        // close the connection
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }

        }
        //public async Task<List<Job>> GetJobAsync(int page, int pagesize)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(con.ConnectionString))
        //    {
        //        var products = await connection.QueryAsync<Job>($"Select Companyname,Location,JobPosition,Salary,JobDescription from " +
        //            $"JobDetail ORDER BY Location OFFSET " + page + "*" + pagesize + " ROWS FETCH NEXT " + pagesize + " ROWS ONLY;");
        //        return products.AsList();
        //    }
        //}

        public async Task<List<Job>> GetJobAsync(int page, int pagesize)
        {
            List<Job> products = new List<Job>();
            try
            {
                using (SqlConnection connection = new SqlConnection(con.ConnectionString))
                {
                    await connection.OpenAsync();
                    string query = "SELECT Companyname, Location, JobPosition, Salary, JobDescription FROM JobDetail ORDER BY Location";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Define parameters used in your SQL query
                        command.Parameters.AddWithValue("@Page", page * pagesize);
                        command.Parameters.AddWithValue("@PageSize", pagesize);

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                Job job = new Job()
                                {
                                    // Assuming your Job object has properties that match your SQL query
                                    Companyname = reader["Companyname"].ToString(),
                                    Location = reader["Location"].ToString(),
                                    JobPosition = reader["JobPosition"].ToString(),
                                    Salary = reader["Salary"].ToString(),
                                    JobDescription = reader["JobDescription"].ToString(),
                                };
                                products.Add(job);
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return products;
        }


    }
}
