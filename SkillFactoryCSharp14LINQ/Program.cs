using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillFactoryCSharp14LINQ
{
    class Program
    {
        /// <summary>
        /// Сделайте выборку всех чисел в новую коллекцию, расположив их в ней по возрастанию.
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var numsList = new List<int[]>()
                                {
                                    new[] {2, 3, 7, 1},
                                    new[] {45, 17, 88, 0},
                                    new[] {23, 32, 44, -6},
                                };
            var orderedList = numsList.SelectMany(s => s).OrderBy(s => s);

            foreach (var item in orderedList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}