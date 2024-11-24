using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillFactoryCSharp14LINQ
{
    class Program
    {
        /// <summary>
        /// А теперь попробуйте выбрать все города, название у которых не длиннее 10 букв,
        /// и отсортируйте их по длине названия.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var russianCities = new List<City>();
            russianCities.Add(new City("Москва", 11900000));
            russianCities.Add(new City("Санкт-Петербург", 4991000));
            russianCities.Add(new City("Волгоград", 1099000));
            russianCities.Add(new City("Казань", 1169000));
            russianCities.Add(new City("Севастополь", 449138));

            var bigCities = russianCities.Where(c => c.Name.Length <= 10).OrderByDescending(c => c.Name.Length);

            foreach (var bigCity in bigCities)
                Console.WriteLine(bigCity.Name + " - " + bigCity.Population);
            Console.ReadKey();
        }
    }
}