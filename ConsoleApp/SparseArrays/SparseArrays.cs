using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class SparseArrays
    {
        private int N;
        private int Q;
        public void Execute()
        {
            string[] shelves;
            string[] queries;
            N = Convert.ToInt32(Console.ReadLine());
            shelves = new string[N];
            for (int a0 = 0; a0 < N; a0++)
            {
                shelves[a0] = Console.ReadLine();
            }
            Q = Convert.ToInt32(Console.ReadLine());
            queries = new string[Q];
            for (int a1 = 0; a1 < Q; a1++)
            {
                queries[a1] = Console.ReadLine();
            }
            var result = FindSubStrings(shelves, queries);
            foreach (int value in result)
            {
                Console.WriteLine(value);
            }
        }

        public List<int> FindSubStrings(string[] shelves, string[] queries)
        {
            var result = new List<int>(queries.Length);
            foreach (var query in queries)
            {
                if(query == null)
                    continue;
                int matches = 0;
                foreach (string shelf in shelves)
                {                   
                    if (query.Equals(shelf, StringComparison.InvariantCulture))
                    {
                        matches++;
                    }                  
                }
                result.Add(matches);
            }
            return result;
        }
    }
}
