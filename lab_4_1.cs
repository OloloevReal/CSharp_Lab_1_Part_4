using System;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Lab_1_Part_4
{
    class Lab_4_1: ILab{

        private readonly string inputText = @"Порфирий Петрович несколько мгновений стоял, как бы вдумываясь, но вдруг опять вспорхнулся и замахал руками на непрошеных свидетелей. 
Те мигом скрылись, и дверь притворилась. Затем он поглядел на стоявшего в углу Раскольникова, дико смотревшего на Николая, 
и направился было к нему, но вдруг остановился, посмотрел на него, перевел тотчас же свой взгляд на Николая, 
потом опять на Раскольникова, потом опять на Николая и вдруг, как бы увлеченный, опять набросился на Николая.";

        private readonly string inputWord = "Николая";

        public override void Do(){
            Console.WriteLine("Sourse text: ");
            Console.WriteLine(inputText);
            Console.WriteLine($"Entered word: {inputWord}");

            Regex pat = new Regex(inputWord);
            var ms = pat.Matches(inputText);
            Console.WriteLine($"Found: {ms.Count}");

            Console.WriteLine();       
        }

        public override string Description(){
            return @"4.1. Задан текст. Определить, входит ли в него заданное слово и сколько раз.";
        }
    }
}