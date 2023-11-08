using Mechanics.Composition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanics
{
    internal class LocatableMonitor : IObservable<ILocatable>
    {
        List<IObserver<ILocatable>> _observers { get; } = new List<IObserver<ILocatable>>();

        public IDisposable Subscribe(IObserver<ILocatable> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);

            return new LocatableMonitorUnsubscriber(_observers, observer);
        }
        internal class LocatableMonitorUnsubscriber : IDisposable
        {
            private List<IObserver<ILocatable>> observers;
            private IObserver<ILocatable> observer;

            public LocatableMonitorUnsubscriber(List<IObserver<ILocatable>> observers, IObserver<ILocatable> observer)
            {
                this.observers = observers;
                this.observer = observer;
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }
    }





}
