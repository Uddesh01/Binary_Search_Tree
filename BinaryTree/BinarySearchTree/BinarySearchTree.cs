namespace BinaryTree
{
    public class BinarySearchTree
    {
        private Node root;

        public void insert(int value)
        {
            Node temp = root;

            Node node = new Node(value);
            if (temp == null)
            {
                root = node;
                return;
            }
            while (temp != null)

            {

                if (node.value < temp.value)
                {
                    if (temp.Left == null)
                    {
                        temp.Left = node;
                        return;
                    }
                    temp = temp.Left;
                }
                else if (node.value > temp.value)
                {
                    if (temp.Right == null)
                    {
                        temp.Right = node;
                        return;
                    }
                    temp = temp.Right;
                }
                else
                {
                    Console.WriteLine("value is already present");
                }
            }
        }

        public void PreorderTraversal()
        {
            Console.WriteLine("Pre-Order Traversal:");
            Preorder(root);
        }

        private void Preorder(Node node)
        {
            if (node != null)
            {
                Console.Write(node.value + " ");
                Preorder(node.Left);
                Preorder(node.Right);
            }

        }

        public void InorderTraversal()
        {
            Console.WriteLine("\nIn-Oreder Traversal:");
            Inorder(root);
        }
        private static void Inorder(Node node)
        {
            if (node != null)
            {
                Inorder(node.Left);
                Console.Write(node.value + " ");
                Inorder(node.Right);
            }
        }

        public void PostorderTraversal()
        {
            Console.WriteLine("\nPost-Order Traversal:");
            Postorder(root);
        }

        private void Postorder(Node node)
        {
            if (node != null)
            {
                Postorder(node.Left);
                Postorder(node.Right);
                Console.Write(node.value + " ");
            }
        }

        private class Node
        {
            public int value;
            public Node Left;
            public Node Right;

            public Node(int value)
            {
                this.value = value;
            }
        }
    }
}