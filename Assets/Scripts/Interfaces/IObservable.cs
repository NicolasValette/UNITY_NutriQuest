using System;


namespace NutriQuest.Interfaces
{
    public interface IObservable<T>
    {
        public event Action<T> OnValueChange;
        public T Value { get; }
    }
}
