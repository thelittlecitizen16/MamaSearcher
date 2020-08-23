using System;

namespace MamaSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            MamaSearcher mamaSearcher = new MamaSearcher();
            mamaSearcher.Subscribe("A", APAttern);
            mamaSearcher.PerformSearch("AB");

        }
        public static void APAttern(int index , string content)
        {
            Console.WriteLine($"its a pattern {content} in index {index}");
        }
    }
}
