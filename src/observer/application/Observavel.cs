using System.Diagnostics.Contracts;
using iObservavel;

namespace Observavel
{
    public class WordsCounter : WordsCounterIObservavel
    {

        public void AddObserver(String observador)
        {

        }

        public void RemoveObserver(String observador)
        {

        }

        public void NotifyObservers()
        {

        }

        private List<String>? palavras;

        public List<String> SplitWords(String frase)
        {
            palavras = new List<String>();
            char[] delimitadores = { ';', ':', '"', '(', ')', '[', ']', '{', '}', '/', ',', '!', '.', '?', ' ', '\\', '\'', '=', '*', '&', '%', '$', '#', '@', '-', '_', '+', '~', '^', '¨' };

            palavras.AddRange(frase.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries));

            return palavras;
        }

        public int CountWords(List<String> palavras)
        {
            if (palavras == null)
            {
                return 0;
            }

            return palavras.Count;
        }

        public int CountEvenWords(List<String> palavras)
        {
            if (palavras == null)
            {
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
        }

        public int CountWordsWithUpperCase(List<String> palavras)
        {
            if (palavras == null)
            {
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
        }
    }
}