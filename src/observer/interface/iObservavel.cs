using Observador;

namespace iObservavel
{

    public interface WordsCounterIObservavel
    {

        public void AddObserver(Subscriber observador);

        public void RemoveObserver(Subscriber observador);

        public void NotifyObservers();

    }
}