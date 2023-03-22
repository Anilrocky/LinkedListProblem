using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is inserted to Linked list",node.data);
        }
        public void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data+" ");
                temp = temp.next;
            }
        }
        public void InsertAtParticularPosition(int position,int data)
        {
            Node newestNode = new Node(data);
            if (this.head == null)
            {
                this.head = newestNode;
            }
            if (position  == 0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
        }
        public void DeleteFirstElement()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");
            }            
            this.head = this.head.next;            
        }
        public void DeleteLastElement()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            if (head.next ==  null)
            {
                this.head = null;
            }
            Node NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
        }
        public int SearchElement(int value)
        {
            Node node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data == value)
                {
                    Console.WriteLine(count);
                }
                node = node.next;
                count++;
            }
            return count;
        }
        public void DeleteElementAtParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            Node temp = this.head;
            if (position == 0)
            {
                this.head.next = temp.next;
                return;
            }
            for (int i=0;temp!=null && i<position-1;i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = next;
        }
    }
}
