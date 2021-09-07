using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Lab_1_Part_4
{
    class Lab_4_13: ILab{
        private readonly string inputText = @"Регулярное выражение - это шаблон, применяемый к заданному тексту слева направо.";
        private readonly string pattern = @"(?i)[бвгджзлмнрхцчщпфктшс]";
        /*
        (?i) - ignore case and using unicode
        */
        public override void Do(){
            Console.WriteLine("Entered text: ");
            Console.WriteLine(inputText);
            Console.WriteLine($"Pattern: {pattern}\r\n");

            var ms = Regex.Matches(inputText, pattern);
            Console.WriteLine("Result: ");
            Console.WriteLine($"Symbols: {ms.Count}\r\n");

           foreach(var item in ms.GroupBy(x => x.Value).ToDictionary(x => x.Key, v => v.Count())){
               Console.WriteLine($"Char: {item.Key} = {item.Value}");
           }

           Console.WriteLine();
           
        }

        public override string Description(){
            return @"4.13. Задан текст. Определить количество согласных букв в нем и распечатать их.";
        }
    }
}