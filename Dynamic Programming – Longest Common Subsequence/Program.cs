using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming___Longest_Common_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Text_01 = "HELLOWORLD";
            string Text_02 = "OHELOD";

            int n_Column = Text_01.Length;
            int m_Row = Text_02.Length;

            int[,] arr = new int[m_Row+1, n_Column+1];

            for(int j = 0; j< n_Column+1; j++)
            {
                arr[0,j] = 0;
            }

            for (int i = 0; i < m_Row + 1; i++)
            {
                arr[i, 0] = 0;
            }

            for(int i = 1; i < m_Row + 1; i++)
            {
                for(int j = 1; j < n_Column+1; j++)
                {
                    if (Text_02[i-1] == Text_01[j-1])
                    {
                        arr[i, j] = arr[i-1,j-1] + 1 ;
                    }
                    else
                    {
                        arr[i, j] = Math.Max(arr[i,j-1], arr[i-1,j]);
                    }
                }
            }

            


            Console.WriteLine(arr[m_Row , n_Column ]);
        }
    }
}
