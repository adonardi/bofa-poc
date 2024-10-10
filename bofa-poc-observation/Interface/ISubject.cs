using System;

namespace bofa_poc_observation.Interface.ObserverPatternApp
{
    /// <summary>
    /// ISubject interface
    /// </summary>
    public interface ISubject
    {
        void Attach(IObserver observer);   // Method to attach an observer
        void Detach(IObserver observer);   // Method to detach
        void Notify();                     // Method to notify
    }

    /// <summary>
    /// IObserver interface
    /// </summary>
    public interface IObserver
    {
        void Update(string state);  // Method to update the observer
    }
}