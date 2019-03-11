using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    interface IObserver
    {
        void UpdateInfo(object obj);
    }
}
