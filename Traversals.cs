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
    }
}