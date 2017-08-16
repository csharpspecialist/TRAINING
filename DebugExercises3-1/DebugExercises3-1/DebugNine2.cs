// Creates a Breakfast class
// and instantiates an object
// Displays Breakfast special information
using static System.Console;
class FixedDebugNine2
{
  public static void NineTwo()
   {
      Breakfast special = new Breakfast("French toast", 4.99);
      //Display the info about breakfast
      WriteLine(special.INFO);
      // then display today's special
      WriteLine("Today we are having {0} for {1}",
         special.Name, special.Price.ToString("C2"));
        System.Console.ReadLine();
    }
}
class Breakfast
{
   public string INFO = 
      "Breakfast is the most important meal of the day.";
   private string name;
   private double price;
   // Breakfast constructor requires a
   // name, e.g "French toast", and a price
   public Breakfast(string name, double price)
   {
       Name = name;
        price = Price;
   }
   public string Name { get; set; }
   public double Price { get; set; }

}