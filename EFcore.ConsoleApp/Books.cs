using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore.ConsoleApp
{
    public class Books
    {
        [Key]
        public int Identity { get; set; }   // Primary Key
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBM { get; set; }   // (typo in SQL? usually ISBN)
        public string PublishYear { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public int StockCount { get; set; }
        public bool? IsAvailable { get; set; }
    }
}
