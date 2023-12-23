using System.Collections;

namespace Collections
{
    public class Names : IEnumerable
    {
        string[] names = { "joe", "jack", "william", "abraham" };

        public IEnumerator GetEnumerator()
        {
            return new NamesEnumerator(names);
        }
    }

    public class NamesEnumerator : IEnumerator
    {
        string[] collection;
        int position = -1;
        public NamesEnumerator(string[] collection)
        {
            this.collection = collection;
        }

        public object Current => collection[position];

        //public object Current { get 
        //    { 
        //        return collection[position];
        //    }
        //}

        public bool MoveNext()
        {
            if (position < collection.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
