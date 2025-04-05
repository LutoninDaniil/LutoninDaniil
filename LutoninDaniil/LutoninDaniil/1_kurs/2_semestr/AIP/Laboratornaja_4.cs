/*27.02.2025*/
/*
using System;
using System.Collections.Generic;
internal class Pirog
{
    private static void Main(string[] args)
    {
        Console.Write("Введите строку (элементики через пробельчик): ");
        string[] s = ("" + Console.ReadLine()).Split(" ");
        Stack<float> slomred = new Stack<float>();
        foreach(string i in s)
        {
            if(float.TryParse(i, out float j))
            {
                slomred.Push(j);
            }
            else
            {
                if(slomred.Count <= 1)
                {
                    Console.WriteLine("Neверный ввод уравнения:(");
                    return;
                }
                float reter = 0;
                switch(i)
                {
                    default: Console.WriteLine("Nеверный ввод уравнения:("); 
                    break;
                    case "+":
                        reter = slomred.Pop() + slomred.Pop();
                    break;
                    case "-":
                        reter =- slomred.Pop() + slomred.Pop();
                    break;
                    case "*":
                        reter = slomred.Pop() * slomred.Pop();
                    break;
                    case "/":
                        float a = slomred.Pop();
                        float b = slomred.Pop();
                        if(a == 0)
                        {
                            Console.WriteLine("Nеверный ввод уравнения:(");
                            return;
                        }
                        reter = b / a;
                    break;
                }
                slomred.Push(reter);
            }
        }
        Console.WriteLine("Отvеt: " + slomred.Peek());
    }
}
*/