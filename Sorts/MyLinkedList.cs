using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class MyLinkedList<T> where T : class
    {
        private class MyLinkedListNode
        {
            public MyLinkedListNode NextNode { get; set; }
            public MyLinkedListNode PreviousNode { get; set; }
            public T Item { get; set; }
        }

        private MyLinkedListNode Current { get; set; }

        public void Add(T item)
        {
            if (Current.Item != null)
            {
                MyLinkedListNode newNode = new MyLinkedListNode();
                newNode.Item = item;
                Current.NextNode = newNode;
                Current = newNode;

            }
            else
            {
                Current.Item = item;
            }
              

        }

        public MyLinkedList()
        {
            Current = new MyLinkedListNode();
        }
    }
}
