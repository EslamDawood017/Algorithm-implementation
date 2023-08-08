using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    class HeapNode
    {
        public char data;
        public int freq;
        public HeapNode LeftNode;
        public HeapNode RightNode;
        public HeapNode(char data, int freq)
        {
            this.data = data;  
            this.freq = freq;
            this.LeftNode = this.RightNode = null;
        }
    }
    public class Huffman
    {
        private PriorityQueue<HeapNode, int> minQueue = new PriorityQueue<HeapNode, int>();
        public Huffman(string message)
        {
            Hashtable freqHash = new Hashtable();

            int i ;
            for(i = 0; i < message.Length;i++)
            {
                if (freqHash[message[i]] == null)
                {
                    freqHash[message[i]] = 1;
                }
                else
                {
                    freqHash[message[i]] = (int)(freqHash[message[i]])+1;
                }
            }
        }
    }

    static void Main(string[] args)
    {
    }
}

