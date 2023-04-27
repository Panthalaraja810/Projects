using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Collection
{
    internal class Queue
    {
        public static void aain(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();

            myQueue.Enqueue("item1");
            myQueue.Enqueue("item2");
            myQueue.Enqueue("item3");

            Console.WriteLine("Items in queue:");
            foreach (string item in myQueue)
            {
                Console.WriteLine(item);
            }

            string firstItem = myQueue.Dequeue();
            Console.WriteLine("First item removed from queue: " + firstItem);

            string nextItem = myQueue.Peek();
            Console.WriteLine("Next item in queue: " + nextItem);

            Console.WriteLine("Items in queue after removal:");
            foreach (string item in myQueue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
