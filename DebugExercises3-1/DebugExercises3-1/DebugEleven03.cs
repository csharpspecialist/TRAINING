// Employee's salary should not be negative
// Include stack trace when exception occurs
using System;
using static System.Console;
 class FDebugEleven03
{
    public static void ElevenThree()//ch name + add public
   {
      Employee emp = new Employee();
      try
      {
         emp.IdNum = 234;
         emp.Salary = -12;
      }
      catch (NegativeSalaryException e)
      {
         WriteLine(e.Message);
         WriteLine(e.StackTrace);
      }

        Console.ReadLine();//add readline
    }
}
public class NegativeSalaryException : Exception //add : Exception
{
   private static string msg =
     "Employee salary is negative.";
   public NegativeSalaryException() : base(msg)
   {
   }
}

public class Employee
{
   private int idNum;
   private double salary;
   public int IdNum
   {
      get//add curly braces
        {
            return idNum;
        }
      set
        {
            idNum = value;
        } 
       
   }
   public double Salary
   {
      get
      {
         return salary;
      }
      set
      {
        if(value < 0)
        {
           NegativeSalaryException salExcep =
              new NegativeSalaryException();
           throw(salExcep);//ch from sal to salExcep
        }
        salary = value;
      }
   }

}
   