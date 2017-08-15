// Creates a Breakfast class
// and instantiates an object
// Displays Breakfast special information
using static System.Console;
class FixedDebugNine2
{
  public static void NineTwo()
   {
      Breakfast special = new Breakfast("French toast", 4.99);
        Breakfast words = new Breakfast("Breakfast is the most important meal of the day.");
        System.Console.WriteLine(special.INFO);
        //Display the info about breakfast
        WriteLine(words.Info);//ch to special
      // then display today's special
      //WriteLine("Today we are having {0} for {1}",
      //   special.Name, special.Price.ToString("C2"));//ch lower n to upper

        WriteLine($"Today we are having {special.Name} for {special.Price.ToString("C2")}");


        ReadLine();
    }
}
class Breakfast
{
   // private string info;
  // private string name;
  // private double price;//ch upper P to Lower p
                        // Breakfast constructor requires a
                        // name, e.g "French toast", and a price
    public Breakfast(string info)
    {
        Info = info;
       
    }

    public Breakfast(string name, double price)
   {
       Name = name; //rev name = Name
       Price = price; //rev price = Price
   }
   public string Name { get; set; } //fixed ;
   public double Price { get; set; } //fixed ;
    public string Info { get; set; }
    public string INFO =
     "Breakfast is the most important meal of the day.";
}