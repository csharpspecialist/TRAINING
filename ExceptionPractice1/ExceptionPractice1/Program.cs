using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int milesDriven;
            int gallonsOfGas;
            int mpg;

            Program p = new Program();
            p.StringError();
            p.NewError();
            p.ArrayError();
     
            try
            { 
            Console.WriteLine("Enter miles driven");
            milesDriven = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter gallon of gas purchased");
            gallonsOfGas = Convert.ToInt16(Console.ReadLine());

            mpg = milesDriven / gallonsOfGas;
            Console.WriteLine($"you are getting {mpg} miles per gallon");
            Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("there was an div by zero exception");
            }
            Console.WriteLine("Our code blew up...but we r still running...YES");
            Console.ReadLine();  
            
        }

        public void ArrayError()
        {

            try
            {
                int num = 12, denom = 0, result;
                int[] numArray = { 20, 30, 40 };

              //  result = num / denom;
                result = numArray[num];
            }
            catch(DivideByZeroException er)
            {
                Console.WriteLine(er.Message);
            }
            catch(IndexOutOfRangeException i)
            {
                Console.WriteLine("You broke our array program");
                Console.WriteLine(i.Message);
            }

            Console.WriteLine("We r still running");
            Console.ReadLine();
            
        }

        public void NewError()
        {
            try
            {
                int firstNum = 20, secondNum = 0, answer;

                answer = firstNum / secondNum;
                Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("our code had an error..but we don't know what happened");

            }
            finally //runs no matter what!!!!
            {
                Console.WriteLine("");
                Console.Clear();
            }
            Console.ReadLine();
            
        }
        public void StringError()
        {
            
            try
            {
                          
            int x = 100, y = 0, done;

            done = x / y;
            }
            catch(Exception ex)
            {
                NewError();
                Console.WriteLine(ex.ToString());
                Console.WriteLine("we r inside the to string exception");
            }

            Console.WriteLine("Our code kept going!!!!");
            Console.ReadLine();



        }


        public void NewMethod()
        {


            int[] numbers = { 2, 5, 8, 9 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();


        }

        ~Program()
        {
        }





       


    }
}
