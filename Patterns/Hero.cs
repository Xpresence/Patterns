using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Hero
    {
        public HeroStats Stats { get; set; }
        public Hero()
        {
            Stats = new HeroStats()
            {
                Lives = 100,
                Damage = 10,
                Strength = 10,
                Agility = 10,
                Intelligence = 10
            };
        }

        public void Attack()
        {
            Random random = new Random();

            if (random.Next(0, 1) == 1)
            {
                Console.WriteLine($"Удар. Нанесено урона: {Stats.Damage}");
            }
            else
            {
                Stats.Lives -= 10;
                Console.WriteLine($"Промах. Враг наносит урон. Получено урона: 10. Осталось жизней: {Stats.Lives}");
            }
        }

        public void FindItem()
        {
            Console.WriteLine("Найдена вещь. Характеристики изменены.");
            ChangeStats();

            Console.WriteLine("Новые параметры:");
            AboutHero();
        }

        public void AboutHero()
        {
            Console.WriteLine($"Количество жизней: {Stats.Lives}");
            Console.WriteLine($"Урон: {Stats.Damage}");
            Console.WriteLine($"Сила: {Stats.Strength}");
            Console.WriteLine($"Ловкость: {Stats.Agility}");
            Console.WriteLine($"Интеллект: {Stats.Intelligence}");
        }

        void ChangeStats()
        {
            Random random = new Random();

            Stats.Damage = random.Next(1, 25);
            Stats.Strength = random.Next(10, 30);
            Stats.Agility = random.Next(10, 30);
            Stats.Intelligence = random.Next(10, 30);
        }
    }
}
