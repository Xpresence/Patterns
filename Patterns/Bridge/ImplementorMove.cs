using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Bridge
{
    class ImplementorMove : IImplementor
    {
        public void Move()
        {
            Console.WriteLine("Герой бежит!");
        }
    }
}
