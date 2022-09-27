using System;

namespace task_1
{
    internal class Program
    {
        /*
         1. Создать массив из 10 случайных чисел в диапазоне от 0 до 5. Сжать 
           массив, удалив из него все 0, и заполнить освободившиеся справа 
           элементы значениями -1.
         */

        static void Main(string[] args)
        {
            int count = 10;
            int[] a = new int[count];
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(0, 6); // От 0 до 5.
                Console.Write("{0,4}", a[i]);
            }
            Console.WriteLine();

            int position = -1, zeroCount = 0;
            int len = a.Length - 1;
            for (int i = 0; i < a.Length; i++)
            {
                position = Array.IndexOf(a, 0); // Поиск первого вхождения числа в массив.
                if (position >= 0)
                {
                    zeroCount++;
                    for (int j = position; j < a.Length; j++)
                    {
                        if (j + 1 < a.Length)
                            a[j] = a[j + 1];
                    }

                    if (zeroCount > 0)
                    {
                        a[len--] = -1;
                        zeroCount--;
                    }
                }
                Console.Write("{0,4}", a[i]);
            }
        }
    }
}