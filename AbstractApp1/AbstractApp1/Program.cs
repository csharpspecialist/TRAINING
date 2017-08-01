using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApp1
{
    
    public class Program 
    {
        static void Main(string[] args)
        {
        }
    }

    public abstract class Customer 
    {
        //can only be used as base classes.
        //cannot have implementation here!!!! only declaration!!
        public abstract void Ordering();


    }




        //since the testing class is marked abstract then 
        // it does not have to provide implementation for 
        // the Customer class. this class must be public!!!
    public abstract class Testing : Customer
    {

    }

    public class Worker : Customer
    {
        //this must override the ordering method in customer class
        //to provide to compile and work properly!!! 
        public override void Ordering() 
        {
            Console.WriteLine("We r working over here");
        }

        

    }
    


}
