using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Data.Entity;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BookContext())
            {
                Book book1 = new Book
                {
                    Title = "Hero Guide for Heros",
                    Author = "Great Gatsby"

                };
                db.Books.Add(book1);

                Book book2 = new Book
                {
                    Title = "Good Food in Cleveland",
                    Author = "Hungry People"

                };
                db.Books.Add(book2);
                db.SaveChanges();

                var query = from b in db.Books
                            orderby b.Title
                            select b;



                WriteLine("All Books in the Dbase:");
                foreach (var b in query)
                {
                    WriteLine($" { b.Title} by { b.Author}, code= {b.Code}    ");
                }
                WriteLine("Press any key to exit");
                Console.ReadLine();
            }


        }
    }
}
