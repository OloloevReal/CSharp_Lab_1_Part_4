using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab_1_Part_4
{
    class Lab_4_4: ILab{

        private readonly string inputText = @"Трудно было более опуститься и обнеряшиться; но Раскольникову это было даже приятно в его теперешнем состоянии духа.";
        public override void Do(){
            Console.WriteLine("Entered text: ");
            Console.WriteLine(inputText);

            var s = Regex.Replace(inputText, @"[о]", "oOk", RegexOptions.IgnoreCase);
            Console.WriteLine("New text: \r\n{0}", s);
            Console.WriteLine();
        }

        public override string Description(){
            return @"4.4. Задан текст. После каждой буквы «о» вставить сочетание «Oк».";
        }
    }
}