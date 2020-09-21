using System;

namespace ConsoleApp5
{
class Student
    {
        static void Waleed()
        {
            {
                Console.WriteLine(" "+"Enter the Name ");
                string name = Console.ReadLine();
                Console.WriteLine(" " + "Enter the Age");
                int age = Convert.ToInt32(Console.ReadLine());
                

                 if (age > 18)
                 {
                    Console.WriteLine(" "+name + "" + " is over 18 Years");
                    Console.ReadLine();
                 }
 

                else if (age < 18)
                {
                    Console.WriteLine(" "+name + "" + "is under 18");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine(" "+name + "" + "is 18 Years");
                }

                Console.ReadKey(true);

            }
        }
        static void Main(string[] args)
        {
            Waleed();
        }
    }
}

