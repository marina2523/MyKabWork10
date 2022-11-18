// See https://aka.ms/new-console-template for more information
using System;
namespace EX1
{
    class Program
    {
        static void Main()
        {
            double z, x, n;
            z = 0;
            Console.Write("x= ");
            x = double.Parse(Console.ReadLine());
            Console.Write("(n>0) n = ");
            n = double.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++) z += Math.Cos(x) + ((Math.Cos(3 * x)) / 9) + ((Math.Cos(5 * x)) / 25);
            Console.WriteLine("z = {0}", z);
        }
    }
}

