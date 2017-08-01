using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice1
{
    //Base Class
    public class Employee
    {
        // Base Class
        public string FirstName;
        public string LastName;
        public int EmployeeId;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine($"My first name is {FirstName} and my last name is {LastName}");

        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            FullTimeEmployee ft = new FullTimeEmployee();
            ft.FullTimeId = 1001;
            ft.FirstName = "Mary";
            ft.LastName = "Mitchel";
            ft.PrintFullName();

            Console.WriteLine("*****************");

            PartTimeEmployee pt = new PartTimeEmployee();
            pt.PartTimeID = 3025;
            pt.FirstName = "Peter";
            pt.LastName = "Parker";
            pt.PrintFullName();

            Console.WriteLine("*****************");

            HumanResources hr = new HumanResources();

            hr.FirstName = "Andi";
            hr.LastName = "Mason";
            hr.PrintFullName();


            Console.ReadLine();
           


        }

    }

    public class FullTimeEmployee : Employee
    {
        public double Salary;
        public double FullTimeId;

    }

    public class PartTimeEmployee : Employee
    {
        public double HourlyRate;
        public int PartTimeID;

    }

    public class SeaonalWorker : FullTimeEmployee
    {
        public int SeasonID;
        public string Address;
    }


    public class HumanResources : SeaonalWorker
    {

    }


}

