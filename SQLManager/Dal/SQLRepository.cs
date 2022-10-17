using Microsoft.Extensions.Configuration;
using SQLManager.Models;
using System.Data;
using System.Data.SqlClient;

namespace SQLManager.Dal
{
    internal class SQLRepository : IRepository
    {
        private string? cs;
        private readonly string ConnectionString = Program.Configuration.GetConnectionString(nameof(ConnectionString));

        public void LogIn(string server, string username, string password)
        {
            using (SqlConnection con = new(string.Format(ConnectionString, server, username, password)))
            {
                cs = con.ConnectionString;
                con.Open();
            }
        }

        public IEnumerable<Database> GetDatabases()
        {
            using (SqlConnection con = new(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = Program.Configuration.GetValue<string>("Queries:SelectDatabases");
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new Database
                            {
                                Name = dr[nameof(Database.Name)].ToString()
                            };
                        }
                    }
                }
            }
        }

        public dynamic ExecuteQuery(Database database, string query)
        {
            string useDbQuery = Program.Configuration.GetValue<string>("Queries:UseDatabase");
            string useDatabase = string.Format(useDbQuery, database.Name);

            using (SqlConnection con = new(cs))
            {
                if (query.ToLower().Contains("select"))
                {
                    SqlDataAdapter da = new(useDatabase + Environment.NewLine + query, con);
                    DataSet ds = new();
                    da.Fill(ds);
                    return ds.Tables[0];
                }
                else
                {
                    SqlCommand cmd = new(useDatabase + Environment.NewLine + query, con);
                    cmd.Connection.Open();
                    return $"{cmd.ExecuteNonQuery()} row/s affected";
                }
            }
        }
    }
}
