/*10.04.2025*/
/*
using System;
using System.Collections.Generic;
public struct Bibliotec
{
    public List<Kniga> knigi;
    public Bibliotec()
    {
        knigi = new List<Kniga>();
    }
}
public struct Kniga
{
    public string avtor, ima, god, vipusk;
    public Kiko kiko;
    public Kniga(string[] infa)
    {
        avtor = infa[0];
        ima = infa[1];
        god = infa[2];
        vipusk = infa[3];
        kiko = new Kiko(infa[4], infa[5]);
    }
    public Kniga(string avtor, string ima, string god, string vipusk, string vzal, string vernul)
    {
        this.avtor = avtor;
        this.ima = ima;
        this.god = god;
        this.vipusk = vipusk;
        kiko = new Kiko(vzal, vernul);
    }
    public string infu()
    {
        return $"{avtor} {ima} {god} {vipusk} {kiko.vzal} {kiko.vernul}";
    }
}
public struct Kiko
{
    public string vzal, vernul;
    public Kiko(string vzal, string vernul)
    {
        this.vzal = vzal;
        this.vernul = vernul;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Bibliotec bibl = new Bibliotec();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1) Добавить книжку");
            Console.WriteLine("2) Удалить последнюю книжку");
            Console.WriteLine("3) Выборка по невыданным книгам");
            Console.WriteLine("4) Выборка по невозвращёным книгам");
            Console.WriteLine("5) Выход(Пока-пока)");
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
                    bibl.knigi.Add(new Kniga(y));
                    break;
                case "2":
                    bibl.knigi.Remove(bibl.knigi.Last());
                    break;
                case "3":
                    foreach (Kniga i in bibl.knigi)
                    {
                        if (i.kiko.vzal == "-")
                        {
                            Console.WriteLine(i.infu());
                        }
                    }
                    break;
                case "4":
                    foreach (Kniga i in bibl.knigi)
                    {
                        if (i.kiko.vernul == "-" && i.kiko.vzal != "-")
                        {
                            Console.WriteLine(i.infu());
                        }
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
*/