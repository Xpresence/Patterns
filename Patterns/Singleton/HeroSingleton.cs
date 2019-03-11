using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    class HeroSingleton : Hero
    {
        private static readonly HeroSingleton instance = new HeroSingleton();

        public string Message { get; private set; }

        private HeroSingleton()
        {
            Message = "Супергерой создан " + DateTime.Now.TimeOfDay.ToString() + " !";

            Console.WriteLine($"{Message}");
        }

        public static HeroSingleton GetInstance()
        {
            return instance;
        }
    }
}
