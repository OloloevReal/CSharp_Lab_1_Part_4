using System;
using System.Text.RegularExpressions;

namespace Lab_1_Part_4
{
    class Lab_4_11: ILab{
        private readonly string inputText = @"В эт0м предложении есть цифра и число 23. А в эт0м чисел нет. И еще одно число -10.";
        private readonly string pattern = @"[-]?\b[\d]+\b";
        public override void Do(){
            Console.WriteLine("Entered text: ");
            Console.WriteLine(inputText);


            Console.WriteLine("Result: ");
            var matches = Regex.Matches(inputText, pattern);

            var multip = 0;
            var value = 0;
            for(int i = 0; i < matches.Count; i++){
                value = 0;
                if(!Int32.TryParse(matches[i].ToString(), out value)) continue;
                Console.Write($"{(i!=0?" * ":"")}{matches[i]}");
                
                if(i == 0){
                    multip = value;
                }else{
                    multip *= value;
                }
            }
            Console.WriteLine($" = {multip}");
            Console.WriteLine();
        }

        public override string Description(){
            return @"4.11. Задан текст, содержащий буквы и цифры. Найти произведение всех чисел в тексте.";
        }
    }
}