// Program prompts user for any number of values 
// (up to 20)
// and averages them
using System;
using static System.Console;
class DebugSix04
{
   public static void SixFour()
   {
      const int QUIT = 999;
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int x = 0;
      int num;
      double average = 0;
      double total = 0;
      string inString;
      Console.Write("Please enter a number or " +
         QUIT + " to quit...");
      inString = ReadLine();
      num = Convert.ToInt32(inString);
      while((x < numbers.Length) && num != QUIT)
      {
 	  numbers[x] = num;
          total += numbers[x];
          ++x;
          Write("Please enter a number or " +
             QUIT + " to quit...");
          inString = ReadLine();
          num = Convert.ToInt32(inString);
      }
       // double sum = 0;
      WriteLine("The numbers are:");
        for (int y = 0; y < x; ++x)
        {
            Console.Write("{0,6}", numbers[y]);
           // sum += total;
            average = total / x;
        }
      WriteLine();
      WriteLine("The average is {0}", average);

  }
}
