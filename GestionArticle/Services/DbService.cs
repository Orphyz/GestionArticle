using GestionArticle.Models;
using ClassLibrary;
using System.Data.SqlClient;

namespace GestionArticle.Services
{
    public class DbService
    {
        private string _connectionString = @"Data Source=DESKTOP-TURPQQ3\MSSQLSERVER1;Initial Catalog=Dbproduits;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    
        public IEnumerable<Article> GetAll()
        {
            Connection c = new Connection(_connectionString);

            Command cmd = new Command("SELECT * FROM Article");

            return c.ExecuteReader(cmd, (SqlDataReader reader) =>
            {
                return new Article
                {
                    Id = (int)reader["Id"],
                    Name = reader["Name"].ToString(),
                    Price = (double)reader["Price"],
                    Description = reader["Description"].ToString(),
                    EAN13 = reader["EAN13"].ToString()
                };
            });
        }

        public void Create(Article a)
        {
            Connection c = new Connection(_connectionString);

            Command cmd = new Command("AddArticle", true);

            cmd.AddParameter("Name", a.Name);
        }
    }
}
