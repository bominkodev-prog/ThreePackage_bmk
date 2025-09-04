using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.ConsoleApp
{
    public class DapperService
    {
        SqlConnectionStringBuilder sql = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "bobo",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true
        };

    public void Read()
        {
           
           using IDbConnection db = new SqlConnection(sql.ConnectionString);
            db.Open();
            List<BookList> list =  db.Query<BookList>("select * from books where IsAvailable = 0").ToList();
            foreach (BookList book in list)
            {
                Console.WriteLine($"{book.Identity} - {book.Title} - {book.Author} - {book.ISBM} - {book.Genre} - {book.Price}");
            }

        }
    public void Write()
        {
            using IDbConnection db = new SqlConnection(sql.ConnectionString);
            db.Open();
           int result = db.Execute(@"INSERT INTO Books (Title, Author, ISBM, PublishYear, Genre, Price, StockCount,IsAvailable)
VALUES
('The Pragmatic Programmer', 'Andrew Hunt', '978-0201616224', 1999, 'Programming', 45.50, 10,0),
('Clean Code', 'Robert C. Martin', '978-0132350884', 2008, 'Programming', 50.00, 7,0),
('Atomic Habits', 'James Clear', '978-0735211292', 2018, 'Self-Help', 25.00, 15,0);");
            
            Console.WriteLine(result > 0 ? "creating successed" : "crating failed");
        }

    public void Update()
        {
            using IDbConnection db = new SqlConnection( sql.ConnectionString);
            db.Open();
            int result = db.Execute(@" UPDATE [dbo].[Books]
            SET [Title] = 'How to be happy '
     
             WHERE [Identity] = 3");
            Console.WriteLine(result > 0 ? "updating successed" : "updating failed");


        }
    public void Delete()
        {
            using IDbConnection db = new SqlConnection(sql.ConnectionString);
            db.Open();
            int result = db.Execute(@"UPDATE [dbo].[Books]
                   SET [IsAvailable] = 1
     
                 WHERE [Identity] = 4");
            Console.WriteLine(result > 0 ? "deleting successed" : "deleting failed");
        }
    }
}
