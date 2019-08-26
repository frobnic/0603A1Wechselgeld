using System;

namespace _0603A1Wechselgeld
{
    class Program
    {
        static void Main(string[] args)
        {
            int summe = 0, gegeben = 0, rest = 0, anz = 0;

            int[,] geld = new int[,] { { 50, 0 }, { 20, 0 }, { 10, 0 }, { 5, 0 }, { 2, 0 }, { 1, 0 } };


            Console.Write("Bitte geben Sie einen Betrag in Cent ein : ");
            gegeben = int.Parse(Console.ReadLine());

            Console.WriteLine("Arraymethode:");
            rest = gegeben;
            for (int i = 0; i < geld.Length/2; i++)
            {
                geld[i, 1] = (rest / geld[i, 0]);
                rest = rest % geld[i,0];
                Console.WriteLine("{0,3} x {1,2} Cent", geld[i, 1], geld[i, 0]);
            }

            Console.WriteLine("Klassische Methode:");
            if ((anz = (gegeben / 50)) > 0)
            {
                rest = gegeben % 50;
                Console.WriteLine("{0,3} x 50 Cent", anz);
            }

            if ((anz = (rest / 20)) > 0)
            {
                rest = rest % 20;
                Console.WriteLine("{0,3} x 20 Cent", anz);
            }

            if ((anz = (rest / 10)) > 0)
            {
                rest = rest % 10;
                Console.WriteLine("{0,3} x 10 Cent", anz);
            }

            if ((anz = (rest / 5)) > 0)
            {
                rest = rest % 5;
                Console.WriteLine("{0,3} x  5 Cent", anz);
            }

            if ((anz = (rest / 2)) > 0)
            {
                rest = rest % 2;
                Console.WriteLine("{0,3} x  2 Cent", anz);
            }

            if ((anz = (rest / 1)) > 0)
            {
                rest = rest % 1;
                Console.WriteLine("{0,3} x  1 Cent", anz);
            }

        }
    }
}
