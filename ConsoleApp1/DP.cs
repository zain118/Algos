using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DP
    {
        public static int[][] m;
        public static int knapSack(int W, int[] wt, int[] val, int n)
        {
            // your code here 
            m = new int[1001][];
            for (int i = 0; i < 1001; i++)
            {
                m[i] = new int[1001];
                for (int k = 0; k < 1001; k++)
                {
                    m[i][k] = -1;
                }
            }
            return ks(W, wt, val, n);
        }

        static int ks(int W, int[] wt, int[] val, int n)
        {
            if (n == 0 || W == 0) return 0;

            if (m[W][n] != -1)
            {
                return m[W][n];
            }
            else
            {
                if (wt[n-1] <= W)
                {
                    m[W][n] = Math.Max(val[n-1] + ks(W - wt[n-1], wt, val, n - 1), ks(W, wt, val, n - 1));
                }
                else
                {
                    m[W][n] = ks(W, wt, val, n - 1);
                }
                return m[W][n];
            }
        }
    }
}
