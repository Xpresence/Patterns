using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class HeroStats
    {
        public int Lives { get; set; }
        public int Damage { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }

        public HeroStats Clone()
        {
            return new HeroStats()
            {
                Lives = this.Lives,
                Damage = this.Damage,
                Strength = this.Strength,
                Agility = this.Agility,
                Intelligence = this.Intelligence
            };
        }
    }
}
