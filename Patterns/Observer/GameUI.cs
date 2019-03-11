using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    abstract class GameUI : IObserver
    {

        protected IObservable hero;

        public abstract string Name { get; set; }

        protected GameUI(IObservable observable)
        {
            hero = observable;
            hero.Register(this);
        }

        public abstract void UpdateInfo(object obj);
    }

    class GameUILives : GameUI
    {
        public override string Name { get; set; }
        public GameUILives(IObservable observable) : base(observable)
        {
            Name = "Здоровье";
            Console.WriteLine($"Параметр {this.Name} подписался.");
        }

        public override void UpdateInfo(object obj)
        {
            HeroStats stats = (HeroStats)obj;

            if (stats.Lives < 50)
            {
                Console.WriteLine($"Нужно пополнить параметр {this.Name}.");
                Console.WriteLine($"Количество параметра {this.Name}: {stats.Lives}");
            }
            else
            {
                Console.WriteLine("Здоровья пока хватает.");
            }
        }
    }

    class GameUIDamage : GameUI
    {
        public override string Name { get; set; }
        public GameUIDamage(IObservable observable) : base(observable)
        {
            Name = "Урон";
            Console.WriteLine($"Параметр {this.Name} подписался.");
        }

        public override void UpdateInfo(object obj)
        {
            HeroStats stats = (HeroStats)obj;

            if (stats.Damage < 15)
            {
                Console.WriteLine($"Нужно найти другой предмет на {this.Name}.");
                Console.WriteLine($"Количество параметра {this.Name}: {stats.Damage}");
            }
            else
            {
                Console.WriteLine("Урона хватает.");
            }
        }
    }

    class GameUIStrength : GameUI
    {
        public override string Name { get; set; }
        public GameUIStrength(IObservable observable) : base(observable)
        {
            Name = "Сила";
            Console.WriteLine($"Параметр {this.Name} подписался.");
        }

        public override void UpdateInfo(object obj)
        {
            HeroStats stats = (HeroStats)obj;

            if (stats.Strength < 20)
            {
                Console.WriteLine($"Нужно найти другой предмет на {this.Name}.");
                Console.WriteLine($"Количество параметра {this.Name}: {stats.Strength}");
            }
            else
            {
                Console.WriteLine("Силы хватает.");
            }
        }
    }

    class GameUIAgility : GameUI
    {
        public override string Name { get; set; }
        public GameUIAgility(IObservable observable) : base(observable)
        {
            Name = "Ловкость";
            Console.WriteLine($"Параметр {this.Name} подписался.");
        }

        public override void UpdateInfo(object obj)
        {
            HeroStats stats = (HeroStats)obj;

            if (stats.Agility < 20)
            {
                Console.WriteLine($"Нужно найти другой предмет на {this.Name}.");
                Console.WriteLine($"Количество параметра {this.Name}: {stats.Agility}");
            }
            else
            {
                Console.WriteLine("Ловкости хватает.");
            }
        }
    }

    class GameUIIntelligence : GameUI
    {
        public override string Name { get; set; }
        public GameUIIntelligence(IObservable observable) : base(observable)
        {
            Name = "Интеллект";
            Console.WriteLine($"Параметр {this.Name} подписался.");
        }

        public override void UpdateInfo(object obj)
        {
            HeroStats stats = (HeroStats)obj;

            if (stats.Intelligence < 20)
            {
                Console.WriteLine($"Нужно найти другой предмет на {this.Name}.");
                Console.WriteLine($"Количество параметра {this.Name}: {stats.Intelligence}");
            }
            else
            {
                Console.WriteLine("Интеллекта хватает.");
            }
        }
    }
}
