using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Methods
{
    static class RunState
    {
        public static void Run()
        {
            State.HeroState hero = new State.HeroState(new State.NormalState());

            Console.WriteLine("");
            Console.WriteLine("Начало игры.");
            Console.WriteLine("");

            hero.FindItem();

            Console.WriteLine("");

            hero.ChangeState();

            Console.WriteLine("");

            hero.AboutHero();

            Console.WriteLine("");

            hero.ChangeState();

            Console.WriteLine("");

            hero.AboutHero();

            Console.WriteLine("");
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}
