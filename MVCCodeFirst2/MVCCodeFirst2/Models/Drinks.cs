using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MVCCodeFirst2.Models
{
    public class Drinks
    {
        [Key]

        public int DrinkID { get; set; }
        [Display(Name = "Name of Drink")]

        public string DrinkName
        {
            get;
            set;
        }

        [Display(Name = "Type Of Glass")]
        public string DrinkGlass { get; set; }

        [Display(Name = "Type of Drink")]
        public string DrinkGenre { get; set; }

        public decimal Price { get; set; }



    }


    public class MenuDBContext : DbContext
    {
        public DbSet<Drinks> Booze { get; set; }
    }

}
