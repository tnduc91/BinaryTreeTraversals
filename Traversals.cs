using System.Collections.Generic;
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

        

    }
}