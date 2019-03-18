using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    class AboutCommand : Command
    {
        Hero hero;
        public AboutCommand(Hero hero)
        {
            this.hero = hero;
        }

        public override void Execute()
        {
            hero.AboutHero();
        }
    }
}
