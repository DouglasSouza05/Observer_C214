using System.Diagnostics.Contracts;
using iObservador;
using Observavel;

namespace Observador
{

    public class Subscriber : SubscriberIObservador
    {

        int id;
        String nome;

        public Subscriber(int id, String nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public void Update()
        {
            Console.WriteLine("ID do Subscriber: " + this.id);
            Console.WriteLine("Nome do Subscriber: " + this.nome);
            Console.WriteLine("Número Total de Palavras: ");
            Console.WriteLine("Número Total de Palavras Pares: ");
            Console.WriteLine("Número Total de Palavras com Upper Case: ");
            Console.WriteLine();
        }

    }
}