using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Wochentage = { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag" };
            foreach (string item in Wochentage)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
