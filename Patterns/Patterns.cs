using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.Methods;

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
            Console.WriteLine("7 -- Factory Method");
            Console.WriteLine("8 -- Proxy");

            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    RunMemento.Run();
                    break;
                case "2":
                    RunObserver.Run();
                    break;
                case "3":
                    RunPrototype.Run();
                    break;
                case "4":
                    RunSingleton.Run();
                    break;
                case "5":
                    RunDecorator.Run();
                    break;
                case "6":
                    RunBridge.Run();
                    break;
                case "7":
                    RunFactoryMethod.Run();
                    break;
                case "8":
                    RunProxy.Run();
                    break;

                default:
                    Console.WriteLine("Неизвестное значение.");
                    ChangePatterns();
                    break;
            }
        }  
    }
}
