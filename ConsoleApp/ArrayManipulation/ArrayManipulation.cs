using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ConsoleApp
{
    public class ArrayManipulation
    {
        private  int n;
        private  int m;
        private  List<Tuple<int, int, long>> operations;

        public ArrayManipulation()
        {
        }

        public ArrayManipulation(int n, int m, List<Tuple<int, int, long>> operations)
        {
            this.n = n;
            this.m = m;
            this.operations = operations;
        }

        public void Execute()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');

            n = Convert.ToInt32(tokens_n[0]);
            m = Convert.ToInt32(tokens_n[1]);
            operations = new List<Tuple<int, int, long>>(m);

            for (int a0 = 0; a0 < m; a0++)
            {
                string[] tokens_a = Console.ReadLine().Split(' ');
                int a = Convert.ToInt32(tokens_a[0]);
                int b = Convert.ToInt32(tokens_a[1]);
                int k = Convert.ToInt32(tokens_a[2]);
                operations.Add(new Tuple<int, int, long>(a,b,k));
            }

            Console.WriteLine(GetMaxAfterAllOperations());
        }

        public long GetMaxAfterAllOperations()
        {
            if (n == 0) return 0;
            if (m == 0) return 0;
            long[] data = new long[n];
            for (int i = 0; i < m; i++)
            {
                data[operations[i].Item1-1] += operations[i].Item3;
                if (operations[i].Item2 < n)
                {
                    data[operations[i].Item2] -= operations[i].Item3;
                }
            }
            long tempMax = 0;
            long max = 0;
            for (int i = 0; i < n; i++)
            {
                tempMax += data[i];
                if (tempMax > max) max = tempMax;
            }
            return max;
        }
    }
}