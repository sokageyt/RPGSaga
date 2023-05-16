using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_SAGA
{
    class Mag
    {
        int hp;
        int str;
        string name;
        string _class;

        public Mag(int hp, int str, string name)
        {
            this.hp = hp;
            this.str = str;
            this.name = name;
            _class = "Игроку";
        }
        public void Hit(Mag target)
        {
            target.TakeDamage(str);
            Console.WriteLine($"{Info()} Вносит сильный удар по игроку {target.Info()}");
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
            return $"Игроку {name} [{hp}]";
        }
    }
}
