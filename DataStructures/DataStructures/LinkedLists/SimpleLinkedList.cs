using System;
using System.Net.Http.Headers;

namespace DataStructures.LinkedLists
{
    public class SimpleLinkedList
    {
        SimpleLinkedListNode head;
        public SimpleLinkedList()
        {
            SimpleLinkedList first = new SimpleLinkedList();
            first.head = new SimpleLinkedListNode(1);
            SimpleLinkedListNode second = new SimpleLinkedListNode(2);
            SimpleLinkedListNode third = new SimpleLinkedListNode(3);

            first.head._next = second;
            second._next = third;
        }

        void TraverseLinkedList()
        {
            SimpleLinkedListNode node = head;
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }
        }
    }
}
