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

        public void Update(WordsCounter observavel)
        {
            Console.WriteLine("ID do Subscriber: " + this.id);
            Console.WriteLine("Nome do Subscriber: " + this.nome);
            Console.WriteLine("Número Total de Strings: " + observavel.Words);
            Console.WriteLine("Número Total de Strings Pares: " + observavel.EvenWords);
            Console.WriteLine("Número Total de Strings com Upper Case: " + observavel.UpperWords);
            Console.WriteLine();
        }

        public int ID
        {
            get { return id; }
        }

        public string Nome
        {
            get { return nome; }
        }
    }
}