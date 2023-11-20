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

            // Agora você pode imprimir a lista de palavras
            foreach (var palavra in words)
            {
                Console.WriteLine(palavra);
            }

            Console.WriteLine();

            Console.WriteLine(wordCounter.CountWords(words));

            Console.WriteLine();

            Console.WriteLine(wordCounter.CountEvenWords(words));
        }
    }
}