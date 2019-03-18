using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Methods
{
    static class RunCommand
    {
        public static void Run()
        {
            Command.Invoker inv = new Command.Invoker();

            Hero hero = new Hero();

            Command.AboutCommand aboutCommand = new Command.AboutCommand(hero);
            Command.AttackCommand attackCommand = new Command.AttackCommand(hero);

            Console.WriteLine("");
            Console.WriteLine("Начало игры.");
            Console.WriteLine("");

            inv.SetCommand(attackCommand);
            inv.ExecuteCommand();

            Console.WriteLine("");

            inv.SetCommand(aboutCommand);
            inv.ExecuteCommand();

            Console.WriteLine("");
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}
