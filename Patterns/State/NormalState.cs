using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    class NormalState : IState
    {
        public void Handle(HeroState hero)
        {
            hero.State = new RageState();

            hero.Stats.Damage *= 3;
            Console.WriteLine("Режим ярости. Урон увеличен в 3 раза!");
            Console.WriteLine($"Урон равен: {hero.Stats.Damage}");
        }
    }
}
