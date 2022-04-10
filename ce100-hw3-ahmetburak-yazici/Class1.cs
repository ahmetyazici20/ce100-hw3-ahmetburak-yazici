using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce100_hw3_ahmetburak_yazici
{
    public class Class1
    {

        // Matrix Ai has dimension p[i-1] x p[i]
        // for i = 1..n
        static int MatrixChainOrder(int[] p, int n)
        {

            /* For simplicity of the program, one 
            extra row and one extra column are 
            allocated in m[][]. 0th row and 0th
            column of m[][] are not used */
            int[,] m = new int[n, n];

            int i, j, k, L, q;

            /* m[i, j] = Minimum number of scalar 
            multiplications needed
            to compute the matrix A[i]A[i+1]...A[j]
            = A[i..j] where dimension of A[i] is 
            p[i-1] x p[i] */

            // cost is zero when multiplying
            // one matrix.
            for (i = 1; i < n; i++)
                m[i, i] = 0;

            // L is chain length.
            for (L = 2; L < n; L++)
            {
                for (i = 1; i < n - L + 1; i++)
                {
                    j = i + L - 1;
                    if (j == n)
                        continue;
                    m[i, j] = int.MaxValue;
                    for (k = i; k <= j - 1; k++)
                    {
                        // q = cost/scalar multiplications
                        q = m[i, k] + m[k + 1, j] + p[i - 1] * p[k] * p[j];
                        if (q < m[i, j])
                            m[i, j] = q;
                    }
                }
            }

            return m[1, n - 1];
        }

        // Driver program to test above function
        public static void MatrixChainMultiplication()
        {
            int[] arr = new int[] { 1, 2, 3, 4 };
            int size = arr.Length;

            Console.Write("Minimum number of "
                          + "multiplications is " + MatrixChainOrder(arr, size));

        }

        /* Utility function to get max of 2 integers */
        static int max(int a, int b)
                {
                    return (a > b) ? a : b;
                }


                 //Returns length of LCS for X[0..m-1], Y[0..n-1] 
                static int lcs(char[] X, char[] Y, int m, int n)
                {
                    if (m == 0 || n == 0)
                        return 0;
                    if (X[m - 1] == Y[n - 1])
                        return 1 + lcs(X, Y, m - 1, n - 1);
                    else
                        return max(lcs(X, Y, m, n - 1), lcs(X, Y, m - 1, n));
                }

                public static void LongestCommonSubsequence()
                {
                    String s1 = "AGGTAB";
                    String s2 = "GXTXAYB";

                    char[] X = s1.ToCharArray();
                    char[] Y = s2.ToCharArray();
                    int m = X.Length;
                    int n = Y.Length;

                    Console.Write("Length of LCS is" + " "
                                + lcs(X, Y, m, n));
                }   

    }
}
