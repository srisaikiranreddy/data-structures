using System;
using System.Collections;
using System.Collections.Generic;
namespace DataStructures.Stacks
{
    public class SimpleStack
    {
        public SimpleStack()
        {
            Stack obj = new Stack();

        }

        static void StackPush(Object n, Stack stackObj)
        {
            stackObj.Push(n);
        }
    }
}
