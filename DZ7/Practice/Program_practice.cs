using Practice.Classes;
using Practice.Enums;
using System;
using System.Collections.Generic;

namespace Practice
{
    internal class Program_practice
    {
        static bool AssignTask(Employee fromPerson, Employee toPerson, Task task)
        {
            if (toPerson.Head.Contains(fromPerson) && task.Type == toPerson.Departament)
            {
                Console.WriteLine($"От {fromPerson.Name} даётся задача \"{task.Name}\" {toPerson.Name}. Берет задачу.");
                return true;
            }
            else
            {
                Console.WriteLine($"От {fromPerson.Name} даётся задача \"{task.Name}\" {toPerson.Name}. Не берет задачу.");
                return false;
            }
        }

        static void Main(string[] args)
        {
            // Постройка иерархии
            Employee timur = new Employee("Тимур", Enums.DepartamentType.Managment);
            Employee rashid = new Employee("Рашид", Enums.DepartamentType.Managment);
            Employee Oilham = new Employee("О Ильхам", Enums.DepartamentType.Managment);
            timur.AddSubordinates(rashid, Oilham);
            rashid.AddHead(timur);
            Oilham.AddHead(timur);

            Employee orkadi = new Employee("Оркадий", Enums.DepartamentType.Managment);
            Employee lukas = new Employee("Лукас", Enums.DepartamentType.Managment);
            Oilham.AddSubordinates(orkadi);
            rashid.AddSubordinates(lukas);
            orkadi.AddHead(Oilham);
            lukas.AddHead(rashid);

            Employee sergey = new Employee("Сергей", Enums.DepartamentType.Managment);
            Employee ilshat = new Employee("Ильшат", Enums.DepartamentType.Managment);
            Employee vladimir = new Employee("Владимир", Enums.DepartamentType.Managment);
            orkadi.AddSubordinates(vladimir, sergey, ilshat);
            vladimir.AddSubordinates(sergey, ilshat);
            ilshat.AddHead(vladimir, orkadi);
            sergey.AddHead(vladimir, orkadi);
            vladimir.AddHead(orkadi);

            Employee ivanuch = new Employee("Иваныч", Enums.DepartamentType.Managment);
            Employee lacian = new Employee("Ляйсан", Enums.DepartamentType.Managment);
            sergey.AddSubordinates(lacian);
            ilshat.AddSubordinates(ivanuch);
            lacian.AddHead(sergey);
            ivanuch.AddHead(ilshat);

            Employee djenya = new Employee("Женя", Enums.DepartamentType.Systems);
            Employee ilya = new Employee("Илья", Enums.DepartamentType.Systems);
            Employee vitya = new Employee("Витя", Enums.DepartamentType.Systems);
            Employee marat = new Employee("Марат", Enums.DepartamentType.Development);
            Employee dina = new Employee("Дина", Enums.DepartamentType.Development);
            Employee ildar = new Employee("Ильдар", Enums.DepartamentType.Development);
            Employee anton = new Employee("Антон", Enums.DepartamentType.Development);
            Employee oleg = new Employee("Олег", Enums.DepartamentType.Finance);
            lukas.AddSubordinates(oleg);
            oleg.AddHead(lukas);
            lacian.AddSubordinates(marat, dina, ildar, anton);
            ivanuch.AddSubordinates(djenya, ilya, vitya);
            djenya.AddHead(ivanuch);
            ilya.AddHead(ivanuch);
            vitya.AddHead(ivanuch);
            marat.AddHead(lacian);
            dina.AddHead(lacian);
            ildar.AddHead(lacian);
            anton.AddHead(lacian);

            // список с задачами
            List<Task> tasks = new List<Task>
            {
                new Task ( "Автоматизация бухгалтерии", DepartamentType.Development ),
                new Task ( "Настройка сети", DepartamentType.Systems ),
                new Task ( "Отчет по финансам", DepartamentType.Finance ),
                new Task ( "Разработка ПО", DepartamentType.Development ),
                new Task ( "Обновление серверов", DepartamentType.Systems ),
                new Task ( "Сокращение рабочих мест", DepartamentType.Managment),
                new Task ( "Повышение эффективности бизнес-процессов", DepartamentType.Managment)
            };

            // пример выдачи задач
            AssignTask(orkadi, sergey, tasks[5]); // Оркадий -> Сергей (true)
            AssignTask(vladimir, ilshat, tasks[5]); // Володя -> Ильшат (true)
            AssignTask(Oilham, orkadi, tasks[6]); // О Ильхам -> Оркадий (true)
            AssignTask(lukas, rashid, tasks[2]); // Лукас -> Рашид (false)
            AssignTask(sergey, lacian, tasks[5]); // Сергей -> Ляйсан (true)
            AssignTask(lacian, dina, tasks[0]); // Ляйсан -> Дина (true)
            AssignTask(ilshat, ivanuch, tasks[6]); // Ильшат -> Иваныч (true)
            AssignTask(ivanuch, ilya, tasks[1]); // Иваныч -> Илья (true)
            AssignTask(timur, Oilham, tasks[6]); // Тимур -> О Ильхам (true)
            AssignTask(dina, sergey, tasks[3]); // Дина -> Сергей (false)
            AssignTask(timur, sergey, tasks[2]); // Тимур -> Сергей (false)
        }
    }
}
