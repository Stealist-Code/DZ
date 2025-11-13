using Practice.Enums;
using System;
using System.Collections.Generic;

namespace Practice.Classes
{
    class Task
    {
        public string Description { get; set; }
        public DateTime Deadlines { get; set; }
        public TeamLider TeamLeader { get; set; }
        public Employee Executor { get; set; }
        public TaskStatus Status { get; set; }
        public Report Report { get; set; }

        public Task(string description, DateTime deadlines, TeamLider teamLeader, Employee executor)
        {
            Description = description;
            Deadlines = deadlines;
            TeamLeader = teamLeader;
            Executor = executor;
            Status = TaskStatus.Assigned;
        }

        public void TakeTask()
        {
            if (Status == TaskStatus.Assigned && Executor != null)
            {
                Status = TaskStatus.InWork;
                Console.WriteLine($"Успешно. {Executor.Name} взял задачу {Description}");
            }
            else
            {
                Console.WriteLine($"Отклонено. Статус задачи: {Status}, Исполнитель: {(Executor != null ? Executor.Name : "Отсутствует")}");
            }
        }
        public void SubmitTask(Employee person)
        {
            if (Status == TaskStatus.Assigned)
            {
                Executor = person;
                Executor.SetTask(this);
                Console.WriteLine($"Успешно. Задача {Description} делегирована разработчику {person.Name}");
            }
            else
            {
                Console.WriteLine($"Отклонено. Задачу {Description} нельзя делегировать, так как его статус - {Status}");
            }
        }
        public void RejectTaskUpgrade(Project project, Employee person =null)
        {
            if (Status == TaskStatus.Assigned)
            {
                if (person != null)
                {
                    Executor.DeleteTask(this);
                    Executor = person;
                    Executor.SetTask(this);
                }
                else
                {
                    project.RemoveTask(this);
                }
            }
        }
        public void RejectTask()
        {
            if (Status == TaskStatus.Assigned)
            {
                Console.WriteLine($"Успешно. {Executor.Name} отказался от задачи {Description}");
                Executor.DeleteTask(this);
                Executor = null;
            }
            else
            {
                Console.WriteLine($"Отклонено. {Executor.Name} не смог отказаться от задачи.");
            }
        }
        public void CreateReport(string text)
        {
            if (Status == TaskStatus.InWork)
            {
                Report = new Report(text, DateTime.Now, Executor);
                Status = TaskStatus.UnderReview;
                Console.WriteLine($"Создан отчет {text} для задачи {Description}");
            }
            else
            {
                Console.WriteLine($"Отклонено. Отчет {text} не создан");
            }      
        }
        public void ApproveReport()
        {
            if (Status == TaskStatus.UnderReview && Report != null)
            {
                Status = TaskStatus.Сompleted;
                Console.WriteLine($"Успешно. Отчет по задаче {Description} утвержден, задача завершена");
            }
            else
            {
                Console.WriteLine($"Отклонено. Статус: {Status}, отчет: {(Report != null ? Report.Text : "Отсутствует")}");
            }
        }

        public void ReturnReport()
        {
            if (Status == TaskStatus.UnderReview && Report != null)
            {
                Status = TaskStatus.InWork;
                Console.WriteLine($"Успешно. Отчет по задаче {Description} возвращен на доработку");
            }
            else
            {
                Console.WriteLine($"Отклонено. Статус: {Status}, отчет: {(Report != null ? Report.Text : "Отсутствует")}");
            }
        }
    }
}
