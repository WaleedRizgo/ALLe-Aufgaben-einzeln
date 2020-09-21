using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1, zahl2;
            string op;
            
            Console.WriteLine("Beachten Sie bitte, dass Sie mindestens zwei Zahlen eingeben!");
 
                Console.Write("Geben Sie eine Zahl ein:\t");
                zahl1 = Convert.ToInt32(Console.ReadLine());
 
                Console.Write("Geben Sie eine Zahl ein:\t");
                zahl2 = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine("choose the operation type +/*-");
                op = Console.ReadLine();
           
               if (op=="+")
            {
                Console.WriteLine("Your Result is" +  " " + ( zahl2 + zahl1));
            }
                else if (op == "-")
            {
                Console.WriteLine(zahl2 - zahl1);
            }
            else if (op == "*")
            {
                Console.WriteLine(zahl2 * zahl1);
            }
            else if (op == "/")
            {
                Console.WriteLine(zahl2 / zahl1);
            }





            Console.ReadKey(true);
        }
        
    }
}
