namespace BinaryTreeTraversals
{
    public class Node{
        public int Value{get;set;}
        public Node Left{get;set;}
        public Node Right{get;set;}

        public Node(int v){
            Value = v;
            Left = null;
            Right = null;
        }
    }
}