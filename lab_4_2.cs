using System;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Lab_1_Part_4
{
    
    class Lab_4_2: ILab{
        private readonly string[] inputText = {
            @"Впрочем, на этот раз страх встречи с своею кредиторшей даже его самого поразил по выходе на улицу.",
            @"<HTML lang=""ru""><HEAD><TITLE>Ф. М. Достоевский. Преступление и наказание. Текст произведения</TITLE></HEAD><BODY></BODY></HTML>",
            @"<HEAD><TITLE>Ф. М. Достоевский. Преступление и наказание. Текст произведения</TITLE></HEAD>"
        };

        //private readonly string[] htmlTags = {"<html>", "<head>", "<body>"};
        private readonly string pattern = @"(<html.*>)([\s\S]*<title>[\s\S])([\s\S]*<body>)";//@"/<html.*?>*?<\/html>/ig";
        public override void Do(){
            // StringBuilder StrB = new StringBuilder();
            // StrB.Append("/");
            // foreach(var tag in htmlTags){
            //     StrB.Append($"({tag})");
            // }
            // //StrB.Remove(StrB.Length-1,1);
            // StrB.Append("/");
            
            Console.WriteLine(pattern);

            Regex regx = new Regex(pattern);
            //Regex regx = new Regex("(?=.*head)(?=.*title)(?=.*bodd)");
            var m = regx.Match(inputText[1].ToLower());
            
        }

        public override string Description(){
            return @"4.2. Задан текст. Определить, является ли он кодом HTML : содержит теги <html>, <form>, <h1>.";
        }
    }
}