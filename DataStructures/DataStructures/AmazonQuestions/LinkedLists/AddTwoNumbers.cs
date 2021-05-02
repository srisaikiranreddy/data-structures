using System;
namespace DataStructures.AmazonQuestions.LinkedLists
{
    public class ListNode
    {
     public int val;
     public ListNode next;
     public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class AddTwoNumbers
    {
        public AddTwoNumbers()
        {
            //AddTwoNumbers1(new ListNode);
        }

        public ListNode AddTwoNumbers1(ListNode l1, ListNode l2)
        {

            ListNode result = new ListNode();
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                int sum = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
                carry = sum / 10;
                result.next = new ListNode(sum % 10);
                result = result.next;
                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }

            if (carry > 0) result.next = new ListNode(carry);

            return result.next;
        }
    }
}
