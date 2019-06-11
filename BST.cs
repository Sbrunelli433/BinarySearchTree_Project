using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_Project
{
    class BST
    {
        private class Node<T>
        {
            public Node Next;
            public T Data;
        }
        private Node head = null;
        public void AddNode(T t)
        {
            Node newNode = new Node();
            newNode.Next = head;
            newNode.Data = t;
            head = newNode;
        }



        public Node<T> head { get; set; }
        public LinkedList()
        {
            this.head = null;
        }
        public void AddAtHead(T item)
        {
            Node<T> newNode = new Node<T>();
            newNode.item = item;
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                newNode.next = head;
                this.head = newNode;
            }
        }
    }
}
