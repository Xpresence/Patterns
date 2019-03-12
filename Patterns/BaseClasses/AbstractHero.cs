using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    [Serializable]
    abstract class AbstractHero : IHero
    {
        public HeroStats Stats { get; set; }
        public AbstractHero()
        {
            Stats = new HeroStats()
            {
                Lives = 100,
                Damage = 10,
                Strength = 10,
                Agility = 10,
                Intelligence = 10
            };
        }

        public abstract void Attack();
        public abstract void FindItem();
        public abstract void AboutHero();
        public abstract void Buff(int val);
        public abstract void Debuff(int val);
        protected abstract void ChangeStats();
    }
}
