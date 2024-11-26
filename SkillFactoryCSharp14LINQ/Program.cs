using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace SkillFactoryCSharp14LINQ
{
    class Program
    {
        /// <summary>
        /// Теперь добавьте всех студентов младше 29 лет,
        /// владеющих английским языком, в курс «Язык программирования C#». 
        ///Новая анонимная сущность для выборки должна иметь следующие поля:
        /// имя(строка);
        /// год рождения студента(целое число);
        /// имя курса(строка).
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            // Список студентов
            var students = new List<Student>
                            {
                                new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                                new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                                new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }}
                            };

            // Список курсов
            var coarses = new List<Coarse>
                            {
                                new Coarse {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
                                new Coarse {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
                            };
        
            var studentsWithCoarses = from stud in students
                                      where stud.Age < 29
                                      where stud.Languages.Contains("английский") 
                                      let birthYear = DateTime.Now.Year - stud.Age
                                      from coarse in coarses
                                      where coarse.Name.Contains("C#")
                                      select new
                                      {
                                          Name = stud.Name,
                                          BirthYear = birthYear,
                                          CoarseName = coarse.Name
                                      };
            foreach (var stud in studentsWithCoarses)
            {
                Console.WriteLine($"Студент {stud.Name} ({stud.BirthYear}) добавлен курс {stud.CoarseName}");
            };
                
            Console.ReadKey();

        }
    }
}