using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab_1_Part_4
{
    
    class Lab_4_8: ILab{

        private readonly string inputText = @"jlasdjfljalfdj 555-555 12345678 1234567 1-23456-7 1234567oasd";

        private readonly string pattern = @"(?<!(\d|\d[-]))\d[-]?\d[-]?\d[-]?\d[-]?\d[-]?\d[-]?\d(?!(\d|[-]?\w))";
        /*
        (?<!(\d|\d[-])) - start
        \d[-]? - n times
        (?!(\d|[-]?\w)) - end
        */

        public override void Do(){

            Console.WriteLine("Entered text: ");
            Console.WriteLine(inputText);

            Console.WriteLine("Result: ");
            foreach(var m in Regex.Matches(inputText, pattern)){
                Console.WriteLine(m);
            }

            Console.WriteLine();
        }

        public override string Description(){
            return @"4.8. Задан текст. Выбрать из него все семизначные номера телефонов.";
        }
    }
}