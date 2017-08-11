using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Extra
{
  public class Begin
    {
        static void Main(string[] args)
        {
            int complete;
            Console.WriteLine("Hello...its Friday!!!");
            Durango dr = new Durango();

            complete = dr.PerformAddition(80,100);

            Console.WriteLine(complete);
            Console.ReadLine();
        }
        

    }

    public class Durango
    {
       
        public void Boxer()
        {
            Console.WriteLine("We Work to be the best programmers in the world");

        }

        public int PerformAddition(int x, int y)
        {
            
            return x + y;
        }

      

    }


}
