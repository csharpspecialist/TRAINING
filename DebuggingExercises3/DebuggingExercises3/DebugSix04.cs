// Program prompts user for any number of values 
// (up to 20)
// and averages them
using System;
using static System.Console;
class DebugSix04
{
   public static void SixFour()
   {
        //probably need to keep z in line 39.  use z to sum the 
        //array using  sum += numbers[y]; put this on line 37
        const int QUIT = 999;
        int[] numbers = new int [20];
        //int[] numbers = {10,20,30,40,50,60,70,80,90,100 };
        int x = 1; //assigned val to x so line 21 squiq stopped
      int num;
      double average;
      double total = 0;
      string inString;
      Console.Write("Please enter a number or " +
         QUIT + " to quit...");
      inString = ReadLine();
      num = Convert.ToInt32(inString);//changed ToInt to ToInt32
      while((num > numbers.Length) || num == QUIT)//ch to || from &&
      {
            if(num == QUIT)
            {
                Console.WriteLine("Goodbye Now \n Press any key to exit");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            numbers[x] = num;
          total += numbers[x];
          ++x;
          Write("Please enter a number or " +
             QUIT + " to quit...");
          inString = ReadLine();
          num = Convert.ToInt32(inString);
      }

        WriteLine("The numbers are:");
        for (int y = 0; y < x; ++x)//ch the ++x to ++y
        {  //added curly brace here
            Console.Write("{0,6}", numbers[x]);
            total += numbers[y];
        }//added curly brace here
        average = total / x; //ch from z to x
        WriteLine();
        WriteLine("The average is {0}", average); //ch avge to average + added )






        //WriteLine("The numbers are:");
        //  for (int y = 0; y < x; ++y)//ch the ++x to ++y
        //  {  //added curly brace here
        //      Console.Write("{0,6}", numbers[y]);
        //      total += numbers[y];
        //  }//added curly brace here
        //  average = total / x; //ch from z to x
        //WriteLine();
        //WriteLine("The average is {0}", average); //ch avge to average + added )
    }
}
