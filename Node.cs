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
            if (node == null)
            {
                node = new Node(data);
            }
            else if (node.data <data)
            {
                InsertData(ref node.right, data);
            }
            else if (node.data>data)
            {
                InsertData(ref node.left, data);
            }
        }
        public void Display(Node node)
        {
            if (node == null)
                return;

            Display(node.left);
            Console.Write(" " + node.data);
            Display(node.right);
        }


    }
}
