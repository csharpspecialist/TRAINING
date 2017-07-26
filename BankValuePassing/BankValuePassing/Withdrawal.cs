using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankValuePassing
{
    class Withdrawal
    {

        public double Withdraw(ref double wBalance)
        {
            Program p = new Program();
            double wAmount;
            Console.WriteLine($"How much would you like to withdraw??");
            string withdrawal = Console.ReadLine();



            while (!double.TryParse(withdrawal, out wAmount) || wAmount < 1)
            {
                Console.WriteLine("That's not a valid withdrawal amount \n Please choose a number greater than zero");
                withdrawal = Console.ReadLine();
                // Console.WriteLine($" \n what is your withdrawal amount??");
            }

            wBalance -= wAmount;
            if (wAmount > 0)
            {
                Console.WriteLine($"Your new balance is {wBalance}...We thought you knew!!! ");
            }
            else
            {
                Console.WriteLine("You need to enter a positive amount or beat it!!! ");
            }
            return wBalance;

        }

        public void WithdrawAgain(double changedTotal)
        {
            Program p = new Program();
            double wAmount;
            WriteLine($"You have {changedTotal} currently in your account \n How much would you like to Withdraw??");

            string dep = Console.ReadLine();

            while (!double.TryParse(dep, out wAmount) || wAmount < 1)
            {
                Console.WriteLine("That's not a valid withdrawal amount \n Please choose a number greater than zero");
                dep = Console.ReadLine();

            }

            changedTotal -= wAmount;
            if (wAmount > 0)
            {
                Console.WriteLine($"Your new balance is {changedTotal} Dude!!! ");
            }
            else
            {
                Console.WriteLine("You need to enter a positive amount or beat it!!! ");
            }

            Console.WriteLine("Would U like to make another withdrawal?? \n Y or Yes \n M to return to the main menu or \n  press Q to quit the program");

            string wAnsw = Console.ReadLine().ToUpper();

            if (wAnsw == "Y" || wAnsw == "YES")
            {
                WithdrawAgain(changedTotal);
            }
            else if (wAnsw == "M" || wAnsw == "MAIN")
            {
                Program.StartAgain(changedTotal);
            }
            else
            {
                Console.WriteLine("Thanks for using our program...press any key to exit.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            

        }

    }
}
