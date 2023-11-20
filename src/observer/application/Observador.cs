using System.Diagnostics.Contracts;
using iObservador;

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
            
        }

    }

}