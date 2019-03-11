using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    interface IObservable
    {
        void Register(IObserver observer);
        void Remove(IObserver observer);
        void Notify();
    }
}
