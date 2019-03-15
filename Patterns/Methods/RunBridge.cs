using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Methods
{
    static class RunBridge
    {
        public static void Run()
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
