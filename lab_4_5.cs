using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab_1_Part_4
{
    class Lab_4_5: ILab{

        private readonly string inputText = @"Прежде, говоришь, детей учить ходил, а теперь пошто ничего не делаешь?";
        private readonly string pattern = @"^[а-яА-Я0-9\s`~!@#$%^&*()_+-={}|:;<>?,.\/\""\'\\\[\]]+$";
        public override void Do(){
            Console.WriteLine("Entered text: ");
            Console.WriteLine(inputText);


            Regex RegX = new Regex(pattern);
            Console.WriteLine("Result:");
            Console.WriteLine($"Текст на русском языке? {(RegX.IsMatch(inputText)?"Да!":"Нет!")}");

            Console.WriteLine();
        }

        public override string Description(){
            return @"4.5. Задан текст. Определить, является ли он текстом на русском языке.";
        }
    }
}