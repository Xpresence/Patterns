using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility
{
    class AttackHandler : Handler
    {
        public override void Request(int lives)
        {
            if (lives >= 75)
            {
                Console.WriteLine($"Со здоровьем все в порядке. Идем в атаку.");
                Console.WriteLine($"Здоровье героя: {lives}");
            }
            else if (Heir != null)
            {
                Heir.Request(lives);
            }
        }
    }
}
