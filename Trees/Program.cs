using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trees
{
    class Node
    {
        public int data;
        public Node left, right;

        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }

    class BinaryTree
    {
        public void Inorder(Node root)
        {
            if (root == null)
            {
                return;
            }

            Inorder(root.left);
            Console.Write($"{root.data}, ");
            Inorder(root.right);
        }
        public void PostOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            PostOrder(root.left);
            PostOrder(root.right);
            Console.Write($"{root.data}, ");
        }

        public void PreOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            Console.Write($"{root.data}, ");
            PreOrder(root.left);
            PreOrder(root.right);
        }

        public int SumOfNodesInTree(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            return root.data + SumOfNodesInTree(root.right) + SumOfNodesInTree(root.left);
        }

    }
    /*           6
     *         /   \
     *        2     9
     *       / \   / \
     *      4  10  N   3
     *
     */
    class Program
    {
        static void Main(string[] args)
        {

            Node root = new Node(6);
            root.left = new Node(2);
            root.right = new Node(9);
            root.left.left = new Node(4);
            root.left.right = new Node(10);
            root.right.right = new Node(3);

            BinaryTree tree = new BinaryTree();
            tree.Inorder(root);
            Console.WriteLine();

            tree.PostOrder(root);
            Console.WriteLine();

            tree.PreOrder(root);
            Console.WriteLine();

            Console.WriteLine(tree.SumOfNodesInTree(root));

        }
    }
}
