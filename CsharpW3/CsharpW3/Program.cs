using System;
using System.Data.Common;

namespace CsharpW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 6;
            int add = x + y;
            int sub = x - y;
            float div = x / y;
            int mul = x * y;
            Console.WriteLine(add +"\n"+ sub+"\n"+div+"\n"+mul); // Print the sum of x + y
            Console.ReadKey();
        }
    }
}

