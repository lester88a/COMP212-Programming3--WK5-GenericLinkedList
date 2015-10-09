using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates a linked list
            LinkedList<string> linked1 = new LinkedList<string>();
            
            //appending three elements to the list
            linked1.AddLast("One");
            linked1.AddLast("Two");
            linked1.AddLast("Three");
            linked1.AddFirst("Zero");
            PrintLinked1(linked1);

            Console.WriteLine();
            //insterting a node between element "Two" and "Three"
            LinkedListNode<string> myNode = linked1.Find("Three");
            linked1.AddBefore(myNode, "Inserted using add before.");
            PrintLinked1(linked1);

            //removing one element
            linked1.Remove("One");
            PrintLinked1(linked1);

            //remove Three using myNode
            myNode = linked1.Find("Three");
            linked1.Remove(myNode);
            PrintLinked1(linked1);
        }

        private static void PrintLinked1(LinkedList<string> linked1)
        {
            Console.WriteLine();
            foreach (var item in linked1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
