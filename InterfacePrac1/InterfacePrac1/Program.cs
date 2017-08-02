using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePrac1
{
    //IWork & ICustomer each have 1 class member!!!
    //declared at namespace level!!!!
    //outside of any/all classes!!!
    //so any class inside of namespace can inherit them
    interface ICustomer
    {
        void Print();
  
    }


    interface IWork
    {

        void Write();
    }


    //since we inherit from both Icustomer and Iwork
    //the u must implement all the methods of both Interfaces (2)!!
    public class Customer : ICustomer, IWork
    {
       public void Print()
        {
            Console.WriteLine("Good Times!!!");
        }

        public void Write()
        {
            Console.WriteLine("Getting Somewhere");
        }


    }



    class Program
    {
        static void Main(string[] args)
        {

            Customer c = new Customer();
            Console.WriteLine("Working over here!!!");
            c.Print();
            c.Write();

            Console.ReadLine();


        }
    }



}
