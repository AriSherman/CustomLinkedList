using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class CustomLinkedList<T>
    {
        internal Node<T> First;
        internal Node<T> Last;
        private Node<T> Current;

        public CustomLinkedList()
        {
        }

        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);

            newNode.Value = value;
            if (First == null)
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                newNode.Previous = Last;
                Last.Next = newNode;
                Last = newNode;

            }
        }


        public IEnumerator GetEnumerator()
        {
            Current = First;
            while (Current != null)
            {
                var val = Current.Value;
                Current = Current.Next;
                yield return val;
            }
        }


        public IEnumerable GetEnumerableDESC()
        {
            Current = Last;
            while (Current != null)
            {
                var val = Current.Value;
                Current = Current.Previous;
                yield return val;
            }
        }
    }
}
