using System.Diagnostics.Contracts;
using iObservador;
using Observavel;

namespace Observador
{

    public class Subscriber : SubscriberIObservador
    {

        private int id;
        private String nome;

        public Subscriber(int id, String nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public void Update(int totalWords, int evenWords, int upperWords)
        {
            Console.WriteLine("ID do Subscriber: " + this.id);
            Console.WriteLine("Nome do Subscriber: " + this.nome);
            Console.WriteLine("Número Total de Palavras: " + totalWords);
            Console.WriteLine("Número Total de Palavras Pares: " + evenWords);
            Console.WriteLine("Número Total de Palavras com Upper Case: " + upperWords);
            Console.WriteLine();
        }

    }
}