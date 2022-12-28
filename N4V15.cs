using System;

namespace ConsoleApp2
{
    internal static class N4V15
    {
        private static void Main()
        {
            Console.Write("x = ");
            var x = double.Parse(Console.ReadLine()!);
            if (x is 0 or < -1)
                Console.WriteLine("Некорректное число");
            else
            {
                var y = Math.Sin((3.2 + Math.Sqrt(x + 1))/Math.Abs(5*x));
                Console.WriteLine($"y = {y}");
            }
        }
    }
}