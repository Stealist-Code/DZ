using Practice.Classes;
using System;
using System.Collections.Generic;
using Practice.Enums;


namespace Practice
{
    internal class Program_practice
    {
        static void Main(string[] args)
        {
            // Создание рабочих
            List<Employee> team = new List<Employee>();
            for (int i = 1; i<11; i++)
            {
                team.Add(new Employee(i, $"Рабочий#{i}", Role.Employee));
            }

            var customer = new Customer(11, "Заказчик", Role.Customer);
            var teamLid = new TeamLider(12, "Тимлид", Role.TeamLider);

            Project project = new Project("Project365", DateTime.Now.AddDays(30), customer, teamLid);

            // Создание задач и присвоение рабочим
            Console.WriteLine("--- Создание задач ---");
            for (int i = 0; i < team.Count; i++)
            {
                project.AddTask(new Task($"None#{i+1}", DateTime.Now.AddDays(7), teamLid, team[i]));
            }

            Console.WriteLine("\n--- Смена статуса проекта ---");
            project.MoveStatus();

            Console.WriteLine("\n--- Операции с задачами ---");
            team[0].Tasks[0].SubmitTask(team[1]); // Делегирование
            team[1].Tasks[0].TakeTask(); // Взял в работу задачу 1
            team[1].Tasks[1].TakeTask(); // Взял в работу задачу 2
            team[2].Tasks[0].RejectTask(); // Отклонил задачу
            team[3].Tasks[0].RejectTaskUpgrade(project); // Отклонение и удаление задачи
            team[4].Tasks[0].RejectTaskUpgrade(project, team[5]); // Отклонение и делегирование
            team[5].Tasks[0].TakeTask();
            team[5].Tasks[1].TakeTask();
            team[6].Tasks[0].RejectTask(); // Отклонил задачу
            team[7].Tasks[0].TakeTask();
            team[8].Tasks[0].TakeTask();
            team[9].Tasks[0].TakeTask();

            project.CloseProject();

            Console.WriteLine("\n--- Операции с задачами у которых нет исполнителя ---");
            foreach (var task in project.GetTasksWithoutExecutor())
            {
                task.SubmitTask(team[9]);
                task.TakeTask();
            }
            project.CheckedNullExecutorInTasks(); // Проверка на исполнителей

            Console.WriteLine("\n--- Возвращение отчета на доработку ---");
            var task1 = project.Tasks[0];
            task1.CreateReport("Разработка");
            customer.AddReport(task1.Report);
            task1.ReturnReport(); // Возвращение отчета на доработку

            project.CloseProject();

            Console.WriteLine("\n--- Утверждение отчетов ---");
            foreach (var task in project.Tasks)
            {
                task.CreateReport("None"); // Создание отчетов
                customer.AddReport(task.Report);
                task.ApproveReport();
            }

            project.CloseProject();

        }
    }
}
