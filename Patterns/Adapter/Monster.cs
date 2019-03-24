using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    class Monster 
    {
        public void Attack()
        {
            Console.WriteLine("Бьем острыми когтями.");
        }

        public void AboutMonster()
        {
            Console.WriteLine("Монстр очень сильный.");
        }
    }
}
