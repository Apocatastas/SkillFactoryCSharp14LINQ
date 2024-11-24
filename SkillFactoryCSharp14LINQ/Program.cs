using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillFactoryCSharp14LINQ
{
    class Program
    {
        /// <summary>
        /// Соедините все слова в одну последовательность
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] text = { "Раз два три",
                              "четыре пять шесть",
                              "семь восемь девять" };
            var splittedText = from str in text 
                        from word in str.Split(' ') 
                        select word;
            foreach (var word in splittedText)
            {
                Console.WriteLine(word);
            }
            Console.ReadKey();
        }
    }
}