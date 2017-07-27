// How much money will you have
// after 30 days if you get a penny on the
// first day and it doubles every day?
using System;
using static System.Console;
class DebugFive4
{
   public static void FiveFour()
   {




      const double LIMIT = 1000000.00;
      const double START = 0.01;
      string inputString;
      double total;
      int howMany;
      int count;
      Write("How many days do you think ");
      WriteLine("it will take you to reach");
      Write("{0} starting with {1}",  // added a curly brace after the 0
         LIMIT.ToString("C"), START.ToString("C")); //change C to "C"
      WriteLine("and doubling it every day?");
      inputString = ReadLine();
      howMany = Convert.ToInt32(inputString);
      count = 0;
     total = START;
      while(total < LIMIT) //changed to != from ==
      {
         total = total * 2;   //change = to *=
           count ++;                 //count = count + 1;   
        }
      if(howMany >= count)
         WriteLine($"Your guess of {count} was too high.");
      else
        if(howMany <= count) // change from =< to <=
           WriteLine("Your guess was too low.");
        else
           WriteLine("Your guess was correct.");
      WriteLine("It takes {0} days to reach {1}", //changed 0 to {0}
         count, LIMIT.ToString("C"));
      WriteLine("when you double {0} every day",
         START.ToString("C"));
        Console.ReadLine(); //added a readline

        WriteLine("Would u like to startover??");
        string begin = ReadLine().ToUpper();

        if(begin == "Y")
        {
            FiveFour();
        }
        else
        {
            Environment.Exit(0);
        }
   }
}

