namespace MVCAddColumnToDbase.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCAddColumnToDbase.Models.MotorcycleDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCAddColumnToDbase.Models.MotorcycleDBContext context)
        {
            context.Bikes.AddOrUpdate(i => i.Manufacturer,
                new Motorcycle
                {
                    Manufacturer = "Suzuki",
                    ReleaseDate = DateTime.Parse("2003-11-09"),
                    Style = "Gsxr 1000",
                    Price = 7.99M
                },

                new Motorcycle
                {
                    Manufacturer = "Honda",
                    ReleaseDate = DateTime.Parse("2003-11-09"),
                    Style = "CBR",
                    Price = 7.99M
                },

               new Motorcycle
               {
                   Manufacturer = "Kawasaki",
                   ReleaseDate = DateTime.Parse("2003-11-09"),
                   Style = "Ninja",
                   Price = 7.99M
               }
           );

        }
    }
}
