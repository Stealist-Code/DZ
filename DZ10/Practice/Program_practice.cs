using Practice.Classes;
using Practice.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using static Practice.Classes.Person;
using static Practice.Classes.StudentManager;


namespace Practice
{
    
    internal class Program
    {
        static void Exercise_1()
        {
            var s1 = new Student(1, "Игорь", 1, StatusStudent.NormalStudent);
            var s2 = new Student(2, "Игорь", 1, StatusStudent.LazyStudent);
            var s3 = new Student(3, "Игорь", 1, StatusStudent.NormalStudent);
            var s4 = new Student(4, "Игорь", 2, StatusStudent.NormalStudent);
            var s5 = new Student(5, "Игорь", 2, StatusStudent.FreeloaderStudent);
            var s6 = new Student(6, "Игорь", 2, StatusStudent.FreeloaderStudent);
            List<Student> studentss = new List<Student>()
            {
                s1, s2, s3, s4
            };

            SearchStudentInFile();
            Console.WriteLine(StudentManager.Students.Count);

            var students = StudentManager.Students;
            
            
            var Ball = new Event("Балл", new DateTime(2025, 10, 15), 4);
            Ball.AddStudent(studentss);
            Ball.StartEvent();
            VerificationParticipation(Ball);
        }
        
        static void Exercise_2()
        {
            OnReaction += PrintReaction;

            List<Person> people = new List<Person>
            {
                new Person("Саша", Hobby.Serials, "Супер, Новый сериал!"),
                new Person("Иван", Hobby.Games, "Отлично! Оформляю покупку игры."),
                new Person("Маша", Hobby.Books, "Ура, новая книга в коллекции!")
            };

            bool continueProgram = true;

            while (continueProgram)
            {
                Console.WriteLine("\n--- Меню ---");
                Console.WriteLine("1. Показать доступные события");
                Console.WriteLine("2. Ввести событие");
                Console.WriteLine("3. Выход");
                Console.Write("Выберите действие: ");

                string input1 = Console.ReadLine();

                switch (input1)
                {
                    case "1":
                        PrintEnums();
                        break;

                    case "2":
                        Console.Write("\nВведите номер события: ");
                        var input = Console.ReadLine().ToLower();
                        if (Enum.TryParse(input, true, out Hobby eventHobby))
                        {
                            Console.WriteLine($"\nРеакции на событие '{input}':");

                            bool found = false;
                            foreach (var person in people)
                            {
                                if (person.ReactEvent(eventHobby))
                                {
                                    found = true;
                                }
                            }
                            if (!found)
                                Console.WriteLine("Никто не интересуется этим событием");
                        }
                        else
                        {
                            Console.WriteLine("Такого события нет в списке");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Программа завершена");
                        continueProgram = false;
                        break;

                    default:
                        Console.WriteLine("Неверный выбор");
                        break;
                }
            }
            OnReaction -= PrintReaction;
        }
        static void PrintReaction(string personName, string reaction)
        {
            Console.WriteLine($"{personName}: {reaction}");
        }
        
        static void PrintEnums()
        {
            Console.WriteLine("\n--- Список событий. ---");
            foreach (Hobby hobby in Enum.GetValues(typeof(Hobby)))
            {
                Console.WriteLine($"{(int)hobby} - {hobby}");
            }
        }

        static void Main()
        {
            // Упражнение 1
            Console.WriteLine("Упражнение 1\n");
            Exercise_1();

            // Упражнение 2
            Console.WriteLine("\nУпражнение 2");
            Exercise_2();
        }
    }
}
