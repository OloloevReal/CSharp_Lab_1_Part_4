using System;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Lab_1_Part_4
{
    class Lab_4_3: ILab{

        private readonly string inputText = @"And so I left the Soviet Union with one suitcase. It was plywood, covered with fabric and, had chrome reinforcements at the corners. 
The lock didn’t work; I had to wind clothes line around it.";
        private readonly string inputText2 = "как то так это все выглядеть будет. только не забудь символы добавить в регулярное выражение в виде пробелов точек итд";
        //private readonly string pattern = @"\p{IsBasicLatin}";
        
        private readonly string pattern = @"^[a-zA-Z0-9\s`~!@#$%^&*()_+-={}|:;<>?,.\/\""\'\\\[\]]+$";

        public override void Do(){
            Console.WriteLine("Source text: ");
            Console.WriteLine(inputText);

            Regex RegX = new Regex(pattern);
            Console.WriteLine($"Текст на английском языке? {(RegX.IsMatch(pattern)?"Да!":"Нет!")}");
            Console.WriteLine($"Текст на английском языке? {(Regex.IsMatch(inputText2,pattern)?"Да!":"Нет!")}");
        }

        public override string Description(){
            return @"4.3. Задан текст. Определить, является ли он текстом на английском языке.";
        }
    }
}