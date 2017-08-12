using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoMobile a = new AutoMobile();
            AutoMobile a1 = new AutoMobile();
            
            a1.AutoID = 1000;
            a1.Make = "Chevy";
            a1.Model = "Corvette";
            a1.Year = 2009;
            a1.Color = "Red";
            a1.ShoeColor = false;

            AutoMobile a2 = new AutoMobile();

            a2.AutoID = 2000;
            a2.Make = "Ford";
            a2.Model = "Explorer";
            a2.Year = 2012;
            a2.Color = "Black";
            a2.ShoeColor = true;

            List<AutoMobile> carList = new List<AutoMobile>();
            
            carList.Add(a1);
            carList.Add(a2);

            foreach (AutoMobile item in carList)
            {
                Console.WriteLine($"Our Id is {item.AutoID}, made by {item.Make}, in the year {item.Year}, Model type of {item.Model} with the color is {item.Color}");

                item.DisplayItems();

            }

            Console.ReadLine();

            foreach (AutoMobile item in carList)
            {
               if(item.Make == "Ford")
                {
                    Console.WriteLine($"We found the {item.Model} ");
                }
                Console.ReadLine();
            }
            
            foreach (AutoMobile item in carList)
            {
               if(item.ShoeColor ==false)
                {
                    Console.WriteLine($"We found the {item.Model} ");
                }
                Console.ReadLine();
            }

        }
    }

  


}
