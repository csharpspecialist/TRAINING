using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValuePractice1
{
    class Program
    {
        static void Main(string[] args)
        {

            string favorite1 = "Lasagne";
            string favorite2 = "Hamburgers";
         
            int favoriteNum1 = 222;
            int favoriteNum2 = 778;

            
            string ourFavorite = FavoriteFood(favorite1, favorite2);

            Console.WriteLine($"Our favorite foods are {favorite1} and {favorite2} put together these are {ourFavorite}");
            Console.ReadLine();

            int rnumber = FavoriteNumbers(favoriteNum1, favoriteNum2);

            Console.WriteLine($"Our favorite numbers together are {favoriteNum1} and {favoriteNum2} put together these are {rnumber}");
            Console.ReadLine();

        }

        private static string FavoriteFood (string food1, string food2)
        {
            string bestFood = food1 +" "+ food2;

            return bestFood;
        }

        private static int FavoriteNumbers (int number1, int number2)
        {
            int total = number1 + number2;

            return total;
        }




    }
}
