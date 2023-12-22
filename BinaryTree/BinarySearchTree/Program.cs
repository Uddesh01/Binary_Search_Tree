using BinaryTree;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();
        bst.insert(5);
        bst.insert(7);
        bst.insert(3);
        bst.insert(2);
        bst.insert(4);
        bst.insert(6);
        bst.insert(9);

        bst.PreorderTraversal();
        bst.InorderTraversal();
    }
}