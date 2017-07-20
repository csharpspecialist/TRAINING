// This program greets the user
// and multiplies two entered values
using System;
using static System.Console;
class DebugTwo2
{
	static void Debug22()
	{
	  string name;
	 // string firstString, secondString;
	  int first, second, product;
	  WriteLine("Enter your name");
	  name = ReadLine();
	  WriteLine("Hello {0}! Enter an integer", name);
		first = Convert.ToInt16(ReadLine());
	  WriteLine("Enter another integer");
	  second = Convert.ToInt16(ReadLine());
		product = first * second;
	  WriteLine("Thank you {1}. The product of {2} and {3} is {4}", //error 
	 name, first, second, product);
   }
}
