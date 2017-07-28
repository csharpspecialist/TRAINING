// Finds whether a book dealer carries a requested book
using System;
using static System.Console;
class DebugSix03
{
   public static void SixThree()
   {
      String[] books = {"Catch-22", "Harry Potter",
         "Programming Using C#", "Rich Dad, Poor Dad",
         "The Deep", "Wizard of Oz"};
      int x;
      string entryString;
      Write("What book are you looking for? ");
      entryString = ReadLine();//fixed the readline to ReadLine
      x = Array.BinarySearch(books, entryString); //added the ,entrystring
      if(x < 0)
         WriteLine("{0} not found", entryString);// changed entry to entrystring
      else
         WriteLine("Yes, we carry {0}", entryString);  // changed entry to entrystring  
        ReadLine(); //added readline 
    }
}
