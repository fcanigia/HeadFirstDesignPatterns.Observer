// See https://aka.ms/new-console-template for more information

namespace HeadFirstDesignPatterns.Observer.Abstract
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        public void NotifyObservers();
    }
}