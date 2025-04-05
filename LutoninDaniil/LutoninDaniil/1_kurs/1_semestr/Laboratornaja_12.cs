/*25.12.2024*/
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
/*
class Mebel
{
    public string imja;
    public string strana;
    public string cena;
    protected Mebel(string imja, string strana, string cena)
    {
        this.imja = imja;
        this.strana = strana;
        this.cena = cena;
    }
    protected void Infa()
    {
        Console.Write($"{imja} {strana} {cena}р");
    }
}
class Stul: Mebel
{
    public bool mjagkost;
    public int nogi;
    public Stul(string imja, string strana, string cena, bool mjagkost, int nogi):base(imja, strana, cena)
    {
        this.mjagkost = mjagkost;
        this.nogi = nogi;
    }
    public void InfaSu()
    {
        Console.Write("Стул | ");
        base.Infa();
        string f = mjagkost ? "мягенький" : "твёрденький";
        Console.WriteLine($" {f} {nogi} ножичек");
    }
}
class Stol: Mebel{
    public string variant;
    public int nogi;
    public Stol(string imja, string strana, string cena, string variant, int nogi):base(imja, strana, cena)
    {
        this.variant = variant;
        this.nogi = nogi;
    }
    public void InfaSo()
    {
        Console.Write("Стол | ");
        base.Infa();
        Console.WriteLine($" {variant} {nogi} ножичек");
    }
}
class L12
{
    static List<Stul> stulchiki = new List<Stul>();
    static List<Stol> stoliki = new List<Stol>();
    private static void Main(string[] japi)
    {
        bool a = true;
        while(a)
        {
            Console.Clear();
            Console.WriteLine("---Менюшка---\n" +
            "1. Задать Мебель(не придумал ничего интересного)\n" +
            "2. Выборка по стране производителя(и тут тоже:()\n" +
            "3. Выборка по кол-ву ножичек\n" +
            "4. Выход:(\n");
            Console.Write("Выберите команду по номеру: ");
            string comanda = "" + Console.ReadLine();
            switch(comanda)
            {
                default: Console.WriteLine("Нетю такой команды:("); break;
                case "1":
                    NoviiM();
                    break;
                case "2":
                    GorodP();
                    break;
                case "3":
                    Nogi();
                    break;
                case "4": a = false; break;
            }
            Console.WriteLine("Жмякните ENTER");
            Console.ReadLine();
        }
    }
    static void NoviiM()
    {
        Console.WriteLine("Введите тип мебели (стульчик или столик): ");
        string beba = "" + Console.ReadLine();
        if(beba == "стульчик")
        {
            Console.WriteLine("Введите характеристики через пробел (имя страна_производитель цена мягенький/тверденький кол-во_ножек): ");
            beba = "" + Console.ReadLine();
            string[] bodro = beba.Split(" ");
            stulchiki.Add(new Stul(bodro[0], bodro[1], bodro[2], bodro[3] == "мягкий", Convert.ToInt32(bodro[4])));
        }
        else if(beba == "столик")
        {
            Console.WriteLine("Введите характеристики через пробел (имя страна_производитель цена вариант_столешницы количество_ножек): ");
            beba = "" + Console.ReadLine();
            string[] a = beba.Split(" ");
            stoliki.Add(new Stol(a[0], a[1], a[2], a[3], Convert.ToInt32(a[4])));
        }
    }
    static void GorodP()
    {
        Console.Write("Введите город производитель: ");
        string redka = "" + Console.ReadLine();
        for(int i = 0; i<Math.Max(stulchiki.Count, stoliki.Count); i++)
        {
            if(i<stulchiki.Count && redka == stulchiki[i].strana)
            {
                stulchiki[i].InfaSu();
            }
            if(i<stoliki.Count && redka == stoliki[i].strana)
            {
                stoliki[i].InfaSo();
            }
        }
    }
    static void Nogi()
    {
        Console.Write("Введите кол-во ножичек: ");
        int u = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i<Math.Max(stulchiki.Count, stoliki.Count); i++)
        {
            if(i<stulchiki.Count && u == stulchiki[i].nogi)
            {
                stulchiki[i].InfaSu();
            }
            if(i<stoliki.Count && u == stoliki[i].nogi)
            {
                stoliki[i].InfaSo();
            }
        }
    }
}
*/