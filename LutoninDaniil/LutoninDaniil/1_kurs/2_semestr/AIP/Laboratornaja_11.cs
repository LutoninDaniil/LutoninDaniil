/*19.04.2025*/
/*
using System;
using System.Collections.Generic;
public class Bibleotek
{
    public List<Knig> kniggg;
    public Bibleotek()
    {
        kniggg = new List<Knig>();
    }
}
public struct Knig
{
    public string avtor, ima, god, vihod;
    public Tort tort;
    public Knig(string[] info)
    {
        avtor = info[0];
        ima = info[1];
        god = info[2];
        vihod = info[3];
        tort = new Tort(info[4], info[5]);
    }
    public Knig(string avtor, string ima, string god, string vihod, string zabral, string otdal)
    {
        this.avtor = avtor;
        this.ima = ima;
        this.god = god;
        this.vihod = vihod;
        tort = new Tort(zabral, otdal);
    }
    public string info()
    {
        return $"{avtor} {ima} {god} {vihod} {tort.zabral} {tort.otdal}";
    }
}
public struct Tort
{
    public string zabral, otdal;
    public Tort(string zabral, string otdal)
    {
        this.zabral = zabral;
        this.otdal = otdal;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Bibleotek bib = new Bibleotek();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1) Добавить книжку");
            Console.WriteLine("2) Удалить последнюю книжку");
            Console.WriteLine("3) Выборка по невыданным книгам");
            Console.WriteLine("4) Выборка по невозвращёным книгам");
            Console.WriteLine("5) Выход(Покеда)");
            string x = "" + Console.ReadLine();
            if (x == "5")
            {
                break;
            }
            switch (x)
                {
                    case "1":
                        Console.WriteLine("Введите через пробельчик(если чего-то нет - пиши прочерк): \n" +
                        "Автор Название Год_публикации Издатель Дата_выдачи Дата_возврата");
                        string[] y = ("" + Console.ReadLine()).Split(" ");
                        bib.kniggg.Add(new Knig(y));
                        break;
                    case "2":
                        bib.kniggg.Remove(bib.kniggg.Last());
                        break;
                    case "3":
                        foreach (Knig i in bib.kniggg)
                        {
                            if (i.tort.zabral == "-")
                            {
                                Console.WriteLine(i.info());
                            }
                        }
                        break;
                    case "4":
                        foreach (Knig i in bib.kniggg)
                        {
                            if (i.tort.otdal == "-" && i.tort.zabral != "-")
                            {
                                Console.WriteLine(i.info());
                            }
                        }
                        break;
                }
            Console.ReadLine();
        }
    }
}
*/