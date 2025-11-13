using Practice.Classes;
using Practice.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Classes
{
    class Project
    {
        public string Description { get; set; }
        public DateTime Deadlines { get; set; }
        public Customer Customer { get; set; }
        public TeamLider TeamLeader { get; set; }
        public List<Task> Tasks { get; private set; } = new List<Task>();
        public ProjectStatus Status { get; set; }

        public Project(string description, DateTime deadlines, Customer customer, TeamLider teamLeader, List<Task> tasks)
        {
            Description = description;
            Deadlines = deadlines;
            Customer = customer;
            TeamLeader = teamLeader;
            Tasks = tasks;
            Status = ProjectStatus.Project;
        }

        public Project(string description, DateTime deadlines, Customer customer, TeamLider teamLeader)
        {
            Description = description;
            Deadlines = deadlines;
            Customer = customer;
            TeamLeader = teamLeader;
            Status = ProjectStatus.Project;
        }

        public void AddTask(Task task)
        {
            if (Status == ProjectStatus.Project)
            {
                Tasks.Add(task);
                task.Executor.SetTask(task);
                Console.WriteLine($"Успешно. Задача {task.Description} добавлена.");
            }
            else
            {
                Console.WriteLine($"Отклонено. Не удалось добавить задачи, так как проект имеет статус: {Status}");
            }
        }

        public void RemoveTask(Task task)
        {
            if (Status != ProjectStatus.Closed)
            {
                Tasks.Remove(task);
                task.Executor.DeleteTask(task);
                Console.WriteLine($"Успешно. Задача {task.Description} удалена.");
            }
            else
            {
                Console.WriteLine($"Отклонено. Не удалось удалить задачу, так как проект имеет статус: {Status}");
            }
        }
        
        public void MoveStatus()
        {
            if (Status == ProjectStatus.Project)
            {
                Status = ProjectStatus.Execution;
                Console.WriteLine($"Успешно. Изменен статус проекта {Description} на {Status}.");
            }
            else
            {
                Console.WriteLine($"Отклонено. Не удалось изменить статус, так как проект имеет статус: {Status}");
            }
        }

        public void CheckedNullExecutorInTasks()
        {
            Console.WriteLine("\n--- Проверка задач не имеющих исполнителей ---");
            if (Tasks.All(t => t.Status == TaskStatus.InWork))
            {
                Console.WriteLine("Успешно. Все задачи имеют исполнителей.");
            }
            else
            {
                Console.WriteLine("Отклонено. Имеются задачи без исполнителей.");
            }
        }
        public List<Task> GetTasksWithoutExecutor()
        {
            return Tasks.Where(t => t.Executor == null).ToList();
        }

        public void CloseProject()
        {
            Console.WriteLine("\n--- Закрытие проекта ---");
            if (Status == ProjectStatus.Execution && Tasks.All(t => t.Status == TaskStatus.Сompleted))
            {
                Status = ProjectStatus.Closed;
                Console.WriteLine($"Проект {Description} закрыт! Все задачи выполнены.");
            }
            else
            {
                var completedTasks = Tasks.Count(t => t.Status == TaskStatus.Сompleted);
                Console.WriteLine($"Нельзя закрыть проект, так как выполнено {completedTasks} из {Tasks.Count} задач");
            }
        }
    }
}
