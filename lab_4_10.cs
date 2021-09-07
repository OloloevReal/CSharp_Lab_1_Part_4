using System;
using System.Text.RegularExpressions;

namespace Lab_1_Part_4
{
    class Lab_4_10: ILab{
        private readonly string inputText = @"Выполненые задания направляйте на почту olololo@mail.ru и дублируйте на qwerty.qerty@gmail.com";
        private readonly string pattern = @"([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}";
        public override void Do(){
            Console.WriteLine("Entered text: ");
            Console.WriteLine(inputText);


            Console.WriteLine("Result: ");
            foreach (var m in Regex.Matches(inputText, pattern))
            {
                Console.WriteLine(m);
            }

            Console.WriteLine();
        }

        public override string Description(){
            return @"4.10. Задан текст. Выбрать из него все e-mail адреса.";
        }
    }
}