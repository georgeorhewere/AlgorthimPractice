using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorthimPractice
{
    public class MinimumSequence
    {
        private int L = 0;
        private int R = 1;
        

        public void getMiniumSequence(int N)
        {
            Node root = new Node(null, N);
            //set L and R
            root.Left = new Node(root,L);
            root.Right = new Node(root,R);

            Console.WriteLine("Search " + root.Search(N));
            //generate next layer
            //root.generateNextLayer(N);
            //check if layer contain

            //print value
        //    root.printNode();

            

                       
        }


        //public bool isEqualToN(int L)
        //{
        //    return L.Equals(_N);
        //}

       


        public class Node
        {
            private Node parent;
            public Node(Node root, int value)   
            {
                Data = value;
            }
            public int Data { get; }
            public Node Left { get; set; }
            public Node Right { get; set; }  
            
            public void printNode()
            {
                var leftVal = Left == null ? "" : Left.Data.ToString();
                var rightVal = Right == null ? "" : Right.Data.ToString();

                Console.Write(this.Data);
                if (Left != null) {
                    Console.WriteLine(" = > " + leftVal + " , " + rightVal);
                }
                else { Console.WriteLine(); }

                if (Left != null)
                {                    
                    Left.printNode();
                }

                if (Right != null)
                {
                   Right.printNode();
                }
                
            }

            public int Search(int N)
            {
                var count = 0;

                if (Left.Data == N || Right.Data == N)
                    count++;
                else
                {
                    generateNextLayer();
                    if (Contains(N))
                    {
                        return 1;
                    }
                    else
                    {
                       

                    }

                    //count += Left.Search(N) + Right.Search(N);                    
                }
                return count;
            }

            public bool Contains(int N)
            {
                return Left.Left.Data == N || Left.Right.Data == N || Right.Right.Data == N || Right.Left.Data == N;


            }

            public void generateNextLayer()
            {
                generateLeftPath();
                generateRightPath();
                
            }
            private void generateLeftPath()
            {
                var nextLeft = (2 * Left.Data) - Right.Data;
                Left.Left = new Node(Left,nextLeft);
                Left.Right = new Node(Left,Right.Data);
            }
            private void generateRightPath()
            {
                var nextRight = (2 * Right.Data) - Left.Data;
                Right.Left = new Node(Right, Left.Data);
                Right.Right = new Node(Right, nextRight);
            }

        }

        //public class LeftNode : Node
        //{
        //    public LeftNode(int value):base(value)
        //    {
                
        //    }

        //}



    }
}
