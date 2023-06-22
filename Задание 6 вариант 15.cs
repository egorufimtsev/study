using System;

namespace ConsoleApp3
{
    public class N6V15
    {
        private static void Main()
        {
            Console.Write("Введите текст: ");
            var text = Console.ReadLine();
            var translation = GetTranslation(text);
            Console.WriteLine($"Перевод: {translation}");

            GetWords();
        }

        private static string GetTranslation(string originalText)
            => originalText
                .Replace("А", "A")
                .Replace("а", "A")
                .Replace("Б", "6")
                .Replace("б", "6")
                .Replace("В", "B")
                .Replace("в", "B")
                .Replace("Г", "r")
                .Replace("г", "r")
                .Replace("Д", "D")
                .Replace("д", "D")
                .Replace("Е", "Е")
                .Replace("е", "Е")
                .Replace("Ё", "E")
                .Replace("ё", "E")
                .Replace("Ж", "}|{")
                .Replace("ж", "}|{")
                .Replace("З", "3")
                .Replace("з", "3")
                .Replace("И", "u")
                .Replace("и", "u")
                .Replace("Й", "u*")
                .Replace("й", "u*")
                .Replace("К", "K")
                .Replace("к", "k")
                .Replace("Л", "JI")
                .Replace("л", "JI")
                .Replace("М", "M")
                .Replace("М", "M")
                .Replace("Н", "H")
                .Replace("н", "H")
                .Replace("О", "O")
                .Replace("о", "O")
                .Replace("П", "n")
                .Replace("п", "n")
                .Replace("Р", "P")
                .Replace("р", "p")
                .Replace("С", "C")
                .Replace("с", "C")
                .Replace("Т", "T")
                .Replace("т", "T")
                .Replace("У", "Y")
                .Replace("у", "y")
                .Replace("Ф", "cp")
                .Replace("ф", "cp")
                .Replace("Х", "X")
                .Replace("х", "x")
                .Replace("Ц", "L|")
                .Replace("ц", "L|")
                .Replace("Ч", "4")
                .Replace("ч", "4")
                .Replace("Ш", "LLI")
                .Replace("ш", "LLI")
                .Replace("Щ", "LLL")
                .Replace("щ", "LLL")
                .Replace("Ъ", "`b")
                .Replace("ъ", "`b")
                .Replace("Ы", "bI")
                .Replace("ы", "bI")
                .Replace("Ь", "b")
                .Replace("ь", "b")
                .Replace("Э", "-)")
                .Replace("э", "-)")
                .Replace("Ю", "IO")
                .Replace("ю", "IO")
                .Replace("Я", "9I")
                .Replace("я", "9I");

        private static void GetWords()
        {
            const string originalWord = "гардероб";
            var arraySubstring = originalWord[..4].ToCharArray();
            Array.Reverse(arraySubstring);
            
            Console.WriteLine(new string( arraySubstring) + originalWord[1]);

            arraySubstring = originalWord.Substring(2,4).ToCharArray();
            Array.Reverse(arraySubstring);
            
            Console.WriteLine(originalWord[7] + new string(arraySubstring) + originalWord[6]);

        }
    }
    
}