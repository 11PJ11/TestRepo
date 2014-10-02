using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Fibbonacci
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Fibbonaci Fibonacci = new Fibbonaci();
            
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(Fibonacci.FibonacciTest(i));
            }

        }
    }
}
