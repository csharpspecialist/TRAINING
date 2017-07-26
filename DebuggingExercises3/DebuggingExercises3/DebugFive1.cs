// Program asks user to enter password
// If password is not "home", "lady" or "mouse"
// the user must re-enter the password
using static System.Console;
class DebugFive1
{
   public static void FiveOne()
   {
      const string PASS1 = "home";
      const string PASS2 = "nice";
      const string PASS3 = "dude";
      string password;

      Write("Please enter your password ");
      password = ReadLine();
        //below changed from || to &&
      while(password != PASS1 && password != PASS2 && password != PASS3) 
        {
            WriteLine("Invalid password. Please enter again. ");
            password = ReadLine();
        }

      
      WriteLine("Valid password");
        ReadLine();
   }
}
