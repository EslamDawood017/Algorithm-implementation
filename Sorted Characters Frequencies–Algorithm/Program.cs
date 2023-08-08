using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;


internal class Program
{
    static public int [] SortedCharactersFrequencies(string text)
    {
        int[] arr = new int[128];
        int frequencies = 0;
        for(int j = 0; j < text.Length; j++ )
        {
            frequencies = (int)text[j];         
            arr[frequencies]++;
            
        } 
        
        return arr;
    }
    static public void  ASCIMethod(string message)
    {
        Hashtable List = new Hashtable();
        for(int i = 0; i < message.Length; i++)
        {
            if (List[message[i]] == null)
            {
                List[message[i]] = 1;
            }
            else
            {
                List[message[i]] = (int)List[message[i]] +1 ;
            }
        }
        SortHashTable(List);


    }
    static public void SortHashTable(Hashtable Freq)
    {
        int[,] arr = new int[Freq.Count, 2];
        int  i = 0 ;

        foreach(char n in Freq.Keys)
        {
            arr[i,0] = (int)n;
            arr[i,1] = (int)Freq[n];
            i++;
        }

        sort(arr , 0 , Freq.Count-1);

        for(int j = 0; j < Freq.Count; j++)
        {
            Console.Write((char)arr[j, 0] + ": ");
            Console.WriteLine(arr[j, 1]);
        }
    }
    static public void sort(int[,] array, int start, int end)
    {
        if (end <= start) return;

        int midpoint = (end + start) / 2;
        sort(array, start, midpoint);
        sort(array, midpoint + 1, end);
        merge(array, start, midpoint, end);
    }

    static public void merge(int[,] array, int start, int mid, int end)
    {
        int i, j, k;
        int left_length = mid - start + 1;
        int right_length = end - mid;

        int[,] left_array = new int[left_length, 2];
        int[,] right_array = new int[right_length, 2];

        for (i = 0; i < left_length; i++)
        {
            left_array[i, 0] = array[start + i, 0];
            left_array[i, 1] = array[start + i, 1];
        }
        for (j = 0; j < right_length; j++)
        {
            right_array[j, 0] = array[mid + 1 + j, 0];
            right_array[j, 1] = array[mid + 1 + j, 1];
        }

        i = 0;
        j = 0;
        k = start;
        while (i < left_length && j < right_length)
        {
            if (left_array[i, 1] <= right_array[j, 1])
            {
                array[k, 0] = left_array[i, 0];
                array[k, 1] = left_array[i, 1];
                i++;
            }
            else
            {
                array[k, 0] = right_array[j, 0];
                array[k, 1] = right_array[j, 1];
                j++;
            }
            k++;
        }
        while (i < left_length)
        {
            array[k, 0] = left_array[i, 0];
            array[k, 1] = left_array[i, 1];
            i++;
            k++;
        }
        while (j < right_length)
        {
            array[k, 0] = right_array[j, 0];
            array[k, 1] = right_array[j, 1];
            j++;
            k++;
        }

    }
    static void Main(string[] args)
    {
        int[] list = new int[128];
        //list = SortedCharactersFrequencies("Hello World");
        //for(int i = 0; i < list.Length; i++)
        //{
        //    if (list[i] == 0 )  continue;
        //    Console.WriteLine((char)i  + ": " + list[i] );  
        //}

        Console.WriteLine();

        ASCIMethod("Hello World");

    }
}

