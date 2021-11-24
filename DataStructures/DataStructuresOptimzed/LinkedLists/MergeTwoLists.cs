﻿using System;
namespace DataStructuresOptimzed.LinkedLists
{
    public class MergeTwoLists
    {
        public ListNode MergeTwoListss(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    result.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    result.next = l2;
                    l2 = l2.next;
                }
            }
            result.next = (l1 != null) ? l1 : l2;
            return result;
        }
    }
}
