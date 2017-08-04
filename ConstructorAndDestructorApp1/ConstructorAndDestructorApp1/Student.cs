using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConstructorAndDestructorApp1
{
    class Student : Professor
    {

        public Student() : base (15,22)
        {

            Console.WriteLine("Things that make you go HMMMMM");
        }
            public void Present()
        {
            Console.WriteLine("Yes it is Friday!!!!");
            

        }



    }



    
}
