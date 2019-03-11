using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Memento
{
    interface IMemento
    {
        Memento SaveState();
        void RestoreState(Memento memento);
    }
}
