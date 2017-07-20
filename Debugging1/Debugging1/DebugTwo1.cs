// Program compares your name to the name of your boss
using System;
using static System.Console;
class DebugTwo1
{
    static void Debug21()
    {
      string name, bossName;
        Boolean areNamesTheSame;
      WriteLine("Enter your name");
      name = ReadLine();
      WriteLine("Hello {0}! Enter the name of your boss");
      bossName = ReadLine();
      areNamesTheSame = name == bossName;
      WriteLine("It is {0} that you are your own boss", areNamesTheSame);
   }
}
