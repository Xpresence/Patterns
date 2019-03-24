using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    class Client
    {
        public void AttackRequest(IHero hero)
        {
            hero.Attack();
        }

        public void FindItemRequest(IHero hero)
        {
            hero.FindItem();
        }

        public void AboutHeroRequest(IHero hero)
        {
            hero.AboutHero();
        }
    }
}
