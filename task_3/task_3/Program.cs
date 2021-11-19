using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Исходный массив: ");

            int[] arr = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();

            Console.Write("Числа, кратные 3: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                    Console.Write(arr[i] + " ");
            }

        }

    }
}
    
