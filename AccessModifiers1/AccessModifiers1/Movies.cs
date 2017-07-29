using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers1
{
    class Movies
    {
        Program p = new Program();
        
        public void Genre()
        {
            //Program p = new Program();      
           double divNumber = Program.DivideNumber(2,5);             

            Console.WriteLine("Horror");
            Console.WriteLine("Action");
        }

    }




}
