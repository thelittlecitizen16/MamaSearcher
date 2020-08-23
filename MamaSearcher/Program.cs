using System;

namespace MamaSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            MamaSearcher mamaSearcher = new MamaSearcher();
            mamaSearcher.Subscribe("A", APattern);
            mamaSearcher.Subscribe("A", AAnotherPattern);
            mamaSearcher.PerformSearch("AB");

        }
        public static void APattern(int index , string content)
        {
            Console.WriteLine($"its a pattern {content} in index {index}");
        }
        public static void AAnotherPattern(int index, string content)
        {
            Console.WriteLine($"its a another pattern {content} in index {index}");
        }
    }
}
