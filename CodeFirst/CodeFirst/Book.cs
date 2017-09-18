using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CodeFirst
{
   public class Book
    {

        public string Title { get; set; }
        public string Author { get; set; }
        [Key]
        public int Code { get; set; }

    }

    public class BookContext : DbContext
    {

        public DbSet <Book> Books { get; set; }
    }



}
