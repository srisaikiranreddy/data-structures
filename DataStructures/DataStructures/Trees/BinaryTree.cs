using System;
using System.Collections.Generic;

namespace DataStructures.Trees
{
    public class BinaryTree
    {
        public BinaryTree()
        {
            Console.Write("\nBinaryTree Inorder traversal");
            root = new Node(10);
            root.left = new Node(11);
            root.left.left = new Node(7);
            root.right = new Node(9);
            root.right.left = new Node(15);
            root.right.right = new Node(8);

            Console.Write("\nInorder traversal before insertion:");
            InOrder(root);

            int key = 12;
            Insert(root, key);

            Console.Write("\nInorder traversal after insertion:");
            InOrder(root);
        }

        public class Node
        {
            public int _key;
            public Node right, left;

            public Node(int key)
            {
                _key = key;
                left = null;
                right = null;
            }
        }

        static Node root;

        static void InOrder(Node temp)
        {
            if (temp == null)
                return;

            InOrder(temp.left);
            Console.Write(temp._key + " ");
            InOrder(temp.right);
        }

        static void Insert(Node temp, int key)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(temp);

            // Do level order traversal until we find  
            // an empty place.  
            while (q.Count != 0)
            {
                temp = q.Peek();
                q.Dequeue();

                if (temp.left == null)
                {
                    temp.left = new Node(key);
                    break;
                }
                else
                    q.Enqueue(temp.left);

                if (temp.right == null)
                {
                    temp.right = new Node(key);
                    break;
                }
                else
                    q.Enqueue(temp.right);
            }
        }

    }
}
