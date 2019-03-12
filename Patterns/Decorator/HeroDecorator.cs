using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    abstract class HeroDecorator : Hero
    {
        protected AbstractHero hero;

        public HeroDecorator(AbstractHero hero)
        {
            this.hero = hero;
        }

        public override void Buff(int val)
        {
            base.Buff(val);
        }

        public override void Debuff(int val)
        {
            base.Debuff(val);
        }

    }
}
