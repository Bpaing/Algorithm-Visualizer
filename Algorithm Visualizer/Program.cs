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
            int[] test = new int[20];
            for (int i = 0; i < test.Length; i++)
                test[i] = rand.Next(-20, 20);
            foreach (int i in test)
                Console.Write(i + " ");
            Console.WriteLine();

            insertionSort(test);

            foreach (int i in test)
                Console.Write(i + " ");
        }
    }
}
