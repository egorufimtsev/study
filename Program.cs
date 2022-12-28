
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Maths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Условие Задачи 21: Дан радиус окружности найти площади вписанных в нее квадрата и правильного треугольника.\r\n");
            Console.WriteLine("Введите радиус описанной окружности:\r\n");

            double R = double.Parse(Console.ReadLine());

            // За "a" возьмем сторону вписанного в окружность квадрата. Найдём "а" из теоремы R=a/sqrt(2), где R - радиус описанного квадрата, "а" - сторона квадрата. 
            double a = R * Math.Sqrt(2);

            // Теперь найдём площадь вписанного квадрата по формуле S=a*a.
            double S_kvadrata = a * a;

            // Наконец, найдём площадь вписнного правильного треугольника по формуле S=(3*sqrt(3)*R*R)/4
            double S_treugolnika = (3 * Math.Sqrt(3) * R * R) / 4;

            Console.WriteLine("Площадь вписанного квадрата = " + S_kvadrata + "\r\n" +
                              "Площадь вписанного правильного треугольника = " + S_treugolnika);
            Console.ReadKey();
        }
    }