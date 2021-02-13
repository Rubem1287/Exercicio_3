using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a, b, c;

            int n = int.Parse(Console.ReadLine());

            a = new int[n];
            b = new int[n];
            c = new int[n];

            string[] vetor = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(vetor[i]);
            }

            string[] vetor1 = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(vetor1[i]);
            }

            for (int i = 0; i < n; i++)
            {
                c[i] = a[i] + b[i];
                Console.Write(c[i]+" ");
            }
        }
    }
}
