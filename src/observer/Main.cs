using Application;

namespace Main
{
    class Program
    {
        static void Main()
        {
            WordCounter wordCounter = new WordCounter();
            List<String> words;

            words = wordCounter.SplitWords("Hello World");

            Console.WriteLine("Palavras Separadas:", "\n");

            // Agora você pode imprimir a lista de palavras
            foreach (var palavra in words)
            {
                Console.WriteLine(palavra);
            }

            Console.WriteLine();

            Console.WriteLine("Contador Palavras Totais:", "\n");

            Console.WriteLine(wordCounter.CountWords(words));

            Console.WriteLine();

            Console.WriteLine("Contador Palavras Pares:", "\n");

            Console.WriteLine(wordCounter.CountEvenWords(words));

            Console.WriteLine();

            Console.WriteLine("Contador Palavras Iniciadas com Upper Case:", "\n");

            Console.WriteLine(wordCounter.CountWordsWithUpperCase(words));
        }
    }
}