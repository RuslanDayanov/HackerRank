using System;
using System.Collections.Generic;

namespace UnitTests
{
    internal class ArrayManipulation
    {
        private readonly int n;
        private readonly int m;
        private readonly List<Tuple<int, int, int>> operations;

        public ArrayManipulation(int n, int m, List<Tuple<int, int, int>> operations)
        {
            this.n = n;
            this.m = m;
            this.operations = operations;
        }

        public int GetMaxAfterAllOperations()
        {
            return 0;
        }
    }
}