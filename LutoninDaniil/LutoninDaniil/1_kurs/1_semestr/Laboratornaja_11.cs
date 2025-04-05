/*25.12.2024*/
using System;
using System.Collections;
/*
class Gorod
{
    public string imja;
    public Samolet[] samoleti;
    public Gorod(string imja)
    {
        this.imja = "" + imja;
        samoleti = [];
    }
    public void Samoletiki(Samolet sam)
    {
        Samolet[] aboba = new Samolet[samoleti.Length + 1];
        for(int i = 0; i<samoleti.Length; i++)
        {
            aboba[i] = samoleti[i];
        }
        aboba[samoleti.Length] = sam;
        samoleti = aboba;
    }
}
class Samolet
{
    public string nachaloG;
    public string konecG;
    public string vremja;
    public string imja;
    public Samolet(string nachaloG, string konecG, string vremja, string imja)
    {
        this.nachaloG = nachaloG;
        this.konecG = konecG;
        this.vremja = vremja;
        this.imja = imja;
    }
    public void Infa()
    {
        Console.WriteLine($"{imja}| из {nachaloG} в {konecG}| {vremja}");
    }
}
class L11
{
    static Gorod[] gorodki = [];
    private static void Main(string[] japi)
    {
        bool p = true;
        while(p)
        {
            Console.Clear();
            Console.WriteLine("---Менюшка---\n" +
            "1. Задать Самолётик(вжууух, виу)\n" +
            "2. Выборка по граду назначения\n" +
            "3. Выборка по типу летательного аппарата с крылышками\n" +
            "4. Выход(пока и удачи:))\n");
            Console.Write("Выберите команду по номеру: ");
            string comanda = "" + Console.ReadLine();
            switch(comanda)
            {
                default: Console.WriteLine("Ну нетю такой команды:("); break;
                case "1":
                    NoviiS();
                    break;
                case "2":
                    ConechniiG();
                    break;
                case "3":
                    ImjaS();
                    break;
                case "4": p = false; break;
            }
            Console.WriteLine("Жмякните ENTER");
            Console.ReadLine();
        }
    }
    static void ConechniiG()
    {
        Console.Write("Введите град назначения: ");
        string x = "" + Console.ReadLine();
        foreach(Gorod i in gorodki)
        {
            if(i.imja == x)
            {
                foreach(Samolet j in i.samoleti)
                {
                    if(j.konecG == i.imja)
                    {
                        j.Infa();
                    }
                }
            }
        }
    }
    static void ImjaS()
    {
        Console.Write("Введите тип летательного аппарата с крылышками: ");
        string x = "" + Console.ReadLine();
        ArrayList w = new ArrayList();
        foreach(Gorod i in gorodki)
        {
            foreach(Samolet j in i.samoleti)
            {
                if(j.imja==x && !w.Contains(j))
                {
                    j.Infa();
                    w.Add(j);
                }
            }
        }
    }
    static void NoviiS()
    {
        Console.WriteLine("Введите параметры через пробел (град_отправки град_прибытия время_в_пути тип_бибалётика): ");
        string x = "" + Console.ReadLine();
        string[] v = x.Split(" ");
        Samolet sam = new Samolet(v[0], v[1], v[2], v[3]);

        bool o = false;
        bool q = false;
        foreach(Gorod i in gorodki)
        {
            if(i.imja == sam.nachaloG || i.imja == sam.konecG)
            {
                i.Samoletiki(sam);
                if(i.imja == sam.nachaloG)
                {
                    o = true;
                }
                if(i.imja == sam.konecG)
                {
                    q = true;
                }
            }
        }
        if(!o)
        {
            NoviiG(new Gorod(sam.nachaloG));
            gorodki[gorodki.Length-1].Samoletiki(sam);
        }
        if(!q)
        {
            NoviiG(new Gorod(sam.konecG));
            gorodki[gorodki.Length-1].Samoletiki(sam);
        }
    }
    static void NoviiG(Gorod grad)
    {
        Gorod[] h = new Gorod[gorodki.Length+1];
        for(int i = 0; i<gorodki.Length; i++)
        {
            h[i] = gorodki[i];
        }
        h[gorodki.Length] = grad;
        gorodki = h;
    }
}
*/