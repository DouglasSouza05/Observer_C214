using System.Diagnostics.Contracts;
using iObservavel;
using Observador;

namespace Observavel
{
    public class WordsCounter : WordsCounterIObservavel
    {

        private List<Subscriber>? observadores;
        private List<String>? palavras;

        public WordsCounter()
        {
            observadores = new List<Subscriber>();
        }

        public void AddObserver(Subscriber observador)
        {
            observadores?.Add(observador);
        }

        public void RemoveObserver(Subscriber observador)
        {
            observadores?.Remove(observador);
        }

        public void NotifyObservers()
        {

            if (observadores != null)
            {

                foreach (var observer in observadores)
                {
                    observer.Update();
                }

            }
        }

        public void SplitWords(String frase)
        {
            palavras = new List<String>();
            char[] delimitadores = { ';', ':', '"', '(', ')', '[', ']', '{', '}', '/', ',', '!', '.', '?', ' ', '\\', '\'', '=', '*', '&', '%', '$', '#', '@', '-', '_', '+', '~', '^', '¨' };

            palavras.AddRange(frase.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries));

            Console.WriteLine("Frase digitada: " + frase);
        }

        public void CountWords(List<String> palavras)
        {
            if (palavras == null)
            {
                Console.WriteLine("Lista vazia. Nenhuma frase foi enviada!");
                return;
            }

            Console.WriteLine("Contador Palavras Totais: " + palavras.Count);
        }

        public void CountEvenWords(List<String> palavras)
        {
            if (palavras == null)
            {
                Console.WriteLine("Lista vazia. Nenhuma frase foi enviada!");
                return;
            }

            int contador = 0;

            // List<String> palavrasPares = new List<String>();

            foreach (var word in palavras)
            {
                if (word.Length % 2 == 0)
                {
                    contador += 1;
                }
                else continue;
            }

            Console.WriteLine("Contador Palavras Pares: " + contador);
        }

        public void CountWordsWithUpperCase(List<String> palavras)
        {
            if (palavras == null)
            {
                Console.WriteLine("Lista vazia. Nenhuma frase foi enviada!");
                return;
            }

            int contador = 0;

            // List<String> palavrasPares = new List<String>();

            foreach (var word in palavras)
            {
                if (char.IsUpper(word[0]))
                {
                    contador += 1;
                }
                else continue;
            }

            Console.WriteLine("Contador Palavras Começadas com Upper Case: " + contador);
        }
    }
}