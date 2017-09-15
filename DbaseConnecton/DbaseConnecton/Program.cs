﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DbaseConnecton
{
    class Program
    {
        static void Main(string[] args)
        {


            using (var db = new BookContext())
            {
                Book book1 = new Book
                {
                    Title = "Beginning Visual C# 2015",
                    Author = "Perkins, Reid, and Hammer"
                };
                db.Books.Add(book1);
                Book book2 = new Book
                {
                    Title = "Beginning XML",
                    Author = "Fawcett, Quin, and Ayers"
                };
                db.Books.Add(book2);


                var store1 = new Store
                {
                    Name = "Main St Books",
                    Address = "123 Main St",
                    Inventory = new List<Stock>()
                };
                db.Stores.Add(store1);
                Stock store1book1 = new Stock
                { Item = book1, OnHand = 4, OnOrder = 6 };
                store1.Inventory.Add(store1book1);
                Stock store1book2 = new Stock
                { Item = book2, OnHand = 1, OnOrder = 9 };
                store1.Inventory.Add(store1book2);

                var store2 = new Store
                {
                    Name = "Campus Books",
                    Address = "321 College Ave",
                    Inventory = new List<Stock>()
                };
                db.Stores.Add(store2);
                Stock store2book1 = new Stock
                { Item = book1, OnHand = 7, OnOrder = 23 };
                store2.Inventory.Add(store2book1);
                Stock store2book2 = new Stock
                { Item = book2, OnHand = 2, OnOrder = 8 };
                store2.Inventory.Add(store2book2);

                db.SaveChanges();

                var query = from store in db.Stores
                            orderby store.Name
                            select store;



                WriteLine("Bookstore Inventory Report:");
                foreach (var store in query)
                {
                    WriteLine($"{store.Name} located at { store.Address}");
                foreach (Stock stock in store.Inventory)
                    {
                        WriteLine($"- Title: {stock.Item.Title}");
                        WriteLine($"-- Copies in Store: { stock.OnHand}");
                WriteLine($"-- Copies on Order:{ stock.OnOrder} ");
                    }
                }
                WriteLine("Press a key to exit…");
                ReadKey();

            }           


        }
    }
}
