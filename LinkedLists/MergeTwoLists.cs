using System;
using System.Collections.Generic;

namespace DataStructures.LinkedLists
{
    class MergeTwoLists
    {
        public LinkedListNode<int> mergeTwoLists(LinkedListNode<int> l1, LinkedListNode<int> l2)
        {
            LinkedListNode<int> dummyHead = new LinkedListNode<int>(0);
            LinkedListNode<int> p = dummyHead;

            p = p.Next;

            while (l1 != null && l2 != null)
            {
                // If current value is less than or greater than the other list, merged list will have that value.
                // Traverse to the next element.
                if (l1.Value < l2.Value)
                {
                    p = l1;
                    l1 = l1.Next;
                }
                else
                {
                    p = l2;
                    l2 = l2.Next;
                }
            }

            // Traverse both lists.
            if (l1 != null) p = l1;
            if (l2 != null) p = l2;

            // return new list's head as dummyHead's next node.
            return dummyHead.Next;
        }

        LinkedListNode<int> head = new LinkedListNode<int>(0);

        public void printList()
        {
            LinkedListNode<int> n = head;
            while (n != null)
            {
                Console.Write(n.Value + "->");
                n = n.Next;
            }
            // Time complexity: O(n)
        }

        // Driver Code  
        public static void Main(string[] args)
        {
            /* Let us create two sorted linked  
            lists to test the methods  
            Created lists:  
                   llist1: 5->10->15,  
                llist2: 2->3->20  
            */
            LinkedList<int> llist1 = new LinkedList<int>();
            LinkedList<int> llist2 = new LinkedList<int>();

            // Node head1 = new Node(5);  
            llist1.AddFirst(5);
            llist1.AddLast(10);
            llist1.AddLast(15);

            // Node head2 = new Node(2);  
            llist2.AddFirst(2);
            llist2.AddLast(3);
            llist2.AddLast(20);

            LinkedListNode<int> final = new MergeTwoLists().mergeTwoLists(llist1.First, llist2.First);
        }
    }
}
