using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 6.1, Вариант 9");
            Console.WriteLine("Введите текст на русском языке:");
            string strRu = Console.ReadLine();
            string strCs = Translatе(strRu);
            Console.WriteLine(strCs + "\n");
            Console.WriteLine("Задание 6.2, Вариант 9");
            Console.WriteLine("Дано слово «кратер», получить слова «катер» и «река».\n");
            string strOriginal = "перевозка";
            string strFirstWord = strOriginal[4] + strOriginal.Substring(1, 4) + strOriginal.Substring(7, 2);
            string strSecondWord = strOriginal.Substring(0, 1) + strOriginal[5] + strOriginal.Substring(4, 5);
            Console.WriteLine(strFirstWord + ", " + strSecondWord);
            Console.ReadKey();
        }
        static string Translate(string strRu)
        {
            strRu = strRu.Replace("А", "A");
            strRu = strRu.Replace("Б", "6");
            strRu = strRu.Replace("В", "B");
            strRu = strRu.Replace("Г", "r"); ;
            strRu = strRu.Replace("Д", "D");
            strRu = strRu.Replace("Е", "Е"); ;
            strRu = strRu.Replace("Ё", "E");
            strRu = strRu.Replace("Ж", "}|{");
            strRu = strRu.Replace("З", "3");
            strRu = strRu.Replace("И", "u");
            strRu = strRu.Replace("Й", "u*");
            strRu = strRu.Replace("К", "K");
            strRu = strRu.Replace("Л", "JI");
            strRu = strRu.Replace("М", "M");
            strRu = strRu.Replace("Н", "H");
            strRu = strRu.Replace("О", "O");
            strRu = strRu.Replace("П", "n");
            strRu = strRu.Replace("Р", "P");
            strRu = strRu.Replace("С", "C");
            strRu = strRu.Replace("Т", "T");
            strRu = strRu.Replace("У", "Y");
            strRu = strRu.Replace("Ф", "cp");
            strRu = strRu.Replace("Х", "X");
            strRu = strRu.Replace("Ц", "L|");
            strRu = strRu.Replace("Ч", "4");
            strRu = strRu.Replace("Ш", "LLI");
            strRu = strRu.Replace("Щ", "LLL");
            strRu = strRu.Replace("Ъ", "`b");
            strRu = strRu.Replace("Ы", "bI");
            strRu = strRu.Replace("Ь", "b");
            strRu = strRu.Replace("Э", "-)");
            strRu = strRu.Replace("Ю", "IO");
            strRu = strRu.Replace("Я", "9I");
            return strRu;
        }
        
    }
}