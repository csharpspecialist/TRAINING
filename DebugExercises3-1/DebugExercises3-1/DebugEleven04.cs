// Declare a Student
// ID must be an integer and gpa must be a double to continue
using System;
using static System.Console;
class DebugEleven04
{
    public static void ElevenFour() //add public + ch from main
    {
        Student stu = new Student();
        bool areNumbersGood = false;
        while (areNumbersGood)
        {
            try
            {
                stu.setID();//must be int
                stu.setGPA();// must be double
            }
            catch (FormatException e)
            {
                WriteLine(e.Message);
                WriteLine("(Either the student ID or the GPA");
                WriteLine(" was not in the correct format");
                WriteLine("You will have to re-enter the student data.");
            }
        }
        WriteLine("Valid student");
        Console.ReadLine();

    }
    public class Student
    {
        private int stuId;
        private double stuGpa;
        public void setID()
        {
            string stuNumber;
            try
            {
                Write("Enter student ID ");
                stuNumber = ReadLine();//add ()
                stuId = Convert.ToInt32(stuNumber);
            }
            catch (FormatException fe)
            {
                throw (fe); //placed inside curly braces
            }

        }
        public void setGPA()
        {
            string stuGPAString;
            try
            {
                Write("Enter student GPA ");
                stuGPAString = ReadLine();
                stuGpa = Convert.ToDouble(stuGPAString);
            }
            catch (FormatException fe)
            {
                throw (fe);
            }
        }
    }
}  

   