using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUCs
{
    internal class DefaultLinkedList
    {
        public static void AddingElements()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(56);
            list.AddLast(30);
            list.AddLast(70);

            foreach (var item in list)
            {
                Console.Write(item+" ");
            }
        }
    }
}
