// Address an envelope one of two ways
// Using zip code, or using city and state
using static System.Console;
class DebugSeven2
{
  public static void SevenTwo()
   {
      string addressee = "Ms. Brooke Jefferson";
      int zipCode = 60007;
      string cityAndState = "Elk Grove, IL";
      AddressMethod(addressee, zipCode);
      WriteLine("-----------------------");
      AddressMethod(addressee, cityAndState);
      WriteLine("-----------------------");
        ReadLine();
   }
   private static void AddressMethod(string person, int num)
   {
      WriteLine("To : {0}", person);
      WriteLine("Zip: {0}",  num);
   }
   private static void AddressMethod(string person, string city)
   {
      WriteLine("To : {0}", person);
      WriteLine("{0}", city);
   }
}

