using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility
{
    abstract class Handler
    {
        public Handler Heir { get; set; }
        public abstract void Request(int val);
    }
}
