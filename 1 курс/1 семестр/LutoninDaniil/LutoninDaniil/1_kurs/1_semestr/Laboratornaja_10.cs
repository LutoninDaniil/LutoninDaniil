/*10.12.2024*/
using System;
/*
class Mashinki
{
    public string model;
    public string god;
    public string color;
    public string strana;

    public Mashinki(string[] aboba)
    {
        model = aboba[0];
        god = aboba[1];
        color = aboba[2];
        strana = aboba[3];
    }

    public void chai()
    {
        Console.WriteLine("Модель: " + model + "; Год выпуска: " + god + "; Цвет: " + color + "; Страна выпуска: " + strana);
    }
}
class L10
{
    static Mashinki[] trol = [];
    private static void Main(string[] japi)
    {
        Console.Write("Введите количество машин: ");
        int n = Convert.ToInt32(Console.ReadLine());
        trol = new Mashinki[n];
        while(true)
        {
            Console.Clear();
            Console.WriteLine("———<Меню>———");
            Console.WriteLine($"1.Задать машину");
            Console.WriteLine("2.Вывести данные машин");
            Console.WriteLine("3.Выйти\n");
            string zub = "" + Console.ReadLine();
            if(zub == "1")
            {
                Console.Write($"Введите номер ячейки, данные котрой хотите изминить (доступно 1-{trol.Length} ячеек): ");
                zub = "" + Console.ReadLine();
                n = Convert.ToInt32(zub)-1;
                if(n<0 || n>=trol.Length) 
                {
                    Console.WriteLine("Нетю ячейки с данным номером(ツ)");
                }
                else
                {
                    Console.Write("Введите характеристики через пробел(марка, год, цвет и страна): ");
                    zub = "" + Console.ReadLine();
                    trol[n] = new Mashinki(zub.Split(" "));
                }
            }
            else if(zub == "2")
            {
                Console.Write("Введите по каким параметрам выовдит (через пробел, марка год цвет страна, если парметр не важн введие \"-\"): ");
                zub = ""+Console.ReadLine();
                string[] a = zub.Split(" ");
                foreach(Mashinki i in trol)
                {
                    if(i == null)continue;
                    bool u = true;
                    if(!(a[0] == "-" || a[0] == i.model))
                    {
                        u = false;
                    }
                    if(!(a[1] == "-" || a[1] == i.god))
                    {
                        u = false;
                    }
                    if(!(a[2] == "-" || a[2] == i.color))
                    {
                        u = false;
                    }
                    if(!(a[3] == "-" || a[3] == i.strana))
                    {
                        u = false;
                    }
                    if(u)
                    {
                        i.chai();
                    }
                }
            }
            else if(zub == "3") break;
            else 
            {
                Console.WriteLine("Нет такой команды");
            }
            Console.Write("Нажмите Enter чтобы вернуться в меню");
            Console.ReadLine();
        }
    }
}
*/