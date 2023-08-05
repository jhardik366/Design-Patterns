using ObserverPattern.Observer;

namespace ObserverPattern.Observable
{
    public class IphoneStockObservable : IObservable
    {
        public List<IObserver> observers = new List<IObserver>();
        public int _stockCount;

        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

        public void SetStockCount(int stockCount)
        {
            Console.WriteLine();
            Console.WriteLine($"Current stock value is: {stockCount}");
            if (_stockCount == 0)
            {
                Notify();
            }

            _stockCount = stockCount;
        }

        public int GetStockCount()
        {
            return _stockCount;
        }

    }
}
