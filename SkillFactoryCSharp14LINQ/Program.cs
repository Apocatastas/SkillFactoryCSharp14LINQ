using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillFactoryCSharp14LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

            var wordsInfo = words.Select(w =>
                                            new
                                            {  
                                                Name = w,
                                                Length = w.Length 
                                            })
                                 .OrderBy(word => word.Length);
            foreach (var word in wordsInfo)
            {
                Console.WriteLine($"{word.Name} - {word.Length} букв");
            }
                
            Console.ReadKey();
        }
    }
}