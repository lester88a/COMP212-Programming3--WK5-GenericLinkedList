using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomeLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using AddFirst: ");
            LinkedList mylist1 = new LinkedList();
            mylist1.AddFirst("Hello");
            mylist1.AddFirst("World");
            mylist1.AddFirst("Li");
            mylist1.printAllNode();

            Console.WriteLine();
            Console.WriteLine("Using AddLast: ");
            LinkedList mylist2 = new LinkedList();
            mylist2.AddLast("Hello");
            mylist2.AddLast("World");
            mylist2.AddLast("Li");
            mylist2.printAllNode();
        }
    }
}
