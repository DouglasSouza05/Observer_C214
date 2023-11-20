using Observador;
using Observavel;

namespace Main
{
    class Program
    {
        static void Main()
        {
            WordsCounter observavel = new WordsCounter();
            String frase;

            Subscriber observador1 = new Subscriber(id: 0, nome: "Isabel");
            Subscriber observador2 = new Subscriber(id: 1, nome: "Zézin");
            Subscriber observador3 = new Subscriber(id: 2, nome: "Carlito");

            observavel.AddObserver(observador1);
            observavel.AddObserver(observador3);

            frase = "Hello Precious World!";

            observavel.SplitWords(frase);

        }
    }
}