using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankValuePassing
{
    class Program
    {

        public static double InitialBalance { get; set; }
        public static double UpdatedBalance { get; set; }

        public static double Total { get; set; }




        public static void Main()
        {
           
            InitialBalance = 500;
            Program p = new Program();
            p.Start(InitialBalance);

            Console.WriteLine($"Your current balance is {InitialBalance}");
            Console.ReadLine();

          
        }


        public void Start(double startingBalance)
        {
            //double starting balance = 200;
            double changedTotal;
            int numChoice;
            Program p = new Program();
            Deposits d = new Deposits();
            Withdrawal w = new Withdrawal();

            Console.WriteLine($"Your balance is ${startingBalance} \n " +
                 "would you like to do \n 1.Deposit \n 2.Withdraw \n 3.Check Balance");
            string firstChoice = Console.ReadLine();

            int.TryParse(firstChoice, out numChoice);

            switch (numChoice)
            {
                
                case 1: 
                                      
                    /*this has to be a ref parameter below in line 57!!!
                    I tried and searched for a long time to get this
                    to work correctly...finally found that this worked.
                    calling the d.deposit method this way still takes 
                    beginning balance in @ $200..this value will change to
                    a new/diff amt after the user makes a deposit amt inside 
                    of the d.deposit method. Debug the code to see 
                    it in action!!!!     */
                    changedTotal = d.Deposit(ref startingBalance);
                   // changedTotal = d.Deposit(ref beginningBalance);
                    Console.WriteLine($"Your new balance( before we take  is that is...)  is  {changedTotal}");
                    StartAgain(changedTotal);

                    // d.DepositAgain(changedTotal);
                    StartAgain(changedTotal);
                    break;
                case 2:
                    changedTotal = w.Withdraw(ref startingBalance);
                    Console.WriteLine($"Your new balance is  {startingBalance}");

                    StartAgain(changedTotal);
                     
                    StartAgain(changedTotal);   
                    break;
                case 3:
                    p.CBalance(startingBalance);
                    break;

                default:
                   
                    Console.WriteLine("You did not choose a valid choice" +
                        "\n Would you like to start use the banking app");
                    string again = Console.ReadLine().ToUpper();

                    if(again == "Y" || again =="YES")
                    {
                        Start(startingBalance);
                    }
                   else
                    {
                        Console.WriteLine("Thanks for using our program \n Press any key to exit");
                        Console.ReadLine();
                    }

                    Console.ReadKey();
                    break;
            }

        }      
               

        public void CBalance(double balance)
        {
            Console.WriteLine($"Your account has {InitialBalance} in it ");
            StartAgain(balance);

            //Console.ReadKey();

        }        


        public static void StartAgain(double changedTotal)
        {
            Program p = new Program();
            Deposits d = new Deposits();
            Withdrawal w = new Withdrawal();
            int beginAgain;
            Console.WriteLine("What would you like to do now?? \n" +
                "1. Deposit \n" +
                "2. Withdrawal \n" +
                "3. Check Account Balance \n" +
                "4. End the program");
            string overAns = Console.ReadLine().ToUpper();
            int.TryParse(overAns, out beginAgain);

            switch (beginAgain)
            {
                case 1:
                   d.DepositAgain(changedTotal);
                    break;
                case 2:
                    w.WithdrawAgain(changedTotal);
                    break;
                case 3:
                    p.CBalance(changedTotal);
                    break;


                default:
                    Console.WriteLine("Thanks for using our application");
                    Console.WriteLine("Have a nice day...\n Press any Key to continue");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }


        }


    }
}
