using System;
using static Tumakov.Second;


namespace Tumakov
{
    internal class Program_tumakov
    {

        static void Main(string[] args)
        {
            // Упражнение 3.1
            Console.WriteLine("Упражнение 3.1\n");

            bankAccount account = (bankAccount)0;
            Console.WriteLine(account);

            // Упражнение 3.2
            Console.WriteLine("\nУпражнение 3.2\n");

            infoBankAccount infoBA;
            infoBA.number = 94184359;
            infoBA.type = "Current";
            infoBA.balance = 52_000;

            Console.WriteLine($"Банковский счет:\n Номер: {infoBA.number}\n Тип: {infoBA.type}\n Баланс: {infoBA.balance}");

            // Дз 3.1
            Console.WriteLine("\nДз 3.1\n");

            worker person1;
            (person1.name, person1.univ) = ("Олег", (university)2);
            Console.WriteLine($"Имя: {person1.name}\nМесто работы: {person1.univ}");


        }
    }
}
