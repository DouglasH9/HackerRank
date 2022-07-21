using System;
using HackerRank;

namespace HackerRank
{
    public class MyNode
    {
        public dynamic Value { get; set; }
        public MyNode? Next { get; set; }

        public MyNode(dynamic value)
        {
            Value = value;
            Next = null;
        }
    }
}