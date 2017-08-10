using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritence
{
    public class Master
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }

        public void ShowHeros()
        {
            Console.WriteLine($"here we go now {ID}");


        }
    }
}
