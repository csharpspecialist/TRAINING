using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //must add in this classes
using System.Data.Entity; //must add in this  class!!!

namespace EntityDbaseFirst
{
    public class Book // must be public or squiggly @ dbset book books!!!
    {

        public string Title { get; set; }
        public string Author { get; set; }
        [Key]
        public int Code { get; set; }


    }


    public class BookContext : DbContext
    {


        public DbSet<Book> Books { get; set; }
    }

}
