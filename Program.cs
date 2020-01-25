using System;

namespace AlgorthimPractice
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //callQuickFind();
            //callQuickUnion();
            //callWeightedQuickUnion();
            callMinimumSequence();

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

        static void callWeightedQuickUnion()
        {
            Console.WriteLine("Weighted Quick Union Test!");
            WeightedQuickUnion stub = new WeightedQuickUnion(10);
            Console.WriteLine(stub.isConnected(1, 2));
            stub.union(1, 2);
            Console.WriteLine(stub.isConnected(1, 2));
            stub.union(3, 4);
            stub.union(5, 6);
            stub.union(7, 6);
            Console.WriteLine(stub.isConnected(5, 7));
            Console.WriteLine("Number of Connected components " + stub.numberOfConnectedComponents());
            Console.WriteLine("size of 5 " + stub.getRootSize(5));
            Console.WriteLine("size of 3 " + stub.getRootSize(3));
            Console.WriteLine("size of 4 " + stub.getRootSize(4));
            stub.union(3, 5);
            stub.union(4, 2);
            Console.WriteLine("size of 5 " + stub.getRootSize(5));
            Console.WriteLine("size of 3 " + stub.getRootSize(3));
            Console.WriteLine("size of 4 " + stub.getRootSize(4));
            Console.WriteLine("Number of Connected components " + stub.numberOfConnectedComponents());
            stub.printArray();


        }

        static void callMinimumSequence()
        {
            MinimumSequence min = new MinimumSequence();
            min.getMiniumSequence(2);
        }

    }
}
