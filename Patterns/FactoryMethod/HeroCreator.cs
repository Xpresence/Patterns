using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    class HeroCreator : Creator
    {
        public override AbstractHero FactoryMethod()
        {
            return new Hero();
        }
    }
}
