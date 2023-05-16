using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_SAGA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Здарова чучпек, ты в этой лучшей игре на планете Земля - RPG SAGA!");
            Console.WriteLine("Принимаем ставки на банковские карты, а при выигрыше выплаты не обещаем))))");
            Console.WriteLine("|========================================================================================|");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Random rnd = new Random();
            archer p1 = new archer(rnd.Next(10, 50), rnd.Next(2, 5), Player.NamesList[rnd.Next(Player.NamesList.Length)]);
            Knight p2 = new Knight(rnd.Next(10, 50), rnd.Next(2, 5), "Knight");
            Mag p3 = new Mag(rnd.Next(10, 40), rnd.Next(5, 10), "Mag");

            while (true)
            {
                p1.Hit(p2);
                if (p2.IsLose())
                {
                    Console.WriteLine($"{p2.Info()} ПОРАЖЕНИЕ ");
                    break;
                }
                p2.Hit(p1);
                if (p1.IsLose())
                {
                    Console.WriteLine($"{p1.Info()} ПОРАЖЕНИЕ ");
                    break;
                }

                //p3.Hit(p1);
                //if (p1.IsLose())
                //{
                //    Console.WriteLine($"{p1.Info()}проиграл....GAME OVER");
                //    break;
                //}

                Console.ReadKey();
            }
        }
    }
}