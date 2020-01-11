using System.Collections;
using System.Collections.Generic;

namespace PalindromeLinkedList
{
    public class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            var left = new Stack<int>();
            var right = new Queue<int>();

            var actual = head;
            var count = 0;
            
            while(actual != null)
            {
                right.Enqueue(actual.val);
                count++;

                if (count % 2 != 0)
                    left.Push(right.Dequeue());

                actual = actual.next;
            }

            if (count % 2 != 0)
                left.Pop();

            while (left.Count > 0)
                if (left.Pop() != right.Dequeue())
                    return false;

            return true;
        }
    }
}