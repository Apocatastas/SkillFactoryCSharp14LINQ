using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillFactoryCSharp14LINQ
{
    class Program
    {
        /// <summary>
        /// Выберите всех студентов моложе 27,
        /// сгенерируйте из них анкеты.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
                                            {
                                                new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                                                new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                                                new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
                                                new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
                                            };

            var youngStudentApplications = from s in students
                                           where s.Age < 27 
                                           let birthYear = DateTime.Now.Year - s.Age
                                           select new Application()
                                           {
                                               Name = s.Name,
                                               YearOfBirth = birthYear
                                           };
            foreach (var studApplication in youngStudentApplications)
            {
                Console.WriteLine(studApplication.Name + ", " + studApplication.YearOfBirth);
            }
                
            Console.ReadKey();

        }
    }
}