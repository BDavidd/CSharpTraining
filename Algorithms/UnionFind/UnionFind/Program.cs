using System;
using System.Collections.Generic;

namespace UnionFind
{
    class UF
    {
        public UF(int N)
        {

        }

        public void union(int p, int q)
        {

        }

        public bool connected(int p, int q)
        {
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            UF uf = new UF(N);

            string input = Console.ReadLine();
            int[] results = Array.ConvertAll(input.Split(' '), int.Parse);

            for (int i = 0; i < results.Length - 1; i += 2)
            {
                int p = results[i];
                int q = results[i + 1];
                if (!uf.connected(p, q))
                {
                    uf.union(p, q);
                    Console.WriteLine($"{p} {q}");
                }
            }
        }
    }
}
