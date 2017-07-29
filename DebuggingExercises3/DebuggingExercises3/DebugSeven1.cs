// Uses DisplayWebAddress method three times
using static System.Console;
class DebugSeven1
{
   public static void SevenOne()
   {
        DebugSeven1 db = new DebugSeven1(); //added to create an instance
      db.DisplayWebAddress(); //added db to call method
      WriteLine("Shop at Shopper's World");
      db.DisplayWebAddress(); //added db to call method
        WriteLine("The best bargains from around the world");
      db.DisplayWebAddress();  //added db to call method
        ReadLine();  //added so screen would not flash on/off
    }
   private void DisplayWebAddress()
   {
      WriteLine("------------------------------");
      WriteLine("Visit us on the web at:");
      WriteLine("www.shoppersworldbargains.com");
      WriteLine("******************************");
   }
}
