using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorthimPractice
{
    public class QuickUnion
    {
        //Algorithm for dynamic connectivity
        int[] idArray;
        public QuickUnion(int N)
        {
            idArray = new int[N];

            for (int x = 0; x < N; x++)
            {
                idArray[x] = x;
            }
        }

        //find root 
        public int getRoot(int item)
        {
            //too much work to be done in this array
            while(item != idArray[item])
            {
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

            idArray[idP] = idQ;         
        }


    }
}
