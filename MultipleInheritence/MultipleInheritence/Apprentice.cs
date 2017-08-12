using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MultipleInheritence
{
   public class Apprentice : Master
    {        
        
      public void Display()
        {

            Apprentice a1 = new Apprentice
            {
                ID = 1000,
                Name = "Peter Parker",
                Address = "2525 Hero Dr"

            };

            Apprentice a2 = new Apprentice
            {
                ID = 1002,
                Name = "Thor",
                Address = "Asgard dr"

            };

            Apprentice a3 = new Apprentice();
           

            

            List<Apprentice> heros = new List<Apprentice>();

            heros.Add(a1);
            heros.Add(a2);

            foreach (var item in heros)
            {

                Console.WriteLine($"I am hero # {item.ID} and my name is {item.Name} + my address is {item.Address}");


            }

          //  Console.ReadLine();

        }
           
    }

   


}
