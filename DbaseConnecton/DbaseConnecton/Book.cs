using System;
using static System.Console; //added
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; //added
using System.ComponentModel.DataAnnotations; //added


namespace DbaseConnecton
{
    public class Book  //must be public!!!!!
    {
        public string Title { get; set; }
        public string Author { get; set; }
        [Key]
        public int Code { get; set; }


    }


    public class Store
    {
        [Key]
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual List<Stock> Inventory { get; set; }
    }
    public class Stock
    {
        [Key]
        public int StockId { get; set; }
        public int OnHand { get; set; }
        public int OnOrder { get; set; }
        public virtual Book Item { get; set; }
    }


    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Stock> Stocks { get; set; }
    }


}
