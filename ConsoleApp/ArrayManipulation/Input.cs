using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.ArrayManipulation
{
    class Input
    {
        public void Execute()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);

            for (int a0 = 0; a0 < m; a0++)
            {
                string[] tokens_a = Console.ReadLine().Split(' ');
                int a = Convert.ToInt32(tokens_a[0]);
                int b = Convert.ToInt32(tokens_a[1]);
                int k = Convert.ToInt32(tokens_a[2]);
            }
        }
    }
}
