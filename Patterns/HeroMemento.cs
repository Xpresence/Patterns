using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class HeroMemento : Hero, IMemento
    {
        public Memento SaveState()
        {
            Console.WriteLine("Сохранение персонажа. Сохраненные параметры:");
            AboutHero();

            return new Memento(Stats);
        }

        public void RestoreState(Memento memento)
        {
            this.Stats = memento.Stats;

            Console.WriteLine("Загрузка персонажа. Восстановленные параметры:");
            AboutHero();
        }
    }
}
