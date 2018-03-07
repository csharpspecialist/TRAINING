using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCCodeFirst3.Models
{
    public class Novel
    {      
     
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }            
        public string Genre { get; set; }
        public decimal Price { get; set; }   
        
    }

    public class BooksDBContext : DbContext
    {
        public DbSet<Novel> Novels { get; set; }
    }



}