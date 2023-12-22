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