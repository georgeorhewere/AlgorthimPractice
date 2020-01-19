using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorthimPractice
{
    public class QuickFind
    {
        int[] itemArray;

        public QuickFind(int N)
        {
            itemArray = new int[N];
            
            for (int x =0; x< N; x++)
            {
                itemArray[x] = x;
            }

        }




    }
}
