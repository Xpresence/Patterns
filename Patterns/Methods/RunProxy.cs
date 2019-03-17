using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Methods
{
    static class RunProxy
    {
        public static void Run()
        {
            IHero hero = new Proxy.HeroProxy();

            Console.WriteLine("");
            Console.WriteLine("Начало игры.");
            Console.WriteLine("");

            hero.AboutHero();

            Console.WriteLine("");

            hero.Attack();
            hero.Attack();
            hero.Attack();

            Console.WriteLine("");

            hero.FindItem();

            Console.WriteLine("");

            hero.Attack();
            hero.Attack();

            Console.WriteLine("");

            hero.AboutHero();

            Console.WriteLine("");
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}
