using System.Collections.Generic;
using System.Collections;
using System;

namespace BinaryTreeTraversals
{
    public static class Traversals
    {
        public static void PreOrder(Node root, ref List<int> result)
        {
            if (root != null){
                result.Add(root.Value);
                PreOrder(root.Left, ref result);
                PreOrder(root.Right, ref result);
            }
        }

        public static void InOrder(Node root, ref List<int> result)
        {
            if (root != null){
                InOrder(root.Left, ref result);
                result.Add(root.Value);
                InOrder(root.Right, ref result);
            }
        }


        public static void PostOrder(Node root, ref List<int> result)
        {
            if (root != null){
                PostOrder(root.Left, ref result);
                PostOrder(root.Right, ref result);
                result.Add(root.Value);
            }
        }

        // Complexity = O(n)
        public static void GetLeafNodes(Node root, ref List<int> result)
        {
            if (root == null)
                return;

            if (root.Left == null && root.Right == null)
            {
                result.Add(root.Value);
            }

            GetLeafNodes(root.Left, ref result);
            GetLeafNodes(root.Right, ref result);
        }

        public static void GetLeavesWithDepth(Node root, int currentLevel, ref Dictionary<int,int> result)
        {
            if (root == null)
                return;

            if (root.Left == null && root.Right == null)
            {
                result.Add(root.Value, currentLevel);
            }

            GetLeavesWithDepth(root.Left, currentLevel + 1, ref result);
            GetLeavesWithDepth(root.Right, currentLevel + 1, ref result);
        }

        // Tree traversal using Queue
        public static int GetSumOfDeepestLeavesUsingQueue(Node root)
        {
            if (root == null){
                return 0;
            }
            var sum = 0;
            var maxLevel = 0;
            var queue = new Queue<Tuple<Node, int>>();
            var tuple = new Tuple<Node, int>(root, 0);
            queue.Enqueue(tuple);

            while(queue.Count != 0)
            {
                var picked = queue.Dequeue();
                var pickedDepth = picked.Item2;
                if (picked.Item1.Left == null && picked.Item1.Right == null){
                    if (pickedDepth > maxLevel){
                        maxLevel = pickedDepth;
                        sum = picked.Item1.Value;
                    }else if (pickedDepth == maxLevel)
                    {
                        sum += picked.Item1.Value;
                    }
                }else{ 
                    if (picked.Item1.Left != null) queue.Enqueue(new Tuple<Node, int>(picked.Item1.Left, pickedDepth + 1));
                    if (picked.Item1.Right != null) queue.Enqueue(new Tuple<Node, int>(picked.Item1.Right, pickedDepth + 1));
                }

            }

            return sum;

        }


    }
}