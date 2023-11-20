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

            Subscriber observador0 = new Subscriber(id: 0, nome: "Isabel");
            Subscriber observador1 = new Subscriber(id: 1, nome: "Zézin");
            Subscriber observador2 = new Subscriber(id: 2, nome: "Carlito");

            observavel.AddObserver(observador0);
            observavel.AddObserver(observador2);

            frase = "Hello Precious World!";

            observavel.Application(frase);
        }
    }
}