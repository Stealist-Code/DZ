using Grandmas;
using Hospitals;
using Practice.Structs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using static Practice.Enums.Exams;
using static Practice.Structs.Student;

namespace Practice
{
    internal class Program_practice
    {
        static void Exercise_1()
        {
            List<Bitmap> imagesList = new List<Bitmap>(64);
            for (int i = 1; i < 33; i++)
            {
                for (int j=1; j < 3; j++)
                {
                    string pictureName = $@"..\..\Files\Images\image{i}-{j}.jpg";
                    Bitmap picture = new Bitmap(pictureName);
                    imagesList.Add(picture);
                }
            }

            Console.WriteLine("Начальный порядок элементов:");
            int[] indexImagesList = Enumerable.Range(0, imagesList.Count).ToArray();
            PrintArray(indexImagesList);

            List<Bitmap> imagesListCopy = new List<Bitmap>(imagesList);
            ShuffleList(imagesList);
            

            int[] indexChange = new int[imagesList.Count];
            for (int i=0; i < imagesListCopy.Count; i++)
            {
                for (int j=0; j < imagesList.Count; j++)
                {
                    int c = 0;
                    if (imagesListCopy[i] == imagesList[j])
                    {
                        indexChange[i] = j;
                    }
                    c++;
                }
            }
            Console.WriteLine("\nИзмененный порядок элементов:");
            PrintArray(indexChange);
        }

        static void ShuffleList(List<Bitmap> imagesList)
        {
            Random random = new Random();
            int n = imagesList.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Bitmap temp = imagesList[i];
                imagesList[i] = imagesList[j];
                imagesList[j] = temp;
            }
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static void Exercise_2()
        {
            string readContent = File.ReadAllText(@"../../Files/Text/Students.txt");
            readContent = readContent.Replace(" ", "");
            string[] studentInfo = readContent.Split('\n');
            string[] name = studentInfo[0].Split(',');
            string[] surname = studentInfo[1].Split(',');
            string[] timeBirth = studentInfo[2].Split(',');
            string[] exams = studentInfo[3].Split(',');
            string[] scores = studentInfo[4].Split(',');
            List<StudentInfo> studentsList = new List<StudentInfo>();

            for (int i = 0; i < name.Length; i++)
            {
                DateTime birthDate = ParseDateTime(timeBirth[i]);
                Exam exam = ParseExam(exams[i]);
                int score = int.Parse(scores[i]);
                studentsList.Add(new StudentInfo(name[i], surname[i], birthDate, exam, score));
            }

            Console.Write("Введите - Новый студент, Удалить или Сортировать: ");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "новый студент":
                    Console.WriteLine("Введите информацию о новом студенте через запятую в одну строку(имя, фамилия, дата рождения, сданный экзамен, количество баллов): ");
                    string[] infoData = (Console.ReadLine()).Replace(" ", "").Split(',');
                    if (infoData.Length != 5)
                    {
                        Console.WriteLine("Неверный формат. Требуется 5 полей.");
                        break;
                    }

                    DateTime birthDate = ParseDateTime(infoData[2]);
                    Exam exam = ParseExam(infoData[3]);
                    int score = int.Parse(infoData[4]);
                    studentsList.Add(new StudentInfo(infoData[0], infoData[1], birthDate, exam, score));
                    Console.WriteLine("Студент успешно добавлен");
                    break;

                case "удалить":
                    RemoveStudent(studentsList);
                    break;

                case "сортировать":
                    SortAndDisplayStudentsByScore(studentsList);
                    break;
            }

        }
        static Exam ParseExam(string examString)
        {
            if (Enum.TryParse<Exam>(examString, out Exam exam))
            {
                return exam;
            }
            throw new ArgumentException($"Неизвестный экзамен: {examString}");
        }

        static DateTime ParseDateTime(string date)
        {
            if (DateTime.TryParse(date, out DateTime birthDate))
            {
                return birthDate;
            }
            throw new ArgumentException($"Неизвестное время: {date}");
        }

        static void RemoveStudent(List<StudentInfo> students)
        {
            Console.Write("Введите фамилию студента для удаления: ");
            string lastName = Console.ReadLine();
            Console.Write("Введите имя студента для удаления: ");
            string firstName = Console.ReadLine();

            var studentToRemove = students.FirstOrDefault(s =>
                s.Surname.Equals(lastName, StringComparison.OrdinalIgnoreCase) &&
                s.Name.Equals(firstName, StringComparison.OrdinalIgnoreCase));
            if (!studentToRemove.Equals(default(StudentInfo)))
            {
                students.Remove(studentToRemove);
                Console.WriteLine("Студент успешно удален!\n");
            }
            else
            {
                Console.WriteLine("Студент не найден!\n");
            }
        }

