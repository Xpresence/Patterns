using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Proxy
{
    class HeroProxy : IHero
    {
        Hero hero;

        public HeroProxy()
        {
            this.hero = null;
        }

        public void AboutHero()
        {
            Console.WriteLine("Proxy:");
            GetHero();

            Console.WriteLine($"Количество жизней: {hero.Stats.Lives}");
            Console.WriteLine($"Урон: {hero.Stats.Damage}");
            Console.WriteLine($"Сила: {hero.Stats.Strength}");
            Console.WriteLine($"Ловкость: {hero.Stats.Agility}");
            Console.WriteLine($"Интеллект: {hero.Stats.Intelligence}");
        }

        public void Attack()
        {
            Console.WriteLine("Proxy:");
            GetHero();

            Random random = new Random();

            if (random.Next(0, 1) == 1)
            {
                Console.WriteLine($"Удар. Нанесено урона: {hero.Stats.Damage}");
            }
            else
            {
                hero.Stats.Lives -= 10;
                Console.WriteLine($"Промах. Враг наносит урон. Получено урона: 10. Осталось жизней: {hero.Stats.Lives}");
            }
        }

        public void FindItem()
        {
            Console.WriteLine("Proxy:");
            GetHero();

            Console.WriteLine("Найдена вещь. Характеристики изменены.");

            Random random = new Random();

            hero.Stats.Damage = random.Next(1, 25);
            hero.Stats.Strength = random.Next(10, 30);
            hero.Stats.Agility = random.Next(10, 30);
            hero.Stats.Intelligence = random.Next(10, 30);

            Console.WriteLine("Новые параметры:");
            AboutHero();
        }

        private void GetHero()
        {
            if (hero == null)
            {
                hero = new Hero();
            }
        }
    }
}
