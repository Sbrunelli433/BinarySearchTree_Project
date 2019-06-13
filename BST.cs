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
        private bool IsEmpty()
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
        private void InsertData(ref Node node, int data)
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

        public bool Search(int x)
        {
            int position = 1;
            Node node = rootNode;
            while (node != null)
            {
                if (node.data == x)
                {
                    break;
                }
                else if (node.data <= x)
                {
                    position++;
                    node = node.right;
                }
                else if (node.data >= x)
                {
                    position++;
                    node = node.left;
                }

            }
            if (node == null)
            {
                Console.WriteLine($"{x} not found in list");
                return false;
            }
            else
            {
                Console.WriteLine($"{x} is at position {position}");
                return true;
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
                DisplayNodes(rootNode);
            }
            else
            {
                Console.WriteLine("The tree is empty");
            }
        }

        private void DisplayNodes(Node node)
        {
            if (node == null)
            {
                return;
            }
            DisplayNodes(node.left);
            Console.Write(" " + node.data);
            DisplayNodes(node.right);
        }

        public void Menu()
        {
            int choice;
            int data;
            while (true)
            {
                Console.WriteLine(" 1. Add Node");
                Console.WriteLine(" 2. Search for an element");
                Console.WriteLine(" 3. Display List");

                choice = int.Parse(Console.ReadLine());
                if (choice == 4)
                {
                    break;
                }
                switch(choice)
                {
                    case 1:
                        Console.WriteLine(" enter the element to be added: ");
                        data = int.Parse(Console.ReadLine());
                        AddNode(data);
                        break;
                    case 2:
                        Console.WriteLine(" enter the element to be searched: ");
                        data = int.Parse(Console.ReadLine());
                        Search(data);
                        break;
                    case 3:
                        Display();
                        break;
                }
            }
        }
    }
}
