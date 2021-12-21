using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regextext
{
    public class Regtext1
    {
        public void regtext1()
        {
            string str = Console.ReadLine();
            Regex regex = new Regex("code");

            if (regex.IsMatch(str))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        public void regreplace()
        {
            string str = Console.ReadLine();
            string pattern = @"\W?(а)";
            string replacement1 ="о";

            str = Regex.Replace(str, pattern, replacement1);
            Console.WriteLine("\nВидоизмененная строка: \n" + str);
        }
        public void regciv()
        {
            string str = Console.ReadLine();
            Regex regex = new Regex(@"\d");
            int g = 0;

            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    g++;
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            Console.WriteLine($"Количество цифр: {g}");
        }
        public void regmail()
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            while (true)
            {
                Console.WriteLine("Введите адрес электронной почты");
                string email = Console.ReadLine();
                

                if (Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("Email подтвержден");
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный email");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Regex regex = new Regex(@"""\w+""(?=:)");
            Match match = regex.Match(str);
            int d = 0;
            if (match.Success)
            {
                d += Convert.ToInt32(regex.Matches(str).Count);
                match = match.NextMatch();
            }
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
