using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Methods
{
    static class RunPrototype
    {
        public static void Run()
        {

            Hero hero = new Hero();

            Console.WriteLine("");
            Console.WriteLine("Начало игры.");
            Console.WriteLine("");

            hero.FindItem();

            Console.WriteLine("");

            var protoHero = Prototype.Prototype.DeepClone(hero);

            hero.FindItem();

            Console.WriteLine("");

            Console.WriteLine("Первый герой атакует:");

            hero.Attack();
            hero.Attack();

            Console.WriteLine("");

            Console.WriteLine("Клон героя атакует:");

            protoHero.Attack();

            Console.WriteLine("");

            Console.WriteLine("Первый герой:");
            hero.AboutHero();

            Console.WriteLine("");

            Console.WriteLine("Клон героя:");
            protoHero.AboutHero();

            Console.WriteLine("");
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}
