using System;
using System.Collections.Generic;

namespace Lab_1_Part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ILab> Labs = new List<ILab>();
            // Labs.Add(new Lab_4_1());
            // Labs.Add(new Lab_4_2());
            // Labs.Add(new Lab_4_3());
            // Labs.Add(new Lab_4_4());
            // Labs.Add(new Lab_4_5());
            // Labs.Add(new Lab_4_6());
            // Labs.Add(new Lab_4_7());
            // Labs.Add(new Lab_4_8());
            // Labs.Add(new Lab_4_9());
            // Labs.Add(new Lab_4_10());
            Labs.Add(new Lab_4_11());
            // Labs.Add(new Lab_4_12());
            // Labs.Add(new Lab_4_13());

            foreach(ILab l in Labs){
                Console.WriteLine(l.Description());
                l.Do();
            }
        }
    }
}
