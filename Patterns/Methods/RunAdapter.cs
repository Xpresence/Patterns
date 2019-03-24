using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Methods
{
    static class RunAdapter
    {
        public static void Run()
        {
            Adapter.Client client = new Adapter.Client();

            Hero hero = new Hero();

            Console.WriteLine("");
            Console.WriteLine("Начало игры.");
            Console.WriteLine("");

            client.FindItemRequest(hero);

            Console.WriteLine("");

            client.AttackRequest(hero);

            Console.WriteLine("");

            client.AboutHeroRequest(hero);

            Console.WriteLine("");
            Console.WriteLine("Меняем героя на монстра.");
            Console.WriteLine("");

            Adapter.Monster monster = new Adapter.Monster();
            IHero monsterHero = new Adapter.MonsterToHeroAdapter(monster);

            client.FindItemRequest(monsterHero);

            Console.WriteLine("");

            client.AttackRequest(monsterHero);

            Console.WriteLine("");

            client.AboutHeroRequest(monsterHero);

            Console.WriteLine("");
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}
