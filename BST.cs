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
        public int Count()
        {
            return count;
        }

        public BST()
        {
            rootNode = null;
            count = 0;

        }
        public bool IsEmpty()
        {
            return rootNode == null;
        }

        public void AddNode(int d)
        {
            if (IsEmpty())
            {
                rootNode = new Node(d);
            }
            else
            {
                rootNode.InsertData(ref rootNode, d);
            }
            count++;
        }

        public bool SearchNode(Node node, int s)
        {
            //O(log n) logarithmic time
            if (node == null)
            {
                Console.WriteLine("the list is empty");
                return false;
            }

            //O(log n) logarithmic time

            if (node.data == s)
            {
                return true;
            }
            else if (node.data < s)
            {
                return SearchNode(node.right, s);
            }
            else if (node.data > s)
            {
                return SearchNode(node.left, s);
            }
            return false;
        }
        public void Display()
        {
            if (!IsEmpty())
                rootNode.Display(rootNode);
        }
        public void DisplayList()
        {
            Node node;
            if (rootNode == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.Write("List is : ");
            node = rootNode;
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.link;
            }
            Console.WriteLine();

        }
    }
}
