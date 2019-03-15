using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    class HeroMementoCreator : Creator
    {
        public override AbstractHero FactoryMethod()
        {
            return new Memento.HeroMemento();
        }
    }
}
