using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    interface IState
    {
        void Handle(HeroState hero);
    }
}
