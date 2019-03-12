using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    [Serializable]
    class Hero : AbstractHero
    {

        public override void Attack()
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

        public override void FindItem()
        {
            Console.WriteLine("Найдена вещь. Характеристики изменены.");
            ChangeStats();

            Console.WriteLine("Новые параметры:");
            AboutHero();
        }

        public override void AboutHero()
        {
            Console.WriteLine($"Количество жизней: {Stats.Lives}");
            Console.WriteLine($"Урон: {Stats.Damage}");
            Console.WriteLine($"Сила: {Stats.Strength}");
            Console.WriteLine($"Ловкость: {Stats.Agility}");
            Console.WriteLine($"Интеллект: {Stats.Intelligence}");
        }

        public override void Buff(int val)
        {
            Console.WriteLine($"Урон увеличен на значение: {val}");
            Stats.Damage += val;
        }

        public override void Debuff(int val)
        {
            Console.WriteLine($"Урон снижен на значение: {val}");
            Stats.Damage -= val;
        }

        protected override void ChangeStats()
        {
            Random random = new Random();

            Stats.Damage = random.Next(1, 25);
            Stats.Strength = random.Next(10, 30);
            Stats.Agility = random.Next(10, 30);
            Stats.Intelligence = random.Next(10, 30);
        }
    }
}
