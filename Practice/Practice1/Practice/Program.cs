using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int k = 4;
            double b = 5.3;
            char z = 'A';
            string c = "Drishti Gupta";

           
            Console.WriteLine(a+k);
            Console.WriteLine(k/a);
            Console.WriteLine(a<k);
            Console.WriteLine(k%a);

            if (a < k)
            {
                Console.WriteLine($"{a} is less than {k}");
            }
            else
            {
                Console.WriteLine($"{a} is greater than {k}");
            }
            Console.WriteLine();
            string num = "one";
            switch(num)
            {
                case "one":
                    Console.WriteLine("It is 1.");
                    break;
                case "two":
                    Console.WriteLine("It ois 2.");
                    break;
                default:
                    Console.WriteLine("It is some number");
                    break;
            }

            Console.WriteLine($"my name is {c}.");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(z);
            int[] arr = { 10, 20, 30, 40 };

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
