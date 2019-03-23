using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Methods
{
    static class RunChainOfResponsibility
    {
        public static void Run()
        {
            ChainOfResponsibility.Handler attackHandler = new ChainOfResponsibility.AttackHandler();
            ChainOfResponsibility.Handler holdHandler = new ChainOfResponsibility.HoldHandler();
            ChainOfResponsibility.Handler healHandler = new ChainOfResponsibility.HealHandler();

            attackHandler.Heir = holdHandler;
            holdHandler.Heir = healHandler;


            Hero hero = new Hero();

            Console.WriteLine("");
            Console.WriteLine("Начало игры.");
            Console.WriteLine("");

            attackHandler.Request(hero.Stats.Lives);

            Console.WriteLine("");

            hero.Attack();
            hero.Attack();
            hero.Attack();

            Console.WriteLine("");

            attackHandler.Request(hero.Stats.Lives);

            Console.WriteLine("");

            hero.Attack();
            hero.Attack();
            hero.Attack();

            Console.WriteLine("");

            attackHandler.Request(hero.Stats.Lives);

            Console.WriteLine("");
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}
