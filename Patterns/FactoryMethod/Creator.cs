using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    abstract class Creator
    {
        public abstract AbstractHero FactoryMethod();
    }
}
