using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankValuePassing
{
    class Deposits
    {
        public double Deposit(ref double currBalance)
        {

            Program p = new Program();
            double depAmount;
            //double currBalance = 0;
            Console.WriteLine($"How much would you like to deposit??");
            string dep = Console.ReadLine();

            while (!double.TryParse(dep, out depAmount) || depAmount < 1)
            {
                Console.WriteLine("That's not a valid deposit amount \n Please choose a number greater than zero");
                dep = Console.ReadLine();
                // Console.WriteLine($" \n what is your withdrawal amount??");
            }

            currBalance += depAmount;
            if (depAmount > 0)
            {
                Console.WriteLine($"Your new balance is {currBalance} Dude!!! ");
            }
            else
            {
                Console.WriteLine("You need to enter a positive amount or beat it!!! ");
            }

            return currBalance;
            // p.StartAgain();


        }

        public void DepositAgain(double changedTotal)
        {
            Program p = new Program();
            double depAmount;
            Console.WriteLine($"You have {changedTotal} currently in your account \n How much would you like to deposit??");

            string dep = Console.ReadLine();

            while (!double.TryParse(dep, out depAmount) || depAmount < 1)
            {
                Console.WriteLine("That's not a valid deposit amount \n Please choose a number greater than zero");
                dep = Console.ReadLine();
              
            }

            changedTotal += depAmount;
            if (depAmount >= 0)
            {
                Console.WriteLine($"Your new balance is {changedTotal} Dude!!! ");
            }
            else
            {
                Console.WriteLine("You need to enter a positive amount or beat it!!! ");
            }
           // Program.StartAgain(changedTotal);
            Console.WriteLine("Would U like to make another deposit?? \n Y or Yes \n M to return to the main menu or \n  press Q to quit the program");

            string depAnsw = Console.ReadLine().ToUpper();

            if (depAnsw == "Y" || depAnsw == "YES")
            {
                DepositAgain(changedTotal);
            }
            else if (depAnsw == "M" || depAnsw == "MAIN")
            {
                Program.StartAgain(changedTotal);               
            }else
            {
                Console.WriteLine("Thanks for using our program...press any key to exit.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            

        }
        

    }
}
