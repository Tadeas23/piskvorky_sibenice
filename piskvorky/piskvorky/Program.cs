using System;
using System.Threading;

namespace piskvorky
{
    internal class Program
    {
        static char[] pole = { '0' , '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        static int hrac = 0;
        static int kontrola;
        static int flag = 0;
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hráč 1:X    Bot:O");
            Board();
            kontrola = int.Parse(Console.ReadLine());
            if (pole[kontrola] != "X" && pole[kontrola] != "O") 
            {
                pole[kontrola] = "O";
                hrac++;
            }
            else
            {
                pole[kontrola] = "X";
                hrac++;
            }
            else
            {
                Console.WriteLine("A je je poličko {0} je zabrané {1}");
                Console.WriteLine("zkus to znovu");
            }
            flag = CheckWin();
            }
        while (flag != 1 && flag != -1);
        console.clear();
        Board();

    }
}
