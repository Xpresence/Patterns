using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Methods
{
    static class RunDecorator
    {
        public static void Run()
        {
            Hero hero = new Hero();

            Console.WriteLine("");
            Console.WriteLine("Начало игры.");
            Console.WriteLine("");

            hero = new Decorator.HeroDecoratorBuff(hero);

            hero.Buff(5);

            Console.WriteLine("");

            hero.AboutHero();

            Console.WriteLine("");

            hero.Debuff(3);

            Console.WriteLine("");

            hero = new Decorator.HeroDecoratorDebuff(hero);

            hero.Debuff(1);

            Console.WriteLine("");

            hero.AboutHero();

            Console.WriteLine("");
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}
