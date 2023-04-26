using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Collection
{
    internal class LinkedList
    {
        public static void aain(string[] args)
        {
            var ll = new LinkedList<String>(); //creating object of LinkedList 
            ll.AddFirst("a");       //adding elements
            ll.AddFirst("b");
            ll.AddFirst("c");
            ll.AddLast("d");
            ll.AddLast("e");    
            ll.AddLast("f");
            ll.AddLast("f");
            ll.AddLast("f");
            

            foreach (var i in ll) //for each loop for iteration
            {
                Console.WriteLine(i);
            }

        Console.WriteLine("----------------------------------------");

            LinkedListNode<String> node =ll.Find("a"); //finding particular elements

            ll.AddBefore(node, "c");   //adding elements before particular element
            ll.AddAfter(node, "d");
            

            foreach (var item in ll)
            {
                Console.WriteLine(item);
            }


        }

       


    }
}
