using System.Diagnostics.Contracts;
using iObservavel;
using Observador;

namespace Observavel
{
    public class WordsCounter : WordsCounterIObservavel
    {

        private List<Subscriber>? observadores;
        private List<String>? palavras;
        List<String>? splittedWords;
        int words, evenWords, upperWords;

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
                    observer.Update(this);
                }
            }
        }

        public void Application(String frase)
        {
            splittedWords = SplitWords(frase);

            words = CountWords(splittedWords);
            evenWords = CountEvenWords(splittedWords);
            upperWords = CountWordsWithUpperCase(splittedWords);

            NotifyObservers();
        }

        public List<String> SplitWords(String frase)
        {
            palavras = new List<String>();
            char[] delimitadores = { ';', ':', '"', '(', ')', '[', ']', '{', '}', '/', ',', '!', '.', '?', ' ', '\\', '\'', '=', '*', '&', '%', '$', '#', '@', '-', '_', '+', '~', '^', '¨' };

            palavras.AddRange(frase.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries));

            // Console.WriteLine("Frase Digitada: " + frase);
            // Console.WriteLine();
            // foreach (var item in palavras)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine();

            return palavras;
        }

        public int CountWords(List<String> palavras)
        {
            if (palavras == null)
            {
                Console.WriteLine("Lista vazia. Nenhuma frase foi enviada!");
                return 1;
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

        public int EvenWords
        {
            get { return evenWords; }
        }

        public int UpperWords
        {
            get { return upperWords; }
        }
    }
}