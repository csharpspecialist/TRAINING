using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBurgerJoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Mcdonalds mc = new Mcdonalds();
            mc.BurgerName = "Big Mac";
            mc.SizeOfFries = " Small Fry";           
            mc.DrinkSize = "Small";
            mc.DrinkName = "Sprite";
            
            mc.DailyOrder();

            Wendys wnd = new Wendys();

            wnd.BurgerName = "Single";
            wnd.SizeOfFries = "Small Fry";
            wnd.DrinkSize = "Medium";
            wnd.DrinkName = "Tea";

            wnd.DailyOrder();


            Console.ReadLine();


        }
    }


    //Base Class
    public class GeneralFoods
    {
        
        public string BurgerName;
        public string SizeOfFries;
        public int NuggetCount;

        public string DrinkName;
        public string DrinkSize;
     
        
        public virtual void DailyOrder() //don't mark this virtual at first
        {
            Console.WriteLine($"You ordered a \n {BurgerName} " +
            $"plus a {SizeOfFries} and a {DrinkSize} {DrinkName}");


        }

    

    }


    public class Mcdonalds : GeneralFoods
    {

        public string BM;
        public string Qp;
        public string Dqp;       

    }

    public class Wendys : GeneralFoods
    {

        public string Single;
        public string Double;
        public string IceCream;

        public override void DailyOrder() //override later in class!!!!
        {
            base.DailyOrder();
            Console.WriteLine($"You really ordered something else...");
        }


    }





}
