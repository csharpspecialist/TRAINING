using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using static System.Console;

namespace DatabaseRelations
{
    class Book
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


}
