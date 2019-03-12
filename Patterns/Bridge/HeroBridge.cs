using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    class HeroBridge : AbstractHeroBridge
    {
        public HeroBridge(IImplementor implementor) : base(implementor) { }
    }
}
