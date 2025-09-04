using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ThreePackages.ConsoleApp
{
    public class AdoDotnet
    {

        SqlConnectionStringBuilder sql = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "bobo",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate= true
        };

      public void Read()
        {
            SqlConnection con = new SqlConnection(sql.ConnectionString);
            con.Open();
            string query = @"
                            SELECT [Identity]
                                  ,[Title]
                                  ,[Author]
                                  ,[ISBM]
                                  ,[PublishYear]
                                  ,[Genre]
                                  ,[Price]
                                  ,[StockCount]
                                  ,[IsAvailable]
                              FROM [dbo].[Books] where IsAvailable = 0 ";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                Console.WriteLine($"{dr["Identity"]} - {dr["Title"]} - {dr["Author"]} - {dr["ISBM"]} - {dr["PublishYear"]} - {dr["Genre"]} - {dr["Price"]} - {dr["StockCount"]}");
                Console.WriteLine();
            }

        }
        public void Write()
        {
            SqlConnection con = new SqlConnection(sql.ConnectionString);
            con.Open();
            string queryinsert = @"INSERT INTO Books (Title, Author, ISBM, PublishYear, Genre, Price, StockCount,IsAvailable)
VALUES
('The Pragmatic Programmer', 'Andrew Hunt', '978-0201616224', 1999, 'Programming', 45.50, 10,0),
('Clean Code', 'Robert C. Martin', '978-0132350884', 2008, 'Programming', 50.00, 7,0),
('Atomic Habits', 'James Clear', '978-0735211292', 2018, 'Self-Help', 25.00, 15,0);
";
            SqlCommand cmd = new SqlCommand(queryinsert, con);
            int result = cmd.ExecuteNonQuery();
            Console.WriteLine(result > 0 ? "creating successed" : "crating failed");
        }
        public void Update()
        {
            SqlConnection con = new SqlConnection(sql.ConnectionString);
            con.Open();
            string queryupdate = @"
            UPDATE [dbo].[Books]
            SET [Title] = 'How to be rich '
     
             WHERE [Identity] = 2";
            SqlCommand cmd = new SqlCommand(queryupdate,con);
            int result = cmd.ExecuteNonQuery();
            Console.WriteLine(result > 0 ? "updating successed" : "updating failed");

        }
        public void Delete()
        {
            SqlConnection con = new SqlConnection(sql.ConnectionString);
            con.Open();
            string querydelete = @"
                UPDATE [dbo].[Books]
                   SET [IsAvailable] = 1
     
                 WHERE [Identity] = 3";
            SqlCommand cmd = new SqlCommand(querydelete,con);
            int result = cmd.ExecuteNonQuery();
            Console.WriteLine(result > 0 ? "deleting successed" : "deleting failed");

        }

    }
}
