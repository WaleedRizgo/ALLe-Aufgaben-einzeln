using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Eingabe Parameter n:");
            string input = Console.ReadLine();
            n = Convert.ToInt32(input);

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Eingabe " + (i + 1) + ". Zahl:");
                input = Console.ReadLine();
                array[i] = Convert.ToInt32(input) * Convert.ToInt32(input);
            }

           
            foreach (var item in array)
            {
               
                Console.WriteLine("\nAusgabe von Zahl ist:"+""+item);
            }
            Console.ReadLine();
        }
    }
}
