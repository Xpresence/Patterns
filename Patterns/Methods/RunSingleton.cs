using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Methods
{
    static class RunSingleton
    {
        public static void Run()
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
    }
}
