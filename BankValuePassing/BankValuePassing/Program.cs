using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankValuePassing
{
    class Program
    {

        public static double IntialBalance { get; set; }
        public static double UpdatedBalance { get; set; }

        public static double Total { get; set; }




        static void Main()
        {
           
            IntialBalance = 500;
            Program p = new Program();
            p.Start(IntialBalance);
            double currBalance;
            //Console.WriteLine($"Your current balance is {currBalance}");
            Console.ReadLine();

          
        }


        public void Start(double startingBalance)
        {
            double beginningBalance = 200;
            double changedTotal;
            Program p = new Program();

            Console.WriteLine($"Your original balance started at{beginningBalance}..your new balance is  \n " +
                 "would you like to do \n 1.Deposit \n 2.Withdraw \n 3.Check Balance");
            int numchoice = Convert.ToInt32(Console.ReadLine());

            switch (numchoice)
            {
                case 1:

                   
                   // double depReturn;
                    
                    p.Deposit(ref beginningBalance);
                   // Console.WriteLine(IntialBalance);
                   // changedTotal =  p.Deposit(ref beginningBalance);
                   // Console.WriteLine($"Your new balance is{changedTotal}");
                    Console.WriteLine("Whatever!!");
                  //  holdingBalance;
                    break;
                case 2:
                    p.Withdraw(IntialBalance);
                    break;
                case 3:
                    p.CBalance(IntialBalance);
                    break;

                default:
                    Console.WriteLine("You did not choose a valid choice" +
                        "\n Would you like to start use the banking app");
                    string again = Console.ReadLine();
                    p.StartAgain();

                    Console.ReadKey();
                    break;

            }

        }

        public double Deposit(ref double currBalance)
        {

            Program p = new Program();
            double depAmount;
            //double currBalance = 0;
            Console.WriteLine($"How much would you like to deposit??");
            string dep = Console.ReadLine();

            while (!double.TryParse(dep, out depAmount) || depAmount < 1)
            {
                Console.WriteLine("That's not a valid withdrawal amount \n Please choose a number greater than zero");
                dep = Console.ReadLine();
                // Console.WriteLine($" \n what is your withdrawal amount??");
            }

            currBalance += depAmount;
            if (depAmount >= 0)
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

        private void Withdraw(double balanceAmt)
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

            UpdatedBalance = IntialBalance - wAmount;
            if (wAmount >= 0)
            {
                Console.WriteLine($"Your new balance is {UpdatedBalance}...We thought you knew!!! ");
            }
            else
            {
                Console.WriteLine("You need to enter a positive amount or beat it!!! ");
            }
            p.StartAgain();


        }

        public void CBalance(double balance)
        {
            Console.WriteLine($"Your account has {IntialBalance} in it ");
            Console.ReadKey();
        }

        public void StartAgain()
        {
            Program p = new Program();

            Console.WriteLine("Would you like to start the banking app over?? " +
                " \n Y or Yes \n N or no");
            string overAns = Console.ReadLine().ToUpper();

            switch (overAns)
            {
                case "Y":
                case "YES":
                    Main();
                    break;


                default:
                    Console.WriteLine("Thanks for using our application");
                    Console.WriteLine("Have a nice day...\n Press any Key to continue");
                    break;
            }




        }



    }
}
