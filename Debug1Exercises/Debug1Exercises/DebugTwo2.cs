// This program greets the user
// and multiplies two entered values
using System;
using static System.Console;
class DebugTwo2
{
   static void Main()
   {
   
	  string name;
	  string firstString, secondString;
	  int first, second, product;

	  WriteLine("Enter your name");

	  name = ReadLine();
	  WriteLine("Hello {0}! Enter an integer", name);
        //first = Convert.ToInt16(ReadLine());
        firstString = Console.ReadLine();
        int.TryParse(firstString, out first);
        first = Convert.ToInt16(ReadLine());


        WriteLine("Enter another integer");
        secondString = Console.ReadLine();
        int.TryParse(secondString, out second);

        product = first * second;

	  WriteLine("Thank you {0}. The product of {1} and {2} is {3}",
	 name, first, second, product);


        WriteLine($"Thank you {name}. The product of {first} and {second} is {product}");


    }
}
