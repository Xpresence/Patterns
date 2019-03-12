using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    abstract class AbstractHeroBridge : Hero
    {
        protected IImplementor implementor;
        public IImplementor Implementor
        {
            set
            {
                implementor = value;
            }
        }

        public AbstractHeroBridge() : base() { }

        public AbstractHeroBridge(IImplementor implementor)
        {
            Implementor = implementor;
        }

        public virtual void Move()
        {
            implementor.Move();
        }
    }
}
