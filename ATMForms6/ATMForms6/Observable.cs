using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMForms6
{
    public abstract class Observable
    {

        private readonly List<IObserver> observers = new();

        public void AddObserver(IObserver observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }

        protected void NotifyObservers()
        {
            foreach (var observer in observers)
                observer.Update();
        }
    }
}
