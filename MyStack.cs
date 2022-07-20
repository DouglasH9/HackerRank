using System;
using HackerRank;

namespace HackerRank
{
    public class MyStack
    {
        public MyNode? Top { get; set; }
        public MyNode? Bottom { get; set; }
        public int Length { get; private set; }

        public MyStack()
        {
            Top = null;
            Bottom = null;
            Length = 0;
        }

        public void Peek()
        {
            if (Length == 0)
            {
                Console.WriteLine("Stack is empty.");
            }

            else
            {
                Console.WriteLine(Top.Value);
            }
        }

        public void Push(dynamic val)
        {
            MyNode newNode = new(val);

            if (Length == 0)
            {
                Top = newNode;
                Bottom = newNode;
                Length++;
            }

            else
            {
                newNode.Next = Top;
                Top = newNode;
                Length++;
            }
        }

        public MyNode Pop()
        {
            MyNode returnNode = Top;
            MyNode newTop = Top.Next;


            if (Length == 0)
            {
                throw new Exception("Stack is empty, nothing to pop.");
            }

            else if (Length == 1)
            {
                Top = null;
                Bottom = null;
                Length--;
                return returnNode;
            }

            else
            {
                Top = newTop;
                Length--;
                return returnNode;
            }
        }
    }

}