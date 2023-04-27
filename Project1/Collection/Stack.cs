using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Collection
{
    internal class Stack
    {
        public  static void aain(string[] args)
        {
            // Create a new stack of integers
            Stack<int> numbers = new Stack<int>();

            // Push some numbers onto the stack
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);

            // Print the number of items on the stack
            Console.WriteLine("The stack contains {0} items.", numbers.Count);

            // Pop items off the stack in reverse order
            Console.WriteLine("Popping items off the stack:");
            while (numbers.Count > 0)
            {
                int number = numbers.Pop();
                Console.WriteLine(number);
            }

            // Check if the stack is empty
            if (numbers.Count == 0)
            {
                Console.WriteLine("The stack is now empty.");
            }
            else
            {
                Console.WriteLine("The stack is not empty.");
            }
        }
    }
}
