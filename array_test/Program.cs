using System;
using System.Linq;
namespace array_test
{
    class Program
    {
        static void Arrayfunc()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }

        static void Arraynummberfun()
        {
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine("The first Function");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("The Max nummber in the Array is:"+" "+myNumbers.Max());  
            Console.WriteLine("The Min nummber in the array is:" + " " + myNumbers.Min());  
            Console.WriteLine("The Sum of the Array nummbers is:" + " " + myNumbers.Sum());  
            Console.WriteLine("====================================");

            Console.WriteLine("The seccind Function");
            Console.WriteLine("------------------------------------");

        }
        static void Main(string[] args)
        {



            Arraynummberfun();
            Arrayfunc();
            Console.WriteLine("====================================");
            Console.ReadKey();
        }
    }
}

   