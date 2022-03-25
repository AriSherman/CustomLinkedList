using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    internal class Node<T>
    {
    public Node<T> Previous;
    public T Value;
    public Node<T> Next;

        public Node(T value)
        {
            Value = value;
        }
    };
}
