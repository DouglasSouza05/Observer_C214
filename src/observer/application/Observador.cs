using System.Diagnostics.Contracts;
using iObservador;
using iObservavel;

namespace Observador
{

    public class Subscriber : SubscriberIObservador
    {

        String nome;

        public Subscriber(String nome)
        {

            this.nome = nome;

        }

        public void Update(String observavel)
        {

        }

    }

}