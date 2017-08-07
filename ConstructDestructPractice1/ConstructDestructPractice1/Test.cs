using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructDestructPractice1
{
    class Test
    {
        
       

        
        //this is a constructor below...same name as the class itself
        public Test(double y)
        {
            double x = y + 5; 
            Console.WriteLine("This is the constructor talking now!!!!!");
            Console.WriteLine("");

        }
   
   
        //tilda denotes the destructor!!!
        ~Test()
        {
            System.Diagnostics.Trace.WriteLine("We r cleaning up our mess now!!!");
        }

    }
    
   
}
