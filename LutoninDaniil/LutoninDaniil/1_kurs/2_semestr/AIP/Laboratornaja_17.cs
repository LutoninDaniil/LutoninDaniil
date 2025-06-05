/*02.06.2025*/
/*
using System;
using System.Collections.Generic;
public class Studen
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
            return new Drevo(uchenik);
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
        if (koren == null)
        {
            Console.WriteLine("Древо пустое(((");
            return;
        }
        Console.WriteLine("Структура древа:");
        Moker(koren, 0, "");
    }
    private void Moker(Drevo frog, int lvl, string pfen)
    {
        if (frog == null)
        {
            return;
        }
        Moker(frog.Pravo, lvl + 1, "    " + pfen);
        Console.Write(pfen);
        Console.Write("└── ");
        Console.WriteLine($"[{frog.Dete.ID}] {frog.Dete.FIO}");
        Moker(frog.Levo, lvl + 1, "    " + pfen);
    }
    public void Proper()
    {
        Console.WriteLine("Студенты, отсортированные по ID-ишнику:");
        Puper(koren);
    }
    private void Puper(Drevo koren)
    {
        if (koren != null)
        {
            Puper(koren.Levo);
            Console.WriteLine($"ID: {koren.Dete.ID}; ФИО: {koren.Dete.FIO}");
            Puper(koren.Pravo);
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
        Console.WriteLine("Короче, дерево выводится как бы повернутое на бок(сначала идёт правая ветка, потом начальная точка, и потом левая ветка(а в ветках: сверху - правая ветка, а снизу - левая))");
        drevo.Vstav();
        Console.WriteLine("А это, ну чтобы было:)))");
        drevo.Proper();
    }
}
*/