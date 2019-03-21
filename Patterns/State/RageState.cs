using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    class RageState : IState
    {
        public void Handle(HeroState hero)
        {
            hero.State = new NormalState();
            hero.Stats.Damage /= 3;

            Console.WriteLine("Нормальный режим. Урон в исходном состоянии. ");
            Console.WriteLine($"Урон равен: {hero.Stats.Damage}");
        }
    }
}
