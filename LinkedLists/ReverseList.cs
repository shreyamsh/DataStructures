using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists
{
    class ReverseList
    {
        Node head;

        public class Node
        {
            public Node next;
            public int data;

            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        public void printList()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.data + "->");
                n = n.next;
            }
            // Time complexity: O(n)
        }

        #region Insert at tail
        public void AddNode(Node node)
        {
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        #endregion

        #region Reverse List
        public void reverseList()
        {
            Node prev = null, next = null, curr = head;

            // Traverse through the list.
            while (curr != null)
            {
                // Store the current node's next before changing it. 
                next = curr.next;

                // Change the next of current . This is where the actual reversing happens.
                curr.next = prev;

                // Move prev and curr one step forward.
                prev = curr;
                curr = next;
            }
            head = prev;
        }

        #endregion

        static void main(string[] args)
        {
            ReverseList llist = new ReverseList();

            llist.AddNode(new Node(1));
            llist.AddNode(new Node(2));
            llist.AddNode(new Node(3));
            llist.AddNode(new Node(4));

            Console.WriteLine("Constructed Linked List");
            llist.printList();

            llist.reverseList();
            Console.WriteLine("Reversed Linked List");
            llist.printList();
        }
    }
}
