/*10.02.2025*/
/*
using System;
using System.Collections;
using System.Numerics;

class Polzovatel
{
    public string FIO;
    public List<Telefon> telefoni;
    public Polzovatel(string FIO)
    {
        this.FIO = FIO;
        telefoni = new List<Telefon>();
    }
    public void dobavittel(Telefon ap)
    {
        telefoni.Add(ap);
    }
}
class Telefon
{
    public string nomer, gorod, operatorsvjazi, god;
    public Telefon(string nomer, string gorod, string operatorsvjazi, string god)
    {
        this.nomer = nomer;
        this.gorod = gorod;
        this.operatorsvjazi = operatorsvjazi;
        this.god = god;
    }
    public void DobavitInfu()
    {
        Console.WriteLine($"{nomer}; {gorod}, {operatorsvjazi}, {god}");
    }
}
internal class Program
{
    static List<Polzovatel> polzovateli = new List<Polzovatel>();
    private static void Main(string[] args)
    {
        while(true)
        {
            Console.Clear();
            Console.WriteLine("———<Менюшка>———");
            Console.WriteLine("1.Задать телефончик");
            Console.WriteLine("2.Вывести инфу телефонов");
            Console.WriteLine("3.Выйти/Пока:(\n");
            string sus = "" + Console.ReadLine();
            if(sus == "1")
            {
                DobavitTel();
            }
            else if(sus == "2")
            {
                FivodInfa();
            }
            else if(sus == "3")break;
            else Console.WriteLine("Нетю такой команды (ツ)");
        }
    }
    private static void DobavitTel()
    {
        Console.WriteLine("Введите через SPACE (ФИО, номер, город, оператор связи, год подключения):");
        string[] sas = (""+Console.ReadLine()).Split(" ");
        bool tom = false;
        foreach(Polzovatel i in polzovateli)
        {
            if(i.FIO == sas[0])
            {
                tom = true;
                i.dobavittel(new Telefon(sas[1], sas[2], sas[3], sas[4]));
            }
        }
        if(!tom)
        {
            polzovateli.Add(new Polzovatel(sas[0]));
            polzovateli[polzovateli.Count - 1].dobavittel(new Telefon(sas[1], sas[2], sas[3], sas[4]));
        }
    }
    private static void FivodInfa()
    {
        Console.Write("Введите данные для поиска (номер/город/оператор связи/год подключения) или \"-\"(прочерк/минус): ");
        string sss = "" + Console.ReadLine();
        foreach(Polzovatel i in polzovateli)
        {
            Console.WriteLine("Устройства " + i.FIO + ":");
            bool tim = true;
            foreach(Telefon j in i.telefoni)
            {
                if(sss == "-" || sss == j.nomer || sss == j.gorod || sss == j.operatorsvjazi || sss == j.god)
                {
                    Console.Write("\t");
                    j.DobavitInfu();
                    tim = false;
                }
            }
            if(tim)Console.WriteLine("\tНет данных, удовлетворяющему поиску:(((");
        }
        Console.WriteLine("Жмякните ENTER.");
        Console.ReadLine();
    }
}
*/