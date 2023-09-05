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
            count++;


            /*int count = 0;
            foreach (var item in _list)
            {
                if (item.Equals(element))
                _list.Remove(item);
                count++;
            }  Console.WriteLine(count);*/


            //LinkedListNode<T> newNode = new LinkedListNode<T>(element);



            /*LinkedListNode<T> currentNode = _list.First;
            while (currentNode != null)
            {
                if (currentNode.Equals(element))
                {
                    _list.Remove(currentNode);
                    return;
                }
                currentNode = currentNode.Previous;
            }*/

        }

        public void RemoveAt(int index)
        {
            int count = 0;
            foreach (var item in _list)
            {
                if (item.Equals(index))
                    _list.Remove(item);
                count++;
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
            throw new NotImplementedException();
        }
    }
}