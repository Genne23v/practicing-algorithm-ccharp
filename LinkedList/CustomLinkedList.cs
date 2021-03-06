using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class CustomLinkedList
    {
        Node head;

        public class Node
        {
            public int data;
            public Node next;
            public Node(int d) { data = d; }
        }

        public void deleteKthNodeFromEnd(int k)
        {
            if (head == null || k == 0) return;

            Node first = head;
            Node second = head;

            for (int i=0; i< k; i++)
            {
                second = second.next;
                if(second.next == null)
                {
                    if (i == k-1)
                    {
                        head = head.next;
                    }
                    return;
                }
            }

            while (second.next != null)
            {
                first = first.next;
                second = second.next;
            }

            first.next = first.next.next;
        }

        public void deletebackHalf()
        {
            if (head == null || head.next == null)
            {
                head = null;
            }

            Node slow = head;
            Node fast = head;
            Node prev = null;
            
            while(fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }
            prev.next = null;
        }

        public void displayContent()
        {
            Node current = head;

            while(current != null)
            {
                Console.Write(current.data + "->");
                current = current.next;
            }
        }
        static void Main(string[] args)
        {
            CustomLinkedList linkedList = new CustomLinkedList();
            Node firstNode = new Node(3);
            Node secondNode = new Node(4);
            Node thirdNode = new Node(5);
            Node fourthNode = new Node(6);

            linkedList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;

            linkedList.displayContent();
            linkedList.deleteKthNodeFromEnd(2);
            Console.WriteLine();
            linkedList.displayContent();

            linkedList.displayContent();
            linkedList.deletebackHalf();
            Console.WriteLine();
            linkedList.displayContent();
        }
    }
}
