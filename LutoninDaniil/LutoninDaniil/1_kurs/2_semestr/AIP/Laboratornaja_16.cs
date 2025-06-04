/*22.05.2025*/
/*
using System;
using System.Collections.Generic;
internal class Program
{
    private unsafe static void Main(string[] args)
    {
        Console.WriteLine("Введите текстик:");
        string kloun = "";
        while (true)
        {
            string f = "" + Console.ReadLine();
            if (f == "") break;
            kloun += f;
        }
        int* gambol = stackalloc int[128];
        foreach (char i in kloun)
        {
            gambol[i] += 1;
        }
        for (int i = 0; i < 128; i++)
        {
            if (gambol[i] == 0) continue;
            Console.WriteLine(((char)i) + ": " + gambol[i]);
        }
    }
}
*/