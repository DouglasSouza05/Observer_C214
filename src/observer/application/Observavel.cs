using System.Diagnostics.Contracts;
using iObservavel;
using Observador;

namespace Observavel
{
    public class WordsCounter : WordsCounterIObservavel
    {

        private List<Subscriber>? observadores;
        private List<String>? palavras;

        int words = 0;
        int pares = 0;
        int upper = 0;

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

        public void Application(String frase)
        {
            palavras = SplitWords(frase);
            words = CountWords(palavras);
            pares = CountEvenWords(palavras);
            upper = CountWordsWithUpperCase(palavras);
            NotifyObservers();
        }

        public List<String> SplitWords(String frase)
        {
            palavras = new List<String>();
            char[] delimitadores = { ';', ':', '"', '(', ')', '[', ']', '{', '}', '/', ',', '!', '.', '?', ' ', '\\', '\'', '=', '*', '&', '%', '$', '#', '@', '-', '_', '+', '~', '^', '¨' };

            palavras.AddRange(frase.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries));

            // Console.WriteLine("Frase digitada: " + frase);

            return palavras;
        }

        public int CountWords(List<String> palavras)
        {
            if (palavras == null)
            {
                Console.WriteLine("Lista vazia. Nenhuma frase foi enviada!");
                return 0;
            }

            return palavras.Count;

            // Console.WriteLine("Contador Palavras Totais: " + palavras.Count);
        }

        public int CountEvenWords(List<String> palavras)
        {
            if (palavras == null)
            {
                Console.WriteLine("Lista vazia. Nenhuma frase foi enviada!");
                return 0;
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

            return contador;

            // Console.WriteLine("Contador Palavras Pares: " + contador);
        }

        public int CountWordsWithUpperCase(List<String> palavras)
        {
            if (palavras == null)
            {
                Console.WriteLine("Lista vazia. Nenhuma frase foi enviada!");
                return 0;
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

            return contador;

            // Console.WriteLine("Contador Palavras Começadas com Upper Case: " + contador);
        }

        public int Words
        {
            get { return words; }
        }

        public int Pares
        {
            get { return pares; }
        }

        public int Upper
        {
            get { return upper; }
        }
    }
}