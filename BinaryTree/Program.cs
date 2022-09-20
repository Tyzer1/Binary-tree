namespace BinaryTree
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var tree = new BinaryTree();
            tree.InsertNode(new Node(5));
            tree.InsertNode(new Node(3));
            tree.InsertNode(new Node(8));
            tree.InsertNode(new Node(9));
            tree.InsertNode(new Node(6));
            tree.InsertNode(new Node(4));
            tree.InsertNode(new Node(2));
            tree.InsertNode(new Node(7));
            tree.InsertNode(new Node(11));
            tree.InsertNode(new Node(10));
            tree.InsertNode(new Node(15));
            tree.InsertNode(new Node(14));
            tree.InsertNode(new Node(12));
            tree.InsertNode(new Node(13));
            tree.InsertNode(new Node(18));

            Node toDelete = tree.FindNode(11, tree.Root);
            tree.Delete(toDelete);
        }
    }
}