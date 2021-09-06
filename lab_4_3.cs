using System;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Lab_1_Part_4
{
    class Lab_4_3: ILab{

        private readonly string inputText = @"And so I left the Soviet Union with one suitcase. It was plywood, covered with fabric and, had chrome reinforcements at the corners.";
        private readonly string inputText2 = "Настасья так и покатилась со смеху.";

        //private readonly string pattern = @"\p{IsBasicLatin}";
        
        private readonly string pattern = @"^[a-zA-Z0-9\s`~!@#$%^&*()_+-={}|:;<>?,.\/\""\'\\\[\]]+$";

        public override void Do(){
            Console.WriteLine("Entered text: ");
            Console.WriteLine(inputText);

            Regex RegX = new Regex(pattern);
            Console.WriteLine($"Текст на английском языке? {(RegX.IsMatch(inputText)?"Да!":"Нет!")}");

            Console.WriteLine("Entered text: ");
            Console.WriteLine(inputText2);
            Console.WriteLine($"Текст на английском языке? {(Regex.IsMatch(inputText2, pattern)?"Да!":"Нет!")}");

            Console.WriteLine();
        }

        public override string Description(){
            return @"4.3. Задан текст. Определить, является ли он текстом на английском языке.";
        }
    }
}