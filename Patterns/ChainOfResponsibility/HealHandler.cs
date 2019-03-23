using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.ChainOfResponsibility
{
    class HealHandler : Handler
    {
        public override void Request(int lives)
        {
            if (lives <= 50)
            {
                Console.WriteLine("Необходимо вылечиться. Отступаем.");
                Console.WriteLine($"Здоровье героя: {lives}");
            }
            else if (Heir != null)
            {
                Heir.Request(lives);
            }
        }
    }
}
