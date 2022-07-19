using System;
namespace HackerRank
{
    public class MyDoublyLinkedList
    {
        public DoubleNode Head { get; set; }
        public DoubleNode Tail { get; set; }
        public int Length { get; private set; }

        public MyDoublyLinkedList(int val)
        {
            DoubleNode newNode = new(val);
            Head = newNode;
            Tail = newNode;
            Length = 1;
        }

        public void AppendNode(int val)
        {
            DoubleNode newNode = new(val);

            Tail.Next = newNode;
            newNode.Prev = Tail;
            Tail = newNode;
            Length++;
        }

        public void PrintDoubleLinkedList()
        {
            List<int> nodeValList = new();
            DoubleNode currentNode = Head;

            while (currentNode is not null)
            {
                nodeValList.Add(currentNode.Value);
                currentNode = currentNode.Next;
            }

            foreach (int val in nodeValList)
            {
                Console.WriteLine(val);
            }
        }

        public void InsertDoubleNode(int idx, int val)
        {
            if (idx > Length)
            {
                throw new Exception("Idx cannot be greater than length of list.");
            }

            DoubleNode newNode = new(val);
            DoubleNode preNode = TraverseToDoubleNode(idx - 1);

            newNode.Prev = preNode;
            newNode.Next = preNode.Next;
            preNode.Next.Prev = newNode;
            preNode.Next = newNode;
            Length++;

        }

        public void RemoveDoubleNode(int idx)
        {
            if (idx > Length)
            {
                throw new Exception("Idx cannot be greater than length of list.");
            }

            DoubleNode preNode = TraverseToDoubleNode(idx - 1);
            if (preNode.Next.Next is null)
            {
                preNode.Next = null;
                Tail = preNode;
            }
            preNode.Next.Next.Prev = preNode;
            preNode.Next = preNode.Next.Next;
            Length--;
        }

        public DoubleNode TraverseToDoubleNode(int idx)
        {
            int runner = 0;
            DoubleNode currentNode = Head;

            while (runner != idx)
            {
                currentNode = currentNode.Next;
                runner++;
            }

            return currentNode;
        }
    }



    public class DoubleNode
    {
        public DoubleNode? Prev { get; set; }
        public DoubleNode? Next { get; set; }
        public int Value { get; set; }

        public DoubleNode(int value)
        {
            Value = value;
            Prev = null;
            Next = null;
        }
    }
}
