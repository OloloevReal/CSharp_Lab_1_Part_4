using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab_1_Part_4
{
    class Lab_4_7: ILab{

        private readonly string inputText = @"Информатика (фр. Informatique; англ. Computer science) — наука о методах и процессах сбора, хранения, обработки, передачи, анализа и оценки информации. 
Информатика включает дисциплины, относящиеся к обработке информации. Темами исследований в информатике являются вопросы: что можно, а что нельзя реализовать в программах и базах данных. 
Термины «информология» и «информатика» предложены в 1962 году членом-корреспондентом АН СССР Александром Харкевичем. Информатика делится на ряд разделов. 
Как дисциплина, информатика охватывает широкий круг тем от теоретических исследований алгоритмов и пределов вычислений до практической реализации вычислительных систем.";

        private readonly string pattern = @"(?<=^|[.,!?]{1} )[иИ]нформатика";
        public override void Do(){
            Console.WriteLine("Entered text: ");
            Console.WriteLine(inputText);

            Console.WriteLine("Result: ");
            Console.WriteLine(Regex.Matches(inputText, pattern).Count);

            Console.WriteLine();
        }

        public override string Description(){
            return @"4.7. Задан текст. Определить, сколько предложений начинается со слова ""Информатика"".";
        }
    }
}