using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPractice1
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, Football> ballClub = new Dictionary<int, Football>();


            Football fb1 = new Football();
            fb1.TeamID = 1000;
            fb1.TeamName = "Browns";
            fb1.Division = "North";
            fb1.Conference = "AFC";
            fb1.NetWorth = 1000000;

            Football fb2 = new Football();
            fb2.TeamID = 2000;
            fb2.TeamName = "Colts";
            fb2.Division = "South";
            fb2.Conference = "AFC";
            fb2.NetWorth = 2000000;

            ballClub.Add(fb1.TeamID, fb1);
            ballClub.Add(fb2.TeamID, fb2);

            foreach (var item in ballClub)
            {
                Football kick = item.Value;
                kick.PrintClub2();
            }

            Console.ReadLine();

            foreach (KeyValuePair<int, Football> item in ballClub)
            {
                Football fb = item.Value;
                fb.PrintClub();
            }

            Console.ReadLine();
        }
    }
}
