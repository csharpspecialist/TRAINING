using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndDestructorApp1
{
    class Professor
    {
        string fName;
        string lName;

        int important1;
        int important2;

        public Professor(string FirstName, string LastName)
        {
            fName = FirstName;
            lName = LastName;
            
        }

        public Professor(int Code1, int Code2)
        {
            important1 = Code1;
            important2 = Code2;

        }

        public void GoodPeople()
        {
            Console.WriteLine($"My first name is {fName} and my last name is {lName}");

        }

        public void ShowNumbers()
        {
            Console.WriteLine($"The first # is {important1} and the second # is {important2}");
        }

     




    }
}
