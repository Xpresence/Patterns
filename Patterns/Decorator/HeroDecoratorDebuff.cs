using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    class HeroDecoratorDebuff : HeroDecorator
    {
        public HeroDecoratorDebuff(AbstractHero hero) : base(hero) { }

        public override void Debuff(int val)
        {
            base.Debuff(val);

            Console.WriteLine("Герой получил снижение всех параметров.");
            Stats.Strength -= val;
            Stats.Agility -= val;
            Stats.Intelligence -= val;
        }

    }
}
