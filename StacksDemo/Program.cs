using System;
using System.Collections.Generic;

namespace StacksDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // defining a new stack
            Stack<int> stack = new Stack<int>();
            // add elements to the stack using Push()
            stack.Push(1);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
            stack.Push(1337);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
            stack.Push(15);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
            // Peek() will return the element at the top of the stack without removing it
            int myStackItem = stack.Pop();
            Console.WriteLine("Popped item: {0}", myStackItem);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());

            while (stack.Count > 0)
            {
                Console.WriteLine("The Top value {0} was removed from the stack", stack.Pop());
                Console.WriteLine("Current stack count is : {0}",stack.Count);
            }

        }
    }
}
