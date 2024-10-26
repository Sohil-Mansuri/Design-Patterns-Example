
namespace MediatorPattern.Using_observer
{

    /// <summary>
    /// Observer
    /// </summary>
    /// functional interface (i.e., an interface with a single abstract method).
    public interface IEvenHandler
    {
        void Handle();
    }

    //this one is similer to Action delegate so will use that instead of this 
}
