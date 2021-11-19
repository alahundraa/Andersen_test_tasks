using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Вячеслав";
            Console.Write("Введите имя: ");
            string str = Console.ReadLine();
            if (name == str)
                Console.WriteLine("Привет, Вячеслав");
            else
                Console.WriteLine("Нет такого имени");
        }
    }
}
