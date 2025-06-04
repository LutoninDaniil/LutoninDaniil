/*19.05.2025*/
/*
using System;
class Program
{
    unsafe static void Main()
    {
        Console.Write("Введите размерчик массива: ");
        int zise = int.Parse(Console.ReadLine());
        int* erb = stackalloc int[zise];
        for (int i = 0; i < zise; i++)
        {
            Console.Write($"Введите элементик {i + 1}: ");
            erb[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Палиндромчики: ");
        for (int i = 0; i < zise; i++)
        {
            int opk = erb[i];
            string opkS = opk.ToString();
            bool Pal = true;
            for (int j = 0; j < opkS.Length / 2; j++)
            {
                if (opkS[j] != opkS[opkS.Length - 1 - j])
                {
                    Pal = false;
                    break;
                }
            }
            if (Pal)
            {
                Console.Write(opk + " ");
            }
        }
        Console.WriteLine();
    }
}
*/