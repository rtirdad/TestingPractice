namespace TestingPractice
{
    internal class MyList<T> : IMyList<T>
    {
        private int count;
        private T value;
        private T Content;


        public T this[int index] { get => value; set => throw new NotImplementedException(); }

        public void Add(T element)
        {
            count++;
            value = element;
        }

        public void Clear()
        {
            count = 0;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (value[i] == element)
                {
                    return true;
                }
            }
            return false;

        }

        public int Count()
        {
            return count;
        }

        public int IndexOf(T element)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T element)
        {
            throw new NotImplementedException();
        }

        public void Remove(T element)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}