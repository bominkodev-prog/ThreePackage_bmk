using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore.ConsoleApp
{
    public class BookService
    {
        public void Read()
        {
            AppDbContext app = new AppDbContext();
            List<Books> lst = app.Books.ToList();

           foreach (Books book in lst)
            {
                Console.WriteLine($"{book.Identity} - {book.Title} - {book.Author} {book.ISBM} {book.Genre} {book.Price} - {book.StockCount}");
            }
        }
        public void Write()
        {

            AppDbContext app = new AppDbContext();
            Books book = new Books()
            {
                Title = "C# in Depth",
                Author = "Jon Skeet",
                ISBM = "123-456789",
                PublishYear = "2019",
                Genre = "Programming",
                Price = 45.99m,
                StockCount = 10,
                IsAvailable = false
            };
            app.Books.Add(book);
            int result = app.SaveChanges();
            Console.WriteLine(result > 0 ? "Book added successfully!" : "Insert failed.");


        }

        public void Update()
        {
            AppDbContext app = new AppDbContext();
            Books? editbooks = app.Books.Where(x=> x.Identity == 4).FirstOrDefault();
            if(editbooks != null)
            {
                editbooks.Price = 210;
                app.SaveChanges();
            }


        }
        public void Delete()
        {
            AppDbContext app = new AppDbContext();
            Books? editbooks = app.Books.Where(x => x.Identity == 5).FirstOrDefault();
            if (editbooks != null)
            {
                editbooks.IsAvailable = true;
                app.SaveChanges();
            }
        }
    }
}
