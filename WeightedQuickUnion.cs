using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorthimPractice
{
    public class WeightedQuickUnion
    {
        //Weighted Union maintains an extra array that keeps track of the size of the treee
        int[] idArray;
        int[] treeSize;
        public WeightedQuickUnion(int N)
        {
            idArray = new int[N];
            treeSize = new int[N];

            for (int x = 0; x < N; x++)
            {
                idArray[x] = x;
                treeSize[x] = 1;
            }
        }

        //find root 
        public int getRoot(int item)
        {
            //too much work to be done in this array
            while (item != idArray[item])
            {
                //path compression
                //set root to previously set root
                idArray[item] = idArray[idArray[item]];
                item = idArray[item];
            }
            return item;
        }

        //isConnected
        public bool isConnected(int p, int q)
        {
            return getRoot(p) == getRoot(q);
        }
        ////union
        public void union(int p, int q)
        {
            int idP = getRoot(p);
            int idQ = getRoot(q);
            //set the root of p to the root of q

            if (idP == idQ)
                return;
            //weight by size
            if(treeSize[idP] < treeSize[idQ])
            {
                idArray[idP] = idQ;
                treeSize[idQ] += treeSize[idP];
            }
            else
            {
                idArray[idQ] = idP;
                treeSize[idP] += treeSize[idQ];
            }            
        }

        public int getRootSize(int p)
        {
            return treeSize[p];

        }

        public int numberOfConnectedComponents()
        {
            return idArray.Where(c => hasConnectedItems(c)).Distinct().Count();
        }

        private bool hasConnectedItems(int item)
        {
            //gives invalid count
            return idArray.Where(x => x == idArray[item]).Count() > 1;
        }

        public void printArray()
        {
            foreach (var c in idArray)
                Console.Write(c + " , ");

            Console.WriteLine();

        }
    }
}
