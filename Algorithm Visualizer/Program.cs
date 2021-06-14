using System;
using static Algorithms;

namespace Algorithm_Visualizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            Console.WriteLine("Hello World!");
            int size = 20;
            int[] test = new int[size];
            for (int i = 0; i < test.Length; i++)
                test[i] = rand.Next(-size, size);
            foreach (int i in test)
                Console.Write(i + " ");
            Console.WriteLine();

            quickSort(test);

            foreach (int i in test)
                Console.Write(i + " ");
        }
    }
}
