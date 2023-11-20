namespace iObservavel
{

    public interface WordsCounterIObservavel
    {

        public void AddObserver(String observador);

        public void RemoveObserver(String observador);

        public void NotifyObservers();

    }
}