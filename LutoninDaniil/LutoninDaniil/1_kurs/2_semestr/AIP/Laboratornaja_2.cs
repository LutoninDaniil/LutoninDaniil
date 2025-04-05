/*13.02.2025*/
/*
using System;
using System.Collections.Generic;
public class Meistr
{
    protected string? ima;
}
interface Figuri
{
    public float POL();
    public float LOP();
}
class Kvadrat: Meistr, Figuri
{
    int t;
    public Kvadrat(int t)
    {
        this.t = t;
        ima = "Квадрат";
    }
    public float POL()
    {
        return t * t;
    }
    public float LOP()
    {
        return t * 4;
    }
}
class Okr: Meistr, Figuri
{
    int l;
    public Okr(int l)
    {
        this.l = l;
        ima = "Окружность";
    }
    public float POL()
    {
        return 3.14f * l * l;
    }
    public float LOP()
    {
        return 2 * 3.14f * l;
    }
}
class Treugl: Meistr, Figuri
{
    int f;
    public Treugl(int f)
    {
        this.f = f;
        ima = "Треугольник";
    }
    public float POL()
    {
        return (float)(f * f * Math.Sqrt(3)) / 4;
    }
    public float LOP()
    {
        return f * 3;
    }
}
internal class Pisatel
{
    private static void Main(string[] args)
    {
        Console.Write("Введите сторону □ (◕‿◕): ");
        Figuri rect=new Kvadrat(Convert.ToInt32(Console.ReadLine()));
        Console.Write("Введите радиус ○ (◕‿◕): ");
        Figuri circle=new Okr(Convert.ToInt32(Console.ReadLine()));
        Console.Write("Введите сторону △ (◕‿◕): ");
        Figuri rectangle=new Treugl(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Квадрат (площадь/периметр)(◕‿◕): "+rect.POL() +"/"+rect.LOP());
        Console.WriteLine("Круг (площ/пер)(◕‿◕): "+circle.POL() +"/"+circle.LOP());
        Console.WriteLine("Треугольник (S/P)(◕‿◕): "+rectangle.POL() +"/"+rectangle.LOP());
    }
}
*/