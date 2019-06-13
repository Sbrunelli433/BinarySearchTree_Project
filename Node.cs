using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_Project
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int value)
        {
            data = value;
            left = null;
            right = null;
        }
        public void InsertData(ref Node node, int data)
        {
            //O(log n) logarithmic time
            //sorts the data to the left or right side of the binary tree
            if (node == null)
            {
                node = new Node(data);
            }
            else if (node.data < data)
            {
                InsertData(ref node.right, data);
            }
            else if (node.data > data)
            {
                InsertData(ref node.left, data);
            }
        }

        public bool SearchNode(Node node, int stuff)
        {
            //O(log n) logarithmic time
            if (node == null)
            {
                Console.WriteLine("the list is empty");
                return false;
            }

            //O(log n) logarithmic time

            if (node.data == stuff)
            {
                return true;
            }
            else if (node.data < stuff)
            {
                return SearchNode(node.right, stuff);
            }
            else if (node.data > stuff)
            {
                return SearchNode(node.left, stuff);
            }
            return false;
        }

        public void Display(Node node)
        {
            if (node == null)
            {
                return;
            }
            Display(node.left);
            Console.Write(" " + node.data);
            Display(node.right);
        }
    }
}
