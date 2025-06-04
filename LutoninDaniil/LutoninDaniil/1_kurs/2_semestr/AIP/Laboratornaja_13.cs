/*24.04.2025*/
/*
using System;
using System.Collections.Generic;
class Bibica
{
    public string vihod;
    public string marka;
    public string gorod;
    public Bibica(string[] infr)
    {
        vihod = infr[0];
        marka = infr[1];
        gorod = infr[2];
    }
    public string infr()
    {
        return $"{vihod} {marka} {gorod}";
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        List<Bibica> bibic = new List<Bibica>();
        while(true)
        {
            Console.Clear();
            Console.WriteLine("1) Добавить бибику");
            Console.WriteLine("2) Удалить последнюю бибику");
            Console.WriteLine("3) Выборка по году выпуска бибики");
            Console.WriteLine("4) Выборка по марке бибики");
            Console.WriteLine("5) Выборка по городу регистрации бибики");
            Console.WriteLine("6) Выход(пок)");
            string x = "" + Console.ReadLine();
            if (x == "6")
            {
                break;
            }
            switch (x)
                {
                    case "1":
                        Console.WriteLine("Введите через пробельчик(если чего-то нет, то ну как обычно - прочерк): \n" +
                        "Год_выпуска Марка Город_регистрации");
                        string[] y = ("" + Console.ReadLine()).Split(" ");
                        bibic.Add(new Bibica(y));
                        break;
                    case "2":
                        bibic.Remove(bibic.Last());
                        break;
                    case "3":
                        {
                            Console.Write("Введите годик: ");
                            string nol = "" + Console.ReadLine();
                            var qwed = from n in bibic
                                         where nol == n.vihod
                                         select n;
                            foreach (var i in qwed)
                            {
                                Console.WriteLine(i.infr());
                            }
                        }
                        break;
                    case "4":
                        {
                            Console.Write("Введите марку бибики: ");
                            string nol = "" + Console.ReadLine();
                            var qwed = from n in bibic
                                         where n.marka == nol
                                         select n;
                            foreach (var i in qwed)
                            {
                                Console.WriteLine(i.infr());
                            }
                        }
                        break;
                    case "5":
                        {
                            Console.Write("Введите городок: ");
                            string nol = "" + Console.ReadLine();
                            var qwed = from n in bibic
                                         where n.gorod == nol
                                         select n;
                            foreach (var i in qwed)
                            {
                                Console.WriteLine(i.infr());
                            }
                        }
                        break;
                }
            Console.Write("Нажмите ENTER");
            Console.ReadLine();
        }
    }
}
*/