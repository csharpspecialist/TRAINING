using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac1
{
    public class Employee
    {
        //Base Class
       public string FirstName;
        public string LastName;
        public int EmployeeId;
        public string Email;
       
        public void PrintFullName()
        {
           
            Console.WriteLine($"my First name is {FirstName} and my last name is {LastName}");

        }

    }
    public class FullTimeEmployee : Employee
    {
        public double Salary;
        public double FullTimeID;
        public void PrintName()
        {
            Employee e = new Employee();
            e.PrintFullName();

        }
        
    }


    public class PartTimeEmployee : Employee
    {
        Employee e = new Employee();
        public double HourlyRate;
        public int PartTimeId;    

    }
    

    class Program
    {
        static void Main(string[] args)
        {
            
            FullTimeEmployee full = new FullTimeEmployee();
            full.EmployeeId = 1002;
            full.FirstName = "Buster";
            full.LastName = "Douglass";
            full.PrintFullName();

            PartTimeEmployee pa = new PartTimeEmployee();
            pa.EmployeeId = 5209;
            pa.FirstName = "Mike";
            pa.LastName = "Tyson";
            pa.PrintFullName();


            Console.ReadLine();
        }
    }
}
