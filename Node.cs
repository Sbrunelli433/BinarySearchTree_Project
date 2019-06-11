using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_Project
{
    public class Node<T>
    {
        public T item;
        public Node<T> next;
        public Node()
        {
            this.next = null;
        }


    }
}
