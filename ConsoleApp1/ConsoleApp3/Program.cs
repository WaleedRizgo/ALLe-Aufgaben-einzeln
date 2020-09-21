using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Anzahl;
            double Ausgabe = 0;

            Console.WriteLine("Geben Sie die Anzahl der Zahlen an:");
            while (!int.TryParse(Console.ReadLine(), out Anzahl))
            {
                Console.WriteLine("Eingabe ungültig!");
            }

            double[] Zahlen = new double[Anzahl];

            for (int i = 0; i < Anzahl; i++)
            {
                Console.WriteLine("Geben Sie Zahl " + (i + 1) + " an;");
                while (!double.TryParse(Console.ReadLine(), out Zahlen[i]))
                {
                    Console.WriteLine("Eingabe ungültig!");
                }

                for (int j = 0; j < Anzahl; j++)
                {
                    Ausgabe = Math.Pow(Zahlen[i], 2);
                }
            }

            Console.WriteLine("Quadrate der Zahlen: ");
            for (int i = 0; i < Anzahl; i++)
            {
                Ausgabe = Math.Pow(Zahlen[i], 2);

                Console.WriteLine("\nZahl " + (i + 1) + " = " + Ausgabe);
            }
    }
}
}
