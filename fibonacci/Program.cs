using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonacci(int num)
            {
                if (num == 0) return 0;
                if (num == 1) return 1;

                int[] fib = new int[num];
                fib[0] = 1;
                fib[1] = 1;
                int numElements = 2;
                
                for (int i=2; i < num; i++)
                {
                    fib[numElements] = fib[numElements-1] + fib[numElements-2];
                    numElements++;
                }
                return fib[numElements - 1];

            }

            

            Console.Write("Enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(fibonacci(input));
            Console.ReadKey();
        }
    }
}
