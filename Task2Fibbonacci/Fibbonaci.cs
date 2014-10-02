using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Fibbonacci
{
    public class Fibbonaci
    {
        public  double  FibonacciTest(int n)
        {
            double a = 0;
           double  b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                double temp = a;
                a = b;
                b = temp + b;
            }
             return a;
        }
    }
}
