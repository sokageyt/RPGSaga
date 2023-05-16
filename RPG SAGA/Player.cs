using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_SAGA
{
    class Player
    {
        int hp;
        int str;
        string name;
        string _class;

        public static string[] NamesList = new string[] { "Mag ", "Archer ", " Knight " };

        public Player(int hp, int str, string name)
        {
            this.hp = hp;
            this.str = str;
            this.name = name;
            _class = "Игроку ";
        }
        public void Hit(Player target)
        {

            Console.WriteLine($"{Info()} Вносит удар с вертухи пяткой в нижнюю челюсть противника {target.Info()}");
            target.TakeDamage(str);
            Console.WriteLine("=========================================================================================");
        }

        public void TakeDamage(int dmg)
        {
            Console.WriteLine($"{Info()} получил {dmg}+ урона");
            hp -= dmg;
        }
        public bool IsLose()
        {
            return hp <= 0;
        }
        public string Info()
        {
            return $"Игрок {name} [{hp}]";

        }

    }
}

