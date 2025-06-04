/*02.06.2025*/
/*
using System;
using System.Collections.Generic;
public struct Studen
{
    public int ID;
    public string FIO;
}
public class Drevo
{
    public Studen Dete;
    public Drevo Levo;
    public Drevo Pravo;
    public Drevo(Studen jokey)
    {
        Dete = jokey;
        Levo = null;
        Pravo = null;
    }
}
public class StDrevo
{
    private Drevo koren;
    public void Inet(Studen uchenik)
    {
        koren = Rinet(koren, uchenik);
    }
    private Drevo Rinet(Drevo koren, Studen uchenik)
    {
        if (koren == null)
        {
            koren = new Drevo(uchenik);
            return koren;
        }
        if (uchenik.ID < koren.Dete.ID)
        {
            koren.Levo = Rinet(koren.Levo, uchenik);
        }
        else if (uchenik.ID > koren.Dete.ID)
        {
            koren.Pravo = Rinet(koren.Pravo, uchenik);
        }
        return koren;
    }
    public void Vstav()
    {
        Moker(koren);
    }
    private void Moker(Drevo koren)
    {
        if (koren != null)
        {
            Moker(koren.Levo);
            Console.WriteLine($"ID: {koren.Dete.ID}, ФИО: {koren.Dete.FIO}");
            Moker(koren.Pravo);
        }
    }
}
public class Program
{
    public static void Main()
    {
        StDrevo drevo = new StDrevo();
        drevo.Inet(new Studen { ID = 5, FIO = "И Ива Ио" });
        drevo.Inet(new Studen { ID = 3, FIO = "Петров Петр Петрович" });
        drevo.Inet(new Studen { ID = 7, FIO = "Апрелин Сидр Косович" });
        drevo.Inet(new Studen { ID = 2, FIO = "Кенр Кени Проповедич" });
        drevo.Inet(new Studen { ID = 4, FIO = "Уругвей Шифу Сергеевич" });
        Console.WriteLine("Студенты, отсортированные по ID-ишнику:");
        drevo.Vstav();
    }
}
*/
