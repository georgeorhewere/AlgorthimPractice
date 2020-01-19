using System;

namespace AlgorthimPractice
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //callQuickFind();
            callQuickUnion();

        }

        static void callQuickFind()
        {
            Console.WriteLine("Quick Find Test!");
            QuickFind stub = new QuickFind(10);
            Console.WriteLine(stub.isConnected(1, 2));
            stub.union(1, 2);
            Console.WriteLine(stub.isConnected(1, 2));
            Console.WriteLine("Number of Connected components " + stub.numberOfConnectedComponents());
            stub.union(3, 4);
            stub.union(5, 6);
            stub.union(7, 6);
            Console.WriteLine("Number of Connected components " + stub.numberOfConnectedComponents());
        }
        static void callQuickUnion()
        {
            Console.WriteLine("Quick Union Test!");
            QuickUnion stub = new QuickUnion(10);
            Console.WriteLine(stub.isConnected(1, 2));
            stub.union(1, 2);
            Console.WriteLine(stub.isConnected(1, 2));        
            stub.union(3, 4);
            stub.union(5, 6);
            stub.union(7, 6);
            Console.WriteLine(stub.isConnected(5, 7));

        
        }

    }
}
