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

        public void AddNode(int derp)
        {
            if (IsEmpty())
            {
                rootNode = new Node(derp);
            }
            else
            {
                rootNode.InsertData(ref rootNode, derp);
            }
            count++;
        }

        public void Search(int toSearch)
        {
            rootNode.SearchNode(rootNode, toSearch);
        }

        public void Display()
        {
            if (!IsEmpty())
            {
                rootNode.Display(rootNode);
            }
        }
    }
}
