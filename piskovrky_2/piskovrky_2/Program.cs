using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;


namespace piskvorky_2
{
    internal class Program
    {
        static string[] pole = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9"};

        static void Main()
        {
            Console.WriteLine("      |      |      ");
            Console.WriteLine("   {0}  |   {1}  |   {2}   ", pole[1], pole[2], pole[3]);
            Console.WriteLine("      |      |      ");
            Console.WriteLine("--------------------");
            Console.WriteLine("      |      |      ");
            Console.WriteLine("   {0}  |   {1}  |   {2}   ", pole[4], pole[5], pole[6]);
            Console.WriteLine("      |      |      ");
            Console.WriteLine("--------------------");
            Console.WriteLine("      |      |      ");
            Console.WriteLine("   {0}  |   {1}  |   {2}   ", pole[7], pole[8], pole[9]);
            Console.WriteLine("      |      |      ");

            Random random = new Random();
            int nahodneCislo = random.Next(1, 10);

            string bot = nahodneCislo.ToString();

            string player = "";

            if (bot == "1" || player == "1")
            {
                pole[0] = "1";
            }


        }        
    }
}