using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Methods
{
    static class RunObserver
    {
        public static void Run()
        {

            Observer.HeroObservable hero = new Observer.HeroObservable();

            Observer.GameUI livesSubscriber = new Observer.GameUILives(hero);
            Observer.GameUI damageSubscriber = new Observer.GameUIDamage(hero);
            Observer.GameUI strengthSubscriber = new Observer.GameUIStrength(hero);
            Observer.GameUI agilitySubscriber = new Observer.GameUIAgility(hero);
            Observer.GameUI intelligenceSubscriber = new Observer.GameUIIntelligence(hero);

            Console.WriteLine("");
            Console.WriteLine("Начало игры.");
            Console.WriteLine("");

            hero.FindItem();

            Console.WriteLine("");

            hero.FindItem();

            Console.WriteLine("");

            hero.FindItem();

            Console.WriteLine("");
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
        }

    }
}
