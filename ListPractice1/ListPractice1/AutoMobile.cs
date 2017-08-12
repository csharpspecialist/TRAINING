using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice1
{
    class AutoMobile
    {

        public int AutoID { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        //AutoImplemented property
        public bool ShoeColor { get; set; }


        private string trimLevel;

        public string TrimLevel
        {
            get { return trimLevel; }
            set { trimLevel = value; }
        }

        public void DisplayItems()
        {
            Console.WriteLine($"The Id is {AutoID}, the Model is {Model} and the make is a {Make}");

        }

    }
}
