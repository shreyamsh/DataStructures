using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stacks
{



    public class Stack
    {
        private int maxSize;
        private string[] stackArray;
        private int top;

        Stack()
        {
            int size = 10;
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;
        }

        public void push(string val)
        {
            if (isFull())
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                top++;
                stackArray[top] = val;
            }
        }

        private bool isFull()
        {
            return (maxSize - 1 == top);
        }

        public string pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("The stack is empty");
                return "--";
            }
            else
            {
                int old_top = top;
                top--;
                return stackArray[old_top];
            }
        }

        private bool isEmpty()
        {
            return (top == -1);
        }

        public string peek()
        {
            return stackArray[top];
        }

        public static void Main(string[] args)
        {
            Stack theStack = new Stack();
            theStack.push("Avengers");
            theStack.push("Captain America");
            theStack.push("Iron Man");
            theStack.push("Captain Marvel");

            Console.WriteLine(theStack.peek());

            Console.WriteLine("===================\n The Stack contains: \n");
            while (!theStack.isEmpty())
            {
                string movies = theStack.pop();
                Console.WriteLine(movies);
            }
        }
    }
}
