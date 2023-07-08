using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Documents;

internal class Program
{
    public static LinkedList<int> ActivitySelectionProblem(int[] start , int[] end)
    {
        LinkedList<int> result = new LinkedList<int>();
        result.AddLast(0);
        int j = 0 , k = 1 ;
        for(int i = 1; i < start.Length; i++)
        {
            if (start[i] >= end[j])
            {
                result.AddLast(i) ;
                k++;
                j = i ;
            }
        }
        return result;
    }
    static void Main(string[] args)
    {
        int[] start = { 9, 10, 11, 12, 13, 15 };
        int[] end = { 11, 11, 12, 14, 15, 16 };
        foreach (int i in ActivitySelectionProblem(start, end))
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();



    }
}

