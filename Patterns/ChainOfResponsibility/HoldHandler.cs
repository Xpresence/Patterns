using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility
{
    class HoldHandler : Handler
    {
        public override void Request(int lives)
        {
            if (lives < 75 && lives > 50)
            {
                Console.WriteLine("Держим оборону и поддерживаем лечение.");
                Console.WriteLine($"Здоровье героя: {lives}");
            }
            else if (Heir != null)
            {
                Heir.Request(lives);
            }
        }
    }
}
