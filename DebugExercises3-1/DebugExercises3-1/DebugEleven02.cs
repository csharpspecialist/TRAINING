// Prevents non-numeric data entry
// Then prevents division by 0
using System;
using static System.Console;
class DebugEleven02
{
    public static void ElevenTwo() //ch to public +
    {
      int num = 0, denom = 0;
      double result;
      bool dataEntryIsValid = false;//set to false


      while(!dataEntryIsValid)
      {
         try
         {
            DataEntry(out num, out denom);//add out 2 times
            dataEntryIsValid = true;
         }
         catch(FormatException e)
         {
            WriteLine("Invalid entry - please enter numbers");
                Console.WriteLine(e.Message.ToString());
         }
      }
      try 
      {
         result = num * 1.0 / denom;
         WriteLine("Division is successful \n We R Good");
      }
      catch(DivideByZeroException e)
      {
            WriteLine("Division failed"); //add ;
            Console.WriteLine(e.Message.ToString());
         result = 0;
      }
      WriteLine("Result is {0}", result);
        Console.ReadLine();
    }
   public static void DataEntry(out int num, out int denom)
   {
      Write("Enter a number ");
      if(!int.TryParse(ReadLine(), out num))
         Console.WriteLine("Numerator was set to 0");
      Write("Enter a number to divide into the first ");
      if(int.TryParse(ReadLine(), out denom))
         WriteLine("Denominator was set to 0");
       
    }
}
