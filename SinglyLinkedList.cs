using System;
using System.Collections;

namespace HackerRank
{
    public class MyLinkedList
    {
        public MyNode Head { get; set; }
        public MyNode Tail { get; set; }
        public int Length { get; private set; }

        public MyLinkedList(int value)
        {
            Head = new MyNode(value);
            Tail = Head;
            Tail.Next = null;
            Length = 1;
        }

        public void AppendNode(int num)
        {
            MyNode newNode = new(num);

            if (Head == Tail)
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }

            Length++;
        }

        public void PrependNode(int num)
        {
            MyNode newNode = new(num);

            newNode.Next = Head;
            Head = newNode;
            Length++;
        }

        public void PrintList()
        {
            List<int> nodeList = new();
            MyNode currentNode = Head;

            while (currentNode != null)
            {
                nodeList.Add(currentNode.Value);
                currentNode = currentNode.Next;
            }

            foreach (int value in nodeList)
            {
                Console.WriteLine(value + " ");
            }
        }


        public void Insert(int idx, int value)
        {
            MyNode newNode = new(value);

            if (idx >= Length)
            {
                AppendNode(value);
            }

            MyNode preNode = TraverseToIdx(idx - 1);
            MyNode holdingPointer = preNode.Next;

            preNode.Next = newNode;
            newNode.Next = holdingPointer;

            Length++;
            PrintList();
        }

        public void Remove(int idx)
        {
            if (idx > Length)
            {
                throw new Exception("Index is greater than length of list.");
            }

            MyNode preNode = TraverseToIdx(idx - 1);
            if (preNode.Next.Next is null)
            {
                preNode.Next = null;
                Tail = preNode;
            }
            preNode.Next = preNode.Next.Next;
            Length--;
            PrintList();
        }

        public MyNode TraverseToIdx(int idx)
        {
            int runner = 0;
            MyNode currentNode = Head;

            while (runner != idx)
            {
                currentNode = currentNode.Next;
                runner++;
            }

            return currentNode;
        }

        public void ReverseList()
        {
            if (Length < 2)
            {
                Console.WriteLine("List contains only one element."); ;
            }

            MyNode first = Head;
            Tail = Head;
            MyNode second = first.Next;

            while (second != null)
            {
                MyNode temp = second.Next;

                second.Next = first;
                first = second;
                second = temp;
            }

            Head.Next = null;
            Head = first;

            PrintList();
        }
    }

    public class MyNode
    {
        public int Value { get; set; }
        public MyNode? Next { get; set; }

        public MyNode(int value)
        {
            Value = value;
            Next = null;
        }
    }
}

