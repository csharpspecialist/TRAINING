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
            if (wAmount >= 0)
            {
                Console.WriteLine($"Your new balance is {wBalance}...We thought you knew!!! ");
            }
            else
            {
                Console.WriteLine("You need to enter a positive amount or beat it!!! ");
            }
            return wBalance;

        }

        public double WithdrawAgain(double changedTotal)

        {
            double nice = 0;
            Console.WriteLine("We r here now");
            return nice;
        }








    }
}
