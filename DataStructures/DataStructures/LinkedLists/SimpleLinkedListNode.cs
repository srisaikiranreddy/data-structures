using System;
namespace DataStructures.LinkedLists
{
    public class SimpleLinkedListNode
    {
        SimpleLinkedListNode head;
        public int _data;
        public SimpleLinkedListNode _next;
        public SimpleLinkedListNode(int data)
        {
            _data = data;
            _next = null;
        }
    }
}
