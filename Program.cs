using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            BST binarySearchTree = new BST();

            binarySearchTree.AddNode(1);
            binarySearchTree.AddNode(6);
            binarySearchTree.AddNode(7);
            binarySearchTree.AddNode(8);
            binarySearchTree.AddNode(10);
            binarySearchTree.AddNode(9);
            binarySearchTree.AddNode(7);
            binarySearchTree.AddNode(7);
            binarySearchTree.AddNode(9);
            binarySearchTree.AddNode(15);

            binarySearchTree.Display();
            Console.ReadLine();




        }
    }
}
