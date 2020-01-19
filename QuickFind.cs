using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgorthimPractice
{
    public class QuickFind
    {
        //Algorithm for dynamic connectivity

        int[] itemArray;

        public QuickFind(int N)
        {
            itemArray = new int[N];
            
            for (int x =0; x< N; x++)
            {
                itemArray[x] = x;
            }

        }

        public bool isConnected(int p, int q)
        {
            return itemArray[p] == itemArray[q];
        }

        public void union(int p, int q)
        {
            int idP = itemArray[p];
            int idQ = itemArray[q];

            int count = itemArray.Length;
            for(int x = 0; x < count; x++)
            {
                if(itemArray[x] == idP)
                {
                    itemArray[x] = idQ;
                }
            }

        }


        public int numberOfConnectedComponents()
        {
            return itemArray.Where(c => hasConnectedItems(c)).Distinct().Count();
        }

        private bool hasConnectedItems(int item)
        {
            return itemArray.Where(x => x == itemArray[item]).Count() > 1;
        }


    }
}
