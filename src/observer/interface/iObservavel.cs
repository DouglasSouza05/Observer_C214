namespace iObservavel
{

    public interface WordsCounterObservavel
    {

        public void AddObserver(String observador);

        public void RemoveObserver(String observador);

        public void NotifyObservers();

    }
}