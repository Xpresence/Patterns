using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    class HeroDecoratorBuff : HeroDecorator
    {
        public HeroDecoratorBuff(AbstractHero hero) : base(hero) { }

        public override void Buff(int val)
        {
            base.Buff(val);

            Console.WriteLine("Герой получил усиление всех параметров.");
            Stats.Strength += val;
            Stats.Agility += val;
            Stats.Intelligence += val;
        }
    }
}
