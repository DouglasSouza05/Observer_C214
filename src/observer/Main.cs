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
            Subscriber observador1 = new Subscriber(id: 1, nome: "Carlito");

            frase = "Chris melhor professor Ever. Da um 10 ae Please !!!";

            Console.WriteLine("Adicionando Observadores " + observador0.ID + " e " + observador1.ID + "\n");
            observavel.AddObserver(observador0);
            observavel.AddObserver(observador1);

            Console.WriteLine("Inserindo Frase no Observavel..." + "\n");
            observavel.Application(frase);

            Console.WriteLine("Removendo Observador " + observador0.ID + "\n");
            observavel.RemoveObserver(observador0);

            Console.WriteLine("Inserindo Frase no Observavel..." + "\n");
            observavel.Application(frase);
        }
    }
}