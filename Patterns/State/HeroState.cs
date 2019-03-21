using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    class HeroState : Hero
    {
        public IState State { get; set; }

        public HeroState(IState state)
        {
            State = state;
        }

        public void ChangeState()
        {
            State.Handle(this);
        }
    }
}
