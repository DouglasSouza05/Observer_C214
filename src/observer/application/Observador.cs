using System.Diagnostics.Contracts;
using iObservador;
using Observavel;

namespace Observador
{

    public class Subscriber : SubscriberIObservador
    {

        int id;
        String nome;
        WordsCounter observavel;

        public Subscriber(int id, String nome)
        {
            observavel = new WordsCounter();

            this.id = id;
            this.nome = nome;

        }

        public void Update()
        {
            Console.WriteLine("ID do Subscriber: " + this.id);
            Console.WriteLine("Nome do Subscriber: " + this.nome);
            Console.WriteLine("Número Total de Palavras: " + observavel.Words);
            Console.WriteLine();
        }

    }

}