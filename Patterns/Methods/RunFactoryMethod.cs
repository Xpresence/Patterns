using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Methods
{
    static class RunFactoryMethod
    {
        public static void Run()
        {

            FactoryMethod.Creator creator = new FactoryMethod.HeroCreator();

            Console.WriteLine("");

            Console.WriteLine("Создаем героя.");
            AbstractHero hero = creator.FactoryMethod();

            hero.AboutHero();

            Console.WriteLine("");

            Console.WriteLine("Создаем героя с сохранением.");

            creator = new FactoryMethod.HeroMementoCreator();

            AbstractHero heroMemento = creator.FactoryMethod();

            Memento.Caretaker savedHero = new Memento.Caretaker();

            savedHero.Memento = (heroMemento as Memento.HeroMemento).SaveState();

            Console.WriteLine("");

            heroMemento.FindItem();

            Console.WriteLine("");
            Console.WriteLine("Восстанавливаем сохраненного героя:");

            (heroMemento as Memento.HeroMemento).RestoreState(savedHero.Memento);

            Console.WriteLine("");
            Console.WriteLine("Текущие параметры:");
            heroMemento.AboutHero();

            Console.WriteLine("");
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}
