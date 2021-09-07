using System;
using System.Text.RegularExpressions;

namespace Lab_1_Part_4
{
    class Lab_4_9: ILab{       
        private readonly string inputText = @"В эт0м предложении есть цифра и число 23. А в эт0м чисел нет.";
        private readonly string pattern = @"(\d)+";
        public override void Do(){
            Console.WriteLine("Entered text: ");
            Console.WriteLine(inputText);


            Console.WriteLine("Result: ");

            Console.WriteLine(Regex.IsMatch(inputText, pattern)?"Yes!":"No!");
        }

        public override string Description(){
            return @"4.9. Задан текст. Определить, содержит ли он цифры.";
        }
    }
}