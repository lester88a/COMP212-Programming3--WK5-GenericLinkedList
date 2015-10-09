using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomeLinkedList
{
    class LinkedList
    {
        private Node head;
        public void printAllNode()
        {
            Node current = head;//point to head

            while (current !=null)//as long as it contains data, write
            {
                Console.WriteLine(current.data);
                current = current.next;

            }
        }
        public void AddFirst(Object data)
        {
            Node toAdd = new Node();
            toAdd.data = data;

            toAdd.next = head;
            head = toAdd;
        }

        public void AddLast(Object data)
        {
            if (head==null)
            {
                head = new Node();
                head.data = data;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = toAdd;
            }
        }
    }
}
