using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_Project
{
    public class BST
    {
        private Node rootNode;
        private int count;
        //private int capacity;

        public int Count()
        {
            return count;
        }
        //public int Capacity
        //{
        //    get { return capacity; }
        //}

        public BST()
        {
            rootNode = null;
            count = 0;
        }
        public bool IsEmpty()
        {
            return rootNode == null;
        }

        public void AddNode(int derp)
        {
            if (IsEmpty())
            {
                rootNode = new Node(derp);
            }
            else
            {
                InsertData(ref rootNode, derp);
            }
            count++;
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
            else if (node.data >= data)
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

        public void Display()
        {
            if (!IsEmpty())
            {
                Display(rootNode);
            }
            else
            {
                Console.WriteLine("The tree is empty");
            }
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
