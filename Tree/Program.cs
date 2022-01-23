using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Program
    {
        class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Data { get; set; }
        }

        class BinarySearchTree
        {
            public static Node Insert(Node root, int value)
            {
                if (root == null)
                {
                    root = new Node();
                    root.Data = value;
                }
                else
                {
                    if (value < root.Data)
                    {
                        root.Left = Insert(root.Left, value);
                    }
                    else if (value > root.Data)
                    {
                        root.Right = Insert(root.Right, value);
                    }
                }
                return root;
            }

            public static Boolean Contains(Node root, int value)
            {
                if (root == null)
                {
                    return false;
                }
                else if(value < root.Data)
                {
                    return Contains(root.Left, value);
                }
                else if (value > root.Data)
                {
                    return Contains(root.Right, value);
                }
                else
                {
                    return true;
                }
            }
        }

        class BinaryTree
        {
            public static void preOrderTraversal(Node root)
            {
                if (root == null) return;

                Console.WriteLine(root.Data + " ");
                preOrderTraversal(root.Left);
                preOrderTraversal(root.Right);
            }

            public static void inOrderTraversal(Node root)
            {
                if (root == null) return;

                inOrderTraversal(root.Left);
                Console.WriteLine(root.Data + " ");
                inOrderTraversal(root.Right);
            }
            public static void postOrderTraversal(Node root)
            {
                if (root == null) return;

                postOrderTraversal(root.Left);
                postOrderTraversal(root.Right);
                Console.WriteLine(root.Data + " ");
            }
        }


        static void Main(string[] args)
        {
            Node rootNode = new Node();
            rootNode.Data = 4;

            Node nodeOne = new Node();
            nodeOne.Data = 1;
            Node nodeThree = new Node();
            nodeThree.Data = 3;
            Node nodeEight = new Node();
            nodeEight.Data = 8;
            Node nodeNine = new Node();
            nodeNine.Data = 9;
            Node nodeSix = new Node();
            nodeSix.Data = 6;

            rootNode.Left = nodeOne;
            rootNode.Right = nodeThree;
            nodeOne.Left = nodeEight;
            nodeOne.Right = nodeNine;
            nodeThree.Left = nodeSix;

            BinaryTree.preOrderTraversal(rootNode);
            Console.WriteLine();
            BinaryTree.inOrderTraversal(rootNode);
            Console.WriteLine();
            BinaryTree.postOrderTraversal(rootNode);
            Console.WriteLine();

            BinarySearchTree.Insert(rootNode, 2);
            BinarySearchTree.Insert(rootNode, 3);
            BinarySearchTree.Insert(rootNode, 5);
            BinarySearchTree.Insert(rootNode, 6);
            BinarySearchTree.Insert(rootNode, 4);

            Console.WriteLine(BinarySearchTree.Contains(rootNode, 4));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, 3));
            Console.WriteLine(BinarySearchTree.Contains(rootNode, -4));
            Console.WriteLine(BinarySearchTree.Contains(null, 4));
        }
    }
}
