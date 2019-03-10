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

            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    RunMemento();
                    break;

                default:
                    Console.WriteLine("Неизвестное значение.");
                    ChangePatterns();
                    break;
            }
        }

        static void RunMemento()
        {
            HeroMemento hero = new HeroMemento();

            Caretaker savedHero = new Caretaker();

            Console.WriteLine("Начало игры.");

            hero.AboutHero();

            hero.Attack();
            hero.Attack();
            hero.Attack();

            hero.FindItem();

            hero.Attack();
            hero.Attack();

            savedHero.Memento = hero.SaveState();


            hero.FindItem();

            hero.Attack();
            hero.Attack();

            hero.RestoreState(savedHero.Memento);

            Console.ReadKey();
        }

    }
}
