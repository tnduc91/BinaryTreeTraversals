using System.Collections.Generic;
using System;
namespace BinaryTreeTraversals
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = InitTree();
            var preOrder = new List<int>();
            var inOrder = new List<int>();
            var postOrder = new List<int>();
            Traversals.PreOrder(root, ref preOrder);
            Traversals.InOrder(root, ref inOrder);
            Traversals.PostOrder(root, ref postOrder);
            
            Console.WriteLine(String.Join(',', preOrder));
            Console.WriteLine(String.Join(',', inOrder));
            Console.WriteLine(String.Join(',', postOrder));
        }

        public static Node InitTree()
        {
            var n1 = new Node(10);
            var n2 = new Node(15);
            var n3 = new Node(30);
            var n4 = new Node(3);
            var n5 = new Node(6);
            var n6 = new Node(2);
            var n7 = new Node(5);
            var n8 = new Node(9);
            var n9 = new Node(8);

            n1.Left = n2;
            n1.Right = n3;

            n2.Left = n4;
            n2.Right = n5;

            n4.Left = n7;

            n3.Right = n6;

            n6.Left = n8;
            n6.Right = n9;

            return n1;
        }
    }
}
