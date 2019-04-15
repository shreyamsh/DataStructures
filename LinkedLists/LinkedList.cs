using System;

namespace DataStructures
{
    public class LinkedList
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
            while(n != null)
            {
                Console.Write(n.data + "->");
                n = n.next;
            }
            // Time complexity: O(n)
        }

        #region Insert at front
        public void push(int newData)
        {
            // Create a new node and insert the data.
            Node newNode = new Node(newData);

            // Make next of new Node as head.
            newNode.next = head;

            // Move the head to point to new Node
            head = newNode;
            // Time complexity: O(1)
        }
        #endregion

        #region Insert after a given node
        public void insertAfterANode(Node prevNode, int newData)
        {
            if (prevNode == null)
            {
                Console.WriteLine("Previous node cannot be null");
                return;
            }

            // Create a new node and insert the data.
            Node newNode = new Node(newData);

            // Make next of new Node as next of previous node
            newNode.next = prevNode.next;

            // Make the previous node point to new Node
            prevNode.next = newNode;
            // Time complexity: O(1)
        }
        #endregion

        #region Insert after at the end 
        public void append(int newData)
        {
  
            // Create a new node and insert the data. Also set the next as null
            Node newNode = new Node(newData);

            // If head is null make new Node as head
            if (head == null)
            {
                head = new Node(newData);
                return;
            }

            // Make next of new Node as null
            newNode.next = null;

            // Traverse till the end
            Node tail = head;
            while (tail.next != null)
            {
                tail = tail.next;
            }

            // Change the next of last node
            tail.next = newNode;

            // Time complexity: O(n)
        }
        #endregion

        #region Delete Node given key
        void deleteNode (int key)
        {
            // Store node head
            Node temp = head, prev = null;

            // If head node holds the key to be deleted
            if (temp == null || temp.data == key)
            {
                head = temp.next;
                return;
            }

            // Search for the key to be delted, keep track of prev Node as we need to change temp.next
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }

            // If key was not present in the list
            if (temp == null) return;

            prev.next = temp.next;
        }
        #endregion

        void deletNodeAtPosition(int position)
        {
            Node temp = head;
            //Base Case
            if (head == null)
            {
                return;
            }

            // If position at head. 
            if (position == 0)
            {
                head = temp.next;   // Change head
                return;
            }

            // Find the previous of node to be deleted. 
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }

            // If position is more than number of nodes
            if (temp == null || temp.next == null)
            {
                return;
            }

            // Unlink the deleted node from the list.
            temp.next = temp.next.next;
        }

        public int getLength()
        {
            Node temp = head;
            int count = 0;

            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }

        static void Main(string[] args)
        {
            LinkedList llist = new LinkedList();
            llist.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            llist.head.next = second;
            second.next = third;

            llist.append(6);
            llist.push(7);
            llist.push(1);
            llist.push(8);
            llist.push(0);
            llist.insertAfterANode(llist.head.next, 8);


            Console.WriteLine("Constructed Linked List");
            llist.printList();

            llist.deletNodeAtPosition(3);
            Console.WriteLine("\n");
            Console.WriteLine("Linked List after deleting at a position");

            llist.printList();

            llist.deleteNode(8);
            Console.WriteLine("\n");
            Console.WriteLine("Linked List after deleting, given key");
            llist.printList();

            Console.WriteLine("\n");
            Console.WriteLine("Length of Linked List is:" + llist.getLength());
        }
    }
}
