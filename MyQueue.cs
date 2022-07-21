using System;

namespace HackerRank
{
    public class MyQueue
    {
        public MyNode? First { get; set; }
        public MyNode? Last { get; set; }
        public int Length { get; private set; }

        public MyQueue()
        {
            First = null;
            Last = null;
            Length = 0;
        }

        public void Peek()
        {
            if (Length == 0)
            {
                Console.WriteLine("Queue is empty.");
            }

            else
            {
                Console.WriteLine(First.Value); ;
            }
        }

        public void Enqueue(dynamic val)
        {
            MyNode newNode = new(val);

            if (Length == 0)
            {
                First = newNode;
                Last = newNode;
            }

            else
            {
                Last.Next = newNode;
                Last = newNode;
            }

            Length++;
        }

        public MyNode Dequeue()
        {
            MyNode returnedNode = First;

            if (Length == 0)
            {
                throw new Exception("Queue is empty. Nothing to dequeue.QQ");
            }

            else if (Length == 1)
            {
                First = null;
                Length--;
                return returnedNode;
            }

            else
            {
                First = First.Next;
                Length--;
                return returnedNode;
            }
        }
    }
}
