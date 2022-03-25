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
        private int count = 0;

        public CustomLinkedList()
        {
            count++;
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
        //Node<T> newNode = new Node<T>();
        //newNode.Value = value;
        //this.First = newNode;
        //this.Current = newNode;

        //Node<T> newNode1 = new Node<T>();
        //newNode1.Value = value;
        //newNode1.Previous = this.Last;
        //Last.Next = newNode1;
        //this.Last = newNode1;


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
