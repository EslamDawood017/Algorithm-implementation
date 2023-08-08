using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Knapsack_Problem
{
    internal class Program
    {

        public class Item
        {
            public string Name;
            public decimal value;
            public decimal weight;
            public decimal ratio ;

            public Item(string name, decimal value, decimal weight)
            {
                this.Name = name;
                this.value = value;
                this.weight = weight;
                this.ratio = value / weight;
            }
        }
        public class Knapsask
        {
            public int MaxSize;
            public decimal CurrentSize;
            public decimal totalProfit;
            Item[] Collection = new Item[100];

            public Knapsask(int MaxSize )
            {
                this.MaxSize = MaxSize;
                CurrentSize = 0;
                totalProfit = 0;
                
            }
            public bool AddInKnapsak(Item item1)
            {
                if((MaxSize-CurrentSize) < item1.weight)
                {
                    item1.weight = (MaxSize - CurrentSize);
                    item1.value = item1.ratio * item1.weight;
                }
                if(CurrentSize < MaxSize)
                {
                    Collection.Append(item1);
                    CurrentSize += item1.weight;
                    totalProfit += item1.value;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        static void Main(string[] args)
        {
            decimal[] weight = { 1, 2, 10, 4, 3, 5 }; 
            decimal[] Values = { 4, 9, 12, 11, 6, 5 };
            Knapsask new_Knapsask = new Knapsask(12);
            bool Continue = true;
            Item[] ListOfItems = new Item[Values.Length];

            for (int i = 0; i < Values.Length; i++)
            {
                Item newItem = new Item("#" + i, Values[i], weight[i]);
                ListOfItems[i] = newItem;

            }

            ListOfItems = ListOfItems.OrderByDescending(i => i.ratio).ToArray();
            for (int i = 0; i < Values.Length; i++)
            {
                
                Continue = new_Knapsask.AddInKnapsak(ListOfItems[i]);
                if(Continue == false)
                {
                    break;
                }
            }

            

            Console.WriteLine(new_Knapsask.CurrentSize);
            Console.WriteLine(new_Knapsask.totalProfit);
            
        }
    }
}
