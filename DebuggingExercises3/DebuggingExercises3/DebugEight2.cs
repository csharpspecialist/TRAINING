// Overloaded method gives bonus points
// whether grade is a number or letter
using static System.Console;
class DebugEight2
{
   public static void EightTwo()
   {
      int numericScore = 82;
      string letterScore = "B"; // add ""
      Write("Score was {0}. ", numericScore);
      GiveBonus(ref numericScore);
      WriteLine("Now it is {0}.", numericScore);
      Write("Grade was {0} ", letterScore);// add {0}
      GiveBonus(ref letterScore);
      WriteLine("Now it is {0} ", letterScore); // add B{0}
        ReadLine();
   }
   private static void GiveBonus(ref int  testScore)// ch from int ref
   {
      const int BONUS = 5;
      testScore += BONUS; //ch from = to +=
   }
   private static void GiveBonus(ref string letterScore) // ch from int ref
    {
      const string BONUS = "+";
      letterScore += BONUS; //ch from = to +=
    }
}

