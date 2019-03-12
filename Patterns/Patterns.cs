﻿using System;
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
            Console.WriteLine("3 -- Prototype");
            Console.WriteLine("4 -- Singleton");
            Console.WriteLine("5 -- Decorator");
            Console.WriteLine("6 -- Bridge");

            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    RunMemento();
                    break;
                case "2":
                    RunObserver();
                    break;
                case "3":
                    RunPrototype();
                    break;
                case "4":
                    RunSingleton();
                    break;
                case "5":
                    RunDecorator();
                    break;
                case "6":
                    RunBridge();
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

        static void RunPrototype()
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

        static void RunSingleton()
        {

            Singleton.HeroSingleton hero = Singleton.HeroSingleton.GetInstance();

            Console.WriteLine("");
            Console.WriteLine("Начало игры.");
            Console.WriteLine("");

            hero.FindItem();

            hero = Singleton.HeroSingleton.GetInstance();

            Console.WriteLine("");
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
        }

        static void RunDecorator()
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

        static void RunBridge()
        {

            Bridge.HeroBridge hero = new Bridge.HeroBridge(new Bridge.ImplementorMove());

            Console.WriteLine("");
            Console.WriteLine("Начало игры.");
            Console.WriteLine("");

            hero.Move();

            Console.WriteLine("");

            Console.WriteLine("Меняем передвижение.");

            hero.Implementor = new Bridge.ImplementorFly();

            Console.WriteLine("");

            hero.Move();

            Console.WriteLine("");
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}
