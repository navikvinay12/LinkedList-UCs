using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUCs
{
    public class SortedLinkedList<T> : LinkedList<T> where T : IComparable
    {
        public Node<T> head;
        public void Add(T data)     //UC10 Sort and Add elements.
        {
            Node<T> newNode = new Node<T>(data);
            if(this.head==null || newNode.data.CompareTo(head.data)<=0)
            {
                newNode.next = this.head;      
                this.head = newNode;
            }
            else
            {
                Node<T> temp = this.head;
                while(temp.next!=null && newNode.data.CompareTo(temp.next.data)>0)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;
            }
            Console.WriteLine($"{newNode.data} inserted into Linked list");
        }
        public void DisplayLinkedList() //UC10 Display().
        {
            Node<T> temp = head;
            if (temp == null)
                Console.WriteLine("Linked List is empty");
            else
            {
                Console.WriteLine("Linked list elements\n");
                while (temp != null)
                {
                    Console.WriteLine(" " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }

}
