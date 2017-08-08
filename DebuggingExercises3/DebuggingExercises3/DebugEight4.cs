// Program demonstrates overloaded methods
// that display an int, an amount of money, or a string
// decorated with an argument character
// or a default character 'X'
using static System.Console;
class DebugEight4
{
  public static void EightFour()//ch to public and renamed
   {
       FancyDisplay(33);
       FancyDisplay(44, '@');//ch to single quotes
       FancyDisplay(55.55);
       FancyDisplay(77.77, '*');
       FancyDisplay("hello");
       FancyDisplay("goodbye", '#');
        //added readline
        ReadLine();
    }
   private static void FancyDisplay(int num, char decoration = 'X')
   {
      WriteLine("{0}{1}  {1}  {0}{1}\n",
         decoration, num); //took out placeholder # 2
   }
   private static void FancyDisplay(double num, char decoration = 'X')
   {
      WriteLine("{0}{0}{0}    {0}{0}{0}\n",
         decoration, num.ToString("C")); 
   }
   private static void FancyDisplay(string word, char decoration = 'X') //add string before word
   {
      WriteLine("{0}{0}{0}  {1}  {1}{0}{0}\n",
         decoration, word); 
   }

}
