/*06.12.2024*/
using System;
/*
class Podmoga
{
    private int a, b;
    public Podmoga()
    {
        a = 0;
        b = 0;
    }
    public Podmoga(int a)
    {
        this.a = a;
        b = 0;
    }
    public Podmoga(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public void S()
    {
        Console.WriteLine("Сумма: "+(a + b));
    }
    public void U()
    {
        Console.WriteLine("Произведение: "+(a * b));
    }
    public void D()
    {
        if(b != 0)
        {
            Console.WriteLine("Частное: "+(a / b));
        }
        else
        {
            Console.WriteLine("Деление невозможно:(");
        }
    }
    public void V()
    {
        Console.WriteLine("Разность 1: "+(a - b));
        Console.WriteLine("Разность 2: "+(b - a));
    }
}
class L9
{
    static void Main(string[] japi)
    {
        Podmoga zic = new Podmoga();

        Console.Write("Ввод: " + '\n');
        bool u1 = int.TryParse(Console.ReadLine(), out int a);
        bool u2 = int.TryParse(Console.ReadLine(), out int b);
        if(u1 && u2)
        {
            zic = new Podmoga(a,b);
        }
        else if(u1)
        {
            zic = new Podmoga(a);
        }
        else if(u2)
        {
            zic = new Podmoga(b);
        }
        zic.S();
        zic.U();
        zic.D();
        zic.V();
    }
}
*/