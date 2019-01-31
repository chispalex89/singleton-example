using System;
using System.Collections.Generic;
using System.Text;

namespace LinealStructures
{
    public class LinkedList<T> : ILinearDataStructure<T>
    {
        static Node<T> Start { get; set; }
        static int Length { get; set; }

        public void Add(T value)
        {
            if (Length == 0)
            {
                Start = new Node<T>(value);
                Length = 1;
            }
            var node = new Node<T>(value);
            var current = Start;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = node;
            Length++;
        }

        public bool Find(T value)
        {
            throw new NotImplementedException();
        }
    }
}
