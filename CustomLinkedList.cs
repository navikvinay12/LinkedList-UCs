using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUCs
{
    public class CustomLinkedList
    {
        public Node head;
        public void AddLast(int data)
        {
            Node newNode=new Node(data);
            if(head==null)
                head = newNode;
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next= newNode;
            }
        }       //creating LinkedList UC1
        public void AddFirst(int data)      //AddFirst UC2
        {
            Node newNode=new Node(data);
            newNode.next= head;
            head = newNode;
            Console.WriteLine($"{newNode.data} is added into the list.");
        }
        public void Display()
        {
            Console.Write("Displaying Nodes ");
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            else
            {
                while(temp!=null)
                {
                    Console.Write(temp.data+ " ");
                    temp=temp.next;
                }
            }
            Console.WriteLine();
        }


    }
}
