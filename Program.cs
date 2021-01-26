using System;

namespace lab1_1
{
    class Program
    {
        static int[,] FillingTheArray(int[,] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(-10, 10);
                }
            }
            return array;
        }
        static void PrintArray(int[,] array)
        {
            Console.WriteLine("Перелік елементів массиву Е:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0,3} ", array[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть кількість елементів массиву S");
            int n = int.Parse(Console.ReadLine());
            int[] array_S = new int[n];
            int maxnum = int.MinValue;
            int row = 0;
            Console.WriteLine("Введіть елементи массиву");
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                array_S[i] = num;
                if (num > maxnum)
                {
                    maxnum = num;
                    row = i;
                }
            }
            Console.Write(maxnum + "\t" + row);
            int[,] array_E = new int[n, maxnum];
            FillingTheArray(array_E);
            PrintArray(array_E);
            int[][] array_M = new int[n][];
            for (int i = 0; i < n; i++)
            {
                array_M[i] = new int[array_S[i]];
                for (int j = 0; j < array_S[i]; j++)
                {
                    if (i == row)
                    {
                        array_M[i][j] = 0;
                    }
                    else
                    {
                        array_M[i][j] = array_E[i, j];
                    }
                }
            }
            Console.WriteLine("Перелік елементів массиву М:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < array_M[i].Length; j++)
                {
                    Console.Write("{0,3} ", array_M[i][j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
