using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_Project
{
    public class LinkedList<T>
    {
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
        public void AddAtTail(T item)
        {
            Node<T> newNode = new Node<T>();
            newNode.item = item;
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node<T> temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }

        public bool SearchNode(T item)
        {
            Node<T> temp = this.head;
            bool matched = false;
            while (!(matched = temp.item.Equals(item)) && temp.next != null)
            {
                temp = temp.next;
            }
            return matched;
        }
    }
}
