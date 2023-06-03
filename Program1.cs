using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

class FibonacciSeries
{
    static void Main()
    {
        Console.WriteLine("Enter the number of terms in the Fibonacci series: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fibonacci Series:");
        PrintFibonacciSeries(n);
    }

    static void PrintFibonacciSeries(int n)
    {
        int firstTerm = 0;
        int secondTerm = 1;

        Console.Write(firstTerm + " ");

        for (int i = 1; i < n; i++)
        {
            Console.Write(secondTerm + " ");

            int nextTerm = firstTerm + secondTerm;
            firstTerm = secondTerm;
            secondTerm = nextTerm;
        }
    }
}
