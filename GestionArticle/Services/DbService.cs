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

            Command cmd = new Command("SELECT * FROM Articles");

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
        public Article GetById(int id)
        {
            Connection c = new Connection(_connectionString);
            Command cmd = new Command("Select * FROM Articles WHERE Id = @id");
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
            }).FirstOrDefault();
        }

        public void Create(Article a)
        {
            Connection c = new Connection(_connectionString);

            Command cmd = new Command("AddArticle", true);

            cmd.AddParameter("Name", a.Name);
            cmd.AddParameter("Description", a.Description);
            cmd.AddParameter("EAN13", a.EAN13);
            cmd.AddParameter("Price", a.Price);

            c.ExecuteNonQuery(cmd);
        }
        public void Delete(int Id)
        {
            Connection c = new Connection(_connectionString);
            Command cmd = new Command("DeleteArticle", true);

            cmd.AddParameter("Id", @Id);

            c.ExecuteNonQuery(cmd);
        }
    }
}
