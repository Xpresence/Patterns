using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Methods
{
    static class RunMemento
    {
        public static void Run()
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
    }
}
