using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SwitchMessageAndEnumPrac1
{

   
    class Program
    {
        enum Cars
        {
            Lincoln = 1,
            Dodge,
            Ford,
            Corvette,
            Mercury


        }
        
        static void Main(string[] args)
        {
            //iterating thru enum using foreach loop
            var values = Enum.GetValues(typeof(Burgers));


            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();



            //showing how to use message first
            string message;
            int flixShow = 0;
            Console.WriteLine("What's is your favorite Netflix  Show \n 1. GOT \n 2. Orange \n 3. Iron Fist \n 4. Luke Cage");          
            string flix = Console.ReadLine();        
            int.TryParse(flix, out flixShow);

            //shift up!!!!!!!!   2 sets of parenthesis
            switch (flixShow)
            {
                case 1:
                case 2: //demonstration of 2 cases in one statement
                    message = "GOT & Orange are neck and neck!!!";
                    break;

                case 3:
                    message = "Iron Fist is hot";
                    break;

                case 4:
                    message = "Luke cage is a spinoff of Jessica Jones";
                    break;

                default:
                    message = "That's not a pasta choice we recognize";
                    break;

            }
            Console.WriteLine(message);
            Console.ReadLine();
            Console.WriteLine("Press any key to go to the Car questionnaire");

            int car;
            string note = "";
            Write("Enter a car that you like");
            car = Convert.ToInt32(ReadLine());

            //shift up!!!!!!!!   2 sets of parenthesis
            switch ((Cars)car)
            {
                case Cars.Lincoln:
                    note = "Lincolns Really Rule";
                    break;
                case Cars.Dodge:
                    note = "Dodge Vehicles are Great";
                    break;
                case Cars.Ford:
                    note = "Ford Vehicles are Great";
                    break;
                case Cars.Corvette:
                    note = "Vettes are smokin dude";
                    break;
                case Cars.Mercury:
                    note = "Mercs are smooth riding";
                    break;
                default:
                    note = "Pick a real car!!!";
                    break;
            }
            Console.WriteLine(note);

            Console.WriteLine("Press any key to go to the Car questionnaire");
            ReadLine();


            
            int bestChoice;
            string choiceMessage = "";
            Console.WriteLine("Which movie of 2017 is the best");
            string best = Console.ReadLine();
           int.TryParse(best, out bestChoice);

            //shift up!!!!!!!!   2 sets of parenthesis

            switch ((Movies)bestChoice)
            {
                case Movies.Wonderwoman:
                    choiceMessage = "Great movie";
                    break;
                case Movies.PlanetofApes:
                case Movies.BabyDriver:
                    choiceMessage = "Baby Driver & Planet of the Apes Rocks!!!";
                break;                
              
                case Movies.Transformers:
                    choiceMessage = "The return of Optimus Prime";
                break;
                case Movies.GetOut:
                    choiceMessage = "We Got Out...Fast";
                break;
                case Movies.Mummy:
                    choiceMessage = "Really Scary Chick!!!";
                break;
                default:
                    choiceMessage = "We don't understand your answer";
                    break;
            }
            Console.WriteLine(choiceMessage);
            Console.WriteLine("Out of movie loop");
            ReadLine();


            int BChoice;
            Console.WriteLine("Name your favorite burger \n 1. Whopper \n 2. Big Mac \n 3. Big Boy");
            string burger = ReadLine();

            //shift up!!!!!!!!  2 sets of parenthesis
            int.TryParse(burger, out BChoice);

            switch ((Burgers)BChoice)
            {
                case Burgers.Whopper:
                    break;
                case Burgers.BigMac:
                    break;
                case Burgers.BigBoy:
                    break;
                case Burgers.QuarterPounder:
                    break;
                case Burgers.Single:
                    break;
                case Burgers.DoubleCheese:
                    break;
                default:
                    break;
            }

            switch ((Burgers)BChoice)
            {
                case Burgers.Whopper:
                    break;
                case Burgers.BigMac:
                    break;
                case Burgers.BigBoy:
                    break;
                case Burgers.QuarterPounder:
                    break;
                case Burgers.Single:
                    break;
                case Burgers.DoubleCheese:
                    break;
                default:
                    break;
            }   
              
        }
   
    }
    enum Movies
    {
        Wonderwoman = 1,
        PlanetofApes,
        BabyDriver,
        Transformers,
        GetOut,
        Mummy
    }

    enum Burgers
    {

        Whopper = 1,
        BigMac,
        BigBoy,
        QuarterPounder,
        Single,
        DoubleCheese

    }



}
