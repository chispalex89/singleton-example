using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinealStructures
{
    public class LinkedList<T> : ILinearDataStructure<T>, IEnumerable<T> where T : IComparable
    {
        static Node<T> First { get; set; }
        static int Length { get; set; }

        public void Add(T value)
        {
            if (Length == 0)
            {
                First = new Node<T>(value);
                Length = 1;
                return;
            }
            var node = new Node<T>(value);
            var current = First;
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

        public IEnumerator<T> GetEnumerator()
        {
            var node = First;
            while (node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
