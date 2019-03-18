using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    class AttackCommand : Command
    {
        Hero hero;
        public AttackCommand(Hero hero)
        {
            this.hero = hero;
        }

        public override void Execute()
        {
            hero.Attack();
        }
    }
}