        static void SortAndDisplayStudentsByScore(List<StudentInfo> students)
        {
            var sortedStudents = students.OrderBy(s => s.Scores).ToList();
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.Surname,-13} | {student.Name,-9} | {student.TimeBirth} | {student.Exam,-15} | {student.Scores}");
            }
            Console.WriteLine();
        }

        static Queue<Grandma> CreateGrandmas()
        {
            var grandmas = new Queue<Grandma>();
            grandmas.Enqueue(new Grandma
            {
                Name = "Александра Ивановна",
                Age = 75,
                Diseases = new List<string> { "Гипертония", "Артрит" },
                Medicines = new List<string> { "Таблетки от давления", "Обезболивающее" }
            });
            grandmas.Enqueue(new Grandma
            {
                Name = "Анна Петровна",
                Age = 80,
                Diseases = new List<string> { "Диабет", "Катаракта" },
                Medicines = new List<string> { "Инсулин", "Глазные капли" }
            });
            grandmas.Enqueue(new Grandma
            {
                Name = "Валентина Спиридонова",
                Age = 78,
                Diseases = new List<string> { "Остеопороз" },
                Medicines = new List<string> { "Кальций" }
            });
            return grandmas;
        }
        // Создает стек больниц
        static Stack<Hospital> CreateHospitals()
        {
            var hospitals = new Stack<Hospital>();
            hospitals.Push(new Hospital
            {
                Name = "Городская больница №1",
                TreatedDiseases = new List<string> { "Гипертония", "Диабет", "Артрит" },
                Capacity = 100,
                CurrentPatients = 45
            });
            hospitals.Push(new Hospital
            {
                Name = "Кардиологический центр",
                TreatedDiseases = new List<string> { "Гипертония", "Аритмия", "Стенокардия" },
                Capacity = 50,
                CurrentPatients = 30
            });
            hospitals.Push(new Hospital
            {
                Name = "Офтальмологическая клиника",
                TreatedDiseases = new List<string> { "Катаракта", "Глаукома" },
                Capacity = 30,
                CurrentPatients = 15
            });
            return hospitals;
        }

        static double CalculateOccupancyPercentage(Hospital hospital)
        {
            return (double)hospital.CurrentPatients / hospital.Capacity * 100;
        }

        static bool CanTreatGrandma(Hospital hospital, Grandma grandma)
        {
            if (grandma.Diseases.Count == 0)
                return true;
            int treatedDiseases = grandma.Diseases.Count(disease =>
                hospital.TreatedDiseases.Contains(disease));
            double treatmentPercentage = (double)treatedDiseases / grandma.Diseases.Count * 100;
            return treatmentPercentage > 50;
        }

        static void DistributeGrandma(Queue<Grandma> grandmas, Stack<Hospital> hospitals)
        {
            if (grandmas.Count == 0)
            {
                Console.WriteLine("Очередь бабуль пуста!\n");
                return;
            }
            Grandma grandma = grandmas.Dequeue();
            Console.WriteLine($"\nРаспределяем бабулю: {grandma.Name}, {grandma.Age} лет");
            if (grandma.Diseases.Count > 0)
            {
                Console.WriteLine($"Болезни: {string.Join(", ", grandma.Diseases)}");
            }
            else
            {
                Console.WriteLine("Болезней нет - хочет просто спросить");
            }
            bool foundHospital = false;
            var hospitalStack = new Stack<Hospital>(hospitals.Reverse());
            foreach (var hospital in hospitalStack)
            {
                if (hospital.CurrentPatients < hospital.Capacity && CanTreatGrandma(hospital, grandma))
                {
                    Console.WriteLine($"Бабуля направлена в: {hospital.Name}");
                    foundHospital = true;
                    break;
                }
            }
            if (!foundHospital)
            {
                Console.WriteLine("Бабуля осталась на улице плакать - подходящей больницы не найдено");
            }
        }

        static void AddNewGrandma(Queue<Grandma> grandmas)
        {
            Console.WriteLine("Добавление новой бабули:");
            Console.Write("Имя: ");
            string name = Console.ReadLine();
            int age;
            while (true)
            {
                Console.Write("Возраст: ");
                if (int.TryParse(Console.ReadLine(), out age) && age > 0)
                    break;
                Console.WriteLine("Ошибка! Введите корректный возраст.");
            }
            Console.WriteLine("Введите болезни через запятую (или оставьте пустым): ");
            string diseasesInput = Console.ReadLine();
            var diseases = string.IsNullOrWhiteSpace(diseasesInput) ?
                new List<string>() :
                diseasesInput.Split(',').Select(d => d.Trim()).ToList();
            Console.WriteLine("Введите лекарства через запятую (или оставьте пустым): ");
            string medicinesInput = Console.ReadLine();
            var medicines = string.IsNullOrWhiteSpace(medicinesInput) ?
                new List<string>() :
                medicinesInput.Split(',').Select(m => m.Trim()).ToList();
            grandmas.Enqueue(new Grandma
            {
                Name = name,
                Age = age,
                Diseases = diseases,
                Medicines = medicines
            });
            Console.WriteLine("Бабуля добавлена в очередь!\n");
        }

        static void DisplayGrandmas(Queue<Grandma> grandmas)
        {
            Console.WriteLine("Список бабуль в очереди:");
            if (grandmas.Count == 0)
            {
                Console.WriteLine("Очередь пуста");
                return;
            }
            int index = 1;
            foreach (var grandma in grandmas)
            {
                Console.WriteLine($"{index}. {grandma.Name}, {grandma.Age} лет");
                if (grandma.Diseases.Count > 0)
                {
                    Console.WriteLine($"   Болезни: {string.Join(", ", grandma.Diseases)}");
                    Console.WriteLine($"   Лекарства: {string.Join(", ", grandma.Medicines)}");
                }
                else
                {
                    Console.WriteLine($"   Болезней нет");
                }
                Console.WriteLine();
                index++;
            }
        }
        // Выводит информацию о всех больницах
        static void DisplayHospitals(Stack<Hospital> hospitals)
        {
            Console.WriteLine("Список больниц:");
            var hospitalList = hospitals.ToList();
            for (int i = 0; i < hospitalList.Count; i++)
            {
                var hospital = hospitalList[i];
                double occupancy = CalculateOccupancyPercentage(hospital);
                Console.WriteLine($"{i + 1}. {hospital.Name}");
                Console.WriteLine($"   Вместимость: {hospital.CurrentPatients}/{hospital.Capacity}");
                Console.WriteLine($"   Заполненность: {occupancy:F1}%");
                Console.WriteLine($"   Лечат: {string.Join(", ", hospital.TreatedDiseases)}");
                Console.WriteLine();
            }
        }
        // Отображает меню
        static void DisplayMenu2()
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Добавить бабулю - добавить новую бабулю в очередь");
            Console.WriteLine("2. Распределить - распределить следующую бабулю по больницам");
            Console.WriteLine("3. Показать бабуль - отобразить список бабуль");
            Console.WriteLine("4. Показать больницы - отобразить список больниц");
            Console.WriteLine("5. Выход - завершить программу");
            Console.Write("Выберите действие: ");
        }

        static void Main(string[] args)
        {
            // Упражнение 1
            Console.WriteLine("Упражнение 1\n");

            Exercise_1();

            // Упражнение 2
            Console.WriteLine("\n\nУпражнение 2\n");

            Exercise_2();

            // Упражнение 3
            Console.WriteLine("\nУпражнение 3\n");

            Console.WriteLine("№3");
            try
            {
                Queue<Grandma> grandmas = CreateGrandmas();
                Stack<Hospital> hospitals = CreateHospitals();
                Console.WriteLine("Система распределения бабуль по больницам");
                bool running = true;
                while (running)
                {
                    DisplayMenu2();
                    string choice = Console.ReadLine().ToLower();
                    switch (choice)
                    {
                        case "1":
                        case "добавить бабулю":
                            AddNewGrandma(grandmas);
                            break;
                        case "2":
                        case "распределить":
                            DistributeGrandma(grandmas, hospitals);
                            break;
                        case "3":
                        case "показать бабуль":
                            DisplayGrandmas(grandmas);
                            break;
                        case "4":
                        case "показать больницы":
                            DisplayHospitals(hospitals);
                            break;
                        case "5":
                        case "выход":
                            running = false;
                            Console.WriteLine("Программа завершена.");
                            break;
                        default:
                            Console.WriteLine("Неверная команда! Попробуйте снова.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }


        }

    }
}
