using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Patterns
    {
        static void Main(string[] args)
        {
            ChangePatterns();        
        }

        static void ChangePatterns()
        {
            Console.WriteLine("Выберите паттерн:");
            Console.WriteLine("1 -- Memento");
            Console.WriteLine("2 -- Observer");

            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    RunMemento();
                    break;
                case "2":
                    RunObserver();
                    break;

                default:
                    Console.WriteLine("Неизвестное значение.");
                    ChangePatterns();
                    break;
            }
        }

        static void RunMemento()
        {
            Memento.HeroMemento hero = new Memento.HeroMemento();

            Memento.Caretaker savedHero = new Memento.Caretaker();

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

            savedHero.Memento = hero.SaveState();

            Console.WriteLine("");

            hero.FindItem();

            Console.WriteLine("");

            hero.Attack();
            hero.Attack();

            Console.WriteLine("");

            hero.RestoreState(savedHero.Memento);

            Console.WriteLine("");
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
        }

        static void RunObserver()
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
