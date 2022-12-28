using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViLyubiteRozi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Владимир Маяковский\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Вы люите розы?\n");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Вы любите розы?" +
                "\nВы любите розы?" +
                "\nа я на них срал!" +
                "\nстране нужны паровозы," +
                "\n\nнам нужен металл!" +
                "\nтоварищ!" +
                "\nне охай,не ахай!" +
                "\nне дёргай узду!" +
                "\nколь выполнил план," +
                "\nпосылай всех в п*зду" +
                "\nне выполнил —сам иди на х*й!");
            Console.ResetColor();

            Console.ReadKey();

        }
    }
}