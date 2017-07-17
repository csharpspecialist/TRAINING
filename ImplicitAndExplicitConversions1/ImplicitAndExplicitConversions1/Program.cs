using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ImplicitAndExplicitConversions1
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter();



        }

        private static void Converter()
        {
            byte destinationVar;
            short sourceVar = 7;
            destinationVar = (byte)sourceVar;  //explicit conversion here!!!
            WriteLine($"sourceVar val: {sourceVar}");
            WriteLine($"destinationVar val: {destinationVar}");
            ReadKey();


            byte bVar;
            short shortVar = 281;
            bVar = (byte)shortVar;  //explicit conversion here!!!
            WriteLine($"sourceVar val: {shortVar}");
            WriteLine($"destinationVar val: {bVar}");
            ReadKey();
        }
    }
}
