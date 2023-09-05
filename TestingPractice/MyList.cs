using System;
using System.Collections.Generic;
using System.Security;
using System.Xml.Linq;


namespace TestingPractice
{
    internal class MyList<T> : IMyList<T>
    {
        private int count;
        private T value;

        LinkedList<T> _list =  new LinkedList<T>();


        public T this[int index] { get => AtIndex(index); set => throw new NotImplementedException(); }


        public void Add(T element)
        {
            _list.AddLast(element);
            count++;
        }

        public void Clear()
        {
            count = 0;
        }

        public bool Contains(T element)
        {
            foreach (var item in _list)
            {
                if (item.Equals(element)) return true;
            } return false;

        }

        public int Count()
        {
            return count;
        }

        public int IndexOf(T element)
        {
            int count = 0;
            foreach (var item in _list)
            {
                if (item.Equals(element)) return count; 
                count++;
            }
            return -1;
        }

        public void Insert(int index, T element)
        {
        if (index<0 || index > _list.Count)
            {
                return;
            }

            LinkedListNode<T> newNode = new LinkedListNode<T>(element);

            if (index == 0)
            {
                _list.AddFirst(newNode);
                return;
            }

            if (index == _list.Count)
            {
                _list.AddLast(newNode); return;
            }

            LinkedListNode<T> current = _list.First;
            for(int i=0; i <= index -1; i++)
            {
                if (current == null) return;
                current = current.Next;

            }

            _list.AddAfter(current.Previous, newNode);

        }

        public void Remove(T element)
        {
            _list.Remove(element);
            /*int index = this.IndexOf(element);
            if (index >= 0)
            {
                this.RemoveAt(index);
            }*/
           


        }

        public void RemoveAt(int index)
        {
            RemoveAt(IndexOf(value));
        }

        public T AtIndex(int index)
        {
            int count = 0;
            foreach (var item in _list)
            {
                
                if (index.Equals(count)) return item;
                count++;
            }
            throw new NotImplementedException();
        }
    }
}