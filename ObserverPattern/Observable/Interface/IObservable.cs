using ObserverPattern.Observer;

namespace ObserverPattern.Observable
{
    public interface IObservable
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);
        void Notify();
    }
}
