using System;
using System.Text.RegularExpressions;

namespace Lab_1_Part_4
{
    class Lab_4_12: ILab{
        private readonly string inputText = @"Утверждения - это проверки касательно символов, идущих до или после текущей позиции сопоставления, 
ничего при этом не поглощая (никакие символы исходного текста не ставятся в соответствие утверждениям).";
        private readonly string pattern = @"\b[а-яА-Я]+\b";
        public override void Do(){
            Console.WriteLine("Entered text: ");
            Console.WriteLine(inputText);

            Console.WriteLine("Result: ");
            foreach (var m in Regex.Matches(inputText, pattern)){
                Console.WriteLine(m);
            }

            Console.WriteLine();
        }

        public override string Description(){
            return @"4.12. Задано предложение. Распечатать все слова в столбик.";
        }
    }
}