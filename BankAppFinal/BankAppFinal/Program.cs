﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp1
{
    class Program
    {


       // Program init = new Program();
       // double updatedBalance;
        //double total;
        public double IntialBalance { get; set; }
        public double UpdatedBalance { get; set; }

        public double Total { get; set; }




        static void Main(string[] args)
        {

             Program now = new Program();
            now.Start();
            now.IntialBalance = 500;

        }

        public void Start()
        {
            Program p = new Program();

            Console.WriteLine($"Your balance started at {p.IntialBalance}...{p.Total += p.UpdatedBalance}... \n " +
                 "would you like to do \n 1.Deposit \n 2.Withdraw \n 3.Check Balance");
            int numchoice = Convert.ToInt32(Console.ReadLine());

            switch (numchoice)
            {
                case 1:
                    p.Deposit();
                    break;
                case 2:
                    p.Withdraw();
                    break;
                case 3:
                    p.CBalance();
                    break;

                default:
                    Console.WriteLine("You did not choose a valid choice" +
                        "\n Would you like to start use the banking app");
                    string again = Console.ReadLine();


                    p.Start();

                    Console.ReadKey();
                    break;

            }
        }

        private void Deposit()
        {
            Program p = new Program();
            double depAmount;
            Console.WriteLine($"How much would you like to deposit??");
            string dep = Console.ReadLine();       
            
            while (!double.TryParse(dep, out depAmount) || depAmount < 1)
            {
                Console.WriteLine("That's not a valid withdrawal amount \n Please choose a number greater than zero");
                dep = Console.ReadLine();
                // Console.WriteLine($" \n what is your withdrawal amount??");
            }

            p.UpdatedBalance = IntialBalance + depAmount;
            if (depAmount >= 0)
            {
                Console.WriteLine($"Your new balance is {p.UpdatedBalance} Dude!!! ");
            }
            else
            {
                Console.WriteLine("You need to enter a positive amount or beat it!!! ");
            }
            p.Start();

        }

        private void Withdraw()
        {
            Program p = new Program();
            double wAmount;
            Console.WriteLine($"How much would you like to withdraw??");
            string withdrawal = Console.ReadLine();



            while (!double.TryParse(withdrawal, out wAmount )|| wAmount < 1)
            {
                Console.WriteLine("That's not a valid withdrawal amount \n Please choose a number greater than zero");
                withdrawal = Console.ReadLine();
               // Console.WriteLine($" \n what is your withdrawal amount??");
            }

            p.UpdatedBalance = IntialBalance - wAmount;
            if (wAmount >= 0)
            {
                Console.WriteLine($"Your new balance is {p.UpdatedBalance} Dude!!! ");
            }
            else
            {
                Console.WriteLine("You need to enter a positive amount or beat it!!! ");
            }
            p.Start();  
            

        }

        private void CBalance()
        {
            Program p = new Program();

            Console.WriteLine($"Your account has {p.UpdatedBalance} in it ");
            Console.ReadKey();
        }

        public void StartAgain()
        {
            Program p = new Program();

            Console.WriteLine("Would you like to start the banking app over?? " +
                " \n Y or Yes \n N or no");
            string overAns = Console.ReadLine();

            switch (overAns)
            {
                case "Y":
                    p.Start();
                    break;



                default:
                    Console.WriteLine("Thanks for using our application");
                    Console.WriteLine("Have a nice day...\n Press any Key to continue");
                    break;
            }




        }



    }




}
