using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillFactoryCSharp14LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var objects = new List<object>()
            {
               1,
               "Сергей ",
               "Андрей ",
               300,
            };

            foreach (var stringObject in objects.Where(o => o is string).OrderBy(o => o))
                Console.WriteLine(stringObject);
        }
    }
}