using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab_1_Part_4
{
    class Lab_4_6: ILab{

        private readonly string inputText = @"Уже больше пятидесяти лет общепризнанно, что в «1984» наиболее полно раскрыта тема тоталитаризма вообще и механизмов его поддержки в фимозгах граждан в частности.";
        private readonly string pattern = @"[\d]+";
        public override void Do(){
            Console.WriteLine("Entered text: ");
            Console.WriteLine(inputText);

            Console.WriteLine("Result:");
            Console.WriteLine($"Содержит цифры? {(Regex.IsMatch(inputText, pattern)?"Да!":"Нет!")}");

            Console.WriteLine();
        }

        public override string Description(){
            return @"4.6. Задан текст. Определить, содержит ли он цифры.";
        }
    }
}