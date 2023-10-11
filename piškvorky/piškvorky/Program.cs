namespace piškvorky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("piškvorrkyyyyy!!!");

            List<string> pole;
            pole = new List<string>();

            pole.Add(" ");
            pole.Add("1");
            pole.Add("2");
            pole.Add("3");
            pole.Add("4");
            pole.Add("5");
            pole.Add("6");
            pole.Add("7");
            pole.Add("8");
            pole.Add("9");

            Console.WriteLine(pole[2]);
            pole[2] = "AAA";
            for (int i = 0; i < pole.Count; i++)
            {
                Console.Write(pole[i] + " ");
                if (i % 3 == 0)
                {
                    Console.WriteLine(" ");
                }

            }
            Console.WriteLine();

            Console.WriteLine("kam chceš položit X?");
            Console.Write("Tvá odpověď: ");
            string hrac = Console.ReadLine();

            if (pole[1] == hrac || pole[2] == hrac || pole[1] == hrac || pole[1] == hrac || pole[1] == hrac || pole[1] == hrac)
            {
                pole[0] = "X";
            }


        }
    }
}