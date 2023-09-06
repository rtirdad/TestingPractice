using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using System.Xml.Linq;


namespace TestingPractice
{
    internal class MyList<T> : IMyList<T>
    {
        private int count;
        LinkedList<T> _list =  new LinkedList<T>();

        //public T this[int index] { get => AtIndex(index); set =>  ; }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _list.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                LinkedListNode<T> current = _list.First;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                    i++;
                }
                return current.Value;
            }
            set
            {
                if (index < 0 || index >= _list.Count)
                {
                    throw new IndexOutOfRangeException();
                }

                LinkedListNode<T> current = _list.First;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                current.Value = value;
            }
        }

public void Add(T element)
        {
            _list.AddLast(element);

        }

        public void Clear()
        {
            _list.Clear();
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
            return _list.Count;
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

        public void Insert(int index, T element){

            if (index < 0 || index > _list.Count)
            {
                return; 
            }
            LinkedListNode<T> newNode = new LinkedListNode<T>(element);

            if (index == 0)
            {
                _list.AddFirst(newNode);
            }
            else if (index == _list.Count)
            {
                _list.AddLast(newNode);
            }
            else
            {
                LinkedListNode<T> current = _list.First;
                for (int i = 0; i < index; i++)
                {
                    if (current == null) return;
                    current = current.Next;
                }

                _list.AddAfter(current.Previous, newNode);
            }
        }

            public void Remove(T element)
        {
            RemoveAt(IndexOf(element));
        }
        public void RemoveAt(int index)
        {
            LinkedListNode<T> current = _list.First;
            for (int i = 0; i <= index && current != null; i++)
            {
                if (i != index)
                {
                    current = current.Next;
                    continue;
                }
                _list.Remove(current);
                count--; 
            }
        }
        public T AtIndex(int index)
        {
            int count = 0;
            foreach (var item in _list)
            {
                if (index.Equals(count)) return item;
                count++;
            }
            throw new IndexOutOfRangeException();
        }
      
    }
}