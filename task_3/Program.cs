using System;
using System.Collections;

namespace task_3
{
    internal class Program
    {
        /*
         3. Дан двумерный массив размерностью N x M, заполненный 
           случайными числами из диапазона от 0 до 100. Выполнить 
           циклический сдвиг массива на заданное количество столбцов. 
           Направление сдвига задаёт пользователь.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Введите N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите M: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            int[,] intArray = new int[N, M];

            Console.WriteLine("Исходный массив :");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    intArray[i, j] = r.Next(0, 101);
                    Console.Write("{0,4}", intArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int choice;
            do
            {
                Console.WriteLine("Задайте направление:");
                Console.WriteLine("1 - влево");
                Console.WriteLine("2 - вправо");
                choice = Convert.ToInt32(Console.ReadLine());

            } while (choice != 1 && choice != 2);

            Console.WriteLine("Задайте количество: ");
            int count = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {

                case 1:

                    for (int k = 0; k < count; k++)
                    {
                        for (int i = 0; i < N; i++)
                        {
                            int tmp = intArray[i, 0];
                            for (int j = 0; j < M - 1; j++)
                                intArray[i, j] = intArray[i, j + 1];
                            intArray[i, M - 1] = tmp;
                        }
                    }
                    break;

                case 2:

                    for (int k = 0; k < count; k++)
                    {
                        for (int i = 0; i < N; i++)
                        {
                            int tmp = intArray[i, M - 1];
                            for (int j = M - 1; j > 0; j--)
                                intArray[i, j] = intArray[i, j - 1];
                            intArray[i, 0] = tmp;
                        }
                    }
                    break;
            }

            Console.WriteLine("Результат:");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write("{0,4}", intArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}