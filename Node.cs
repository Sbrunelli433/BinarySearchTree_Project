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
    }
}
