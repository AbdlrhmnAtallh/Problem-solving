using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    internal class Stack<T>
    {
        private List<T> Items;
        public Stack ()
        {
            Items = new List<T>();
        }
        
        public void push (T item)
        {
            Items.Add(item);
        }

        public T pop ()
        {
            if (Items.Count == 0)
            {
                throw new InvalidOperationException("Stack is Empty ");
            }
            T item = Items[Items.Count - 1];
            Items.RemoveAt(Items.Count - 1);
            return item;
        }

        public bool IsEmpty()
        {
            return Items.Count == 0;
        }

    }
}
