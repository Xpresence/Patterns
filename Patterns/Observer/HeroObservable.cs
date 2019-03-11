using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    class HeroObservable : Hero, IObservable
    {
        private List<IObserver> observers;

        public HeroObservable()
        {
            observers = new List<IObserver>();
        }


        protected override void ChangeStats()
        {
            base.ChangeStats();
            Notify();
        }


        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.UpdateInfo(Stats);
            }
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
