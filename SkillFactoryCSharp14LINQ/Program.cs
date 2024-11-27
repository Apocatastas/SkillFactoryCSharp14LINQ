using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillFactoryCSharp14LINQ
{
    class Program
    {
        /// <summary>
        /// Доработайте вашу телефонную книгу из задания 14.2.10 предыдущего юнита так,
        /// чтобы контакты телефонной книги были отсортированы сперва по имени,
        /// а затем по фамилии.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));
            phoneBook.Add(new Contact("Игорь", "Васильев", 79990000001, "igorv@example.com"));
            phoneBook.Add(new Contact("Игорь", "Агафонов", 79990000001, "igora@example.com"));
            phoneBook.Add(new Contact("Сергей", "Кузнецов", 79990000010, "sergek@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Шарапов", 79990000011, "anatolysh@example.com"));
            phoneBook.Add(new Contact("Валерий", "Высоцкий", 79990000012, "valerav@example.com"));
            phoneBook.Add(new Contact("Сергей", "Шаталов", 799900000013, "sergsh@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Иванов", 799900000013, "innokentiivanov@example.com"));
            phoneBook.Add(new Contact("Игорь", "Козлов", 79990000001, "igork@example.com"));
            phoneBook.Add(new Contact("Сергей", "Баранов", 79990000010, "sergeb@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Конев", 79990000011, "anatolyk@example.com"));
            phoneBook.Add(new Contact("Валерий", "Петухов", 79990000012, "valerap@example.com"));
            phoneBook.Add(new Contact("Валерий", "Кипелов", 79990000012, "valera100gradus@example.com"));
            phoneBook.Add(new Contact("Сергей", "Козинский", 799900000013, "sergk@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Фунтиков", 799900000013, "innokentiiph@example.com"));
            while (true)
            {
                var input = Console.ReadKey().KeyChar;
                var parsed = Int32.TryParse(input.ToString(), out int pageNumber);
                if (!parsed || pageNumber < 1 || pageNumber > 4)
                {
                    Console.Clear();
                    Console.WriteLine("Страницы не существует");
                }
                else
                {
                    Console.Clear();
                    var pageContent = phoneBook.Skip((pageNumber - 1) * 5).Take(5).OrderBy(c => c.Name).ThenBy(c => c.LastName);
                    foreach (var entry in pageContent)
                    {
                        Console.WriteLine(entry.Name + " " + entry.LastName + ": " + entry.PhoneNumber);
                    }
                }
            }
        }
    }
}