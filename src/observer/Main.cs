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

            Console.WriteLine("Adicionando Observadores 0 e 2!" + "\n");
            observavel.AddObserver(observador0);
            observavel.AddObserver(observador2);

            frase = "Hello Precious World!";

            Console.WriteLine("Inserindo Frase no Observavel..." + "\n");
            observavel.Application(frase);

            Console.WriteLine("Removendo Observador 0!" + "\n");
            observavel.RemoveObserver(observador0);

            Console.WriteLine("Inserindo Frase no Observavel..." + "\n");
            observavel.Application(frase);
        }
    }
}