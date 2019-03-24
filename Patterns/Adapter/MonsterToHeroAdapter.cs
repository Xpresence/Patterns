using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    class MonsterToHeroAdapter : IHero
    {
        Monster monster;

        public MonsterToHeroAdapter(Monster monster)
        {
            this.monster = monster;
        }

        public void AboutHero()
        {
            monster.AboutMonster();
        }

        public void Attack()
        {
            monster.Attack();
        }

        public void FindItem()
        {
            Console.WriteLine("Монстр ничего не делает и просто бегает.");
        }

        
    }
}
