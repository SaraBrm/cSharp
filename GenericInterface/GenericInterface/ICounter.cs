namespace GenericInterface
{
    public interface ISample
    {

    }
    public interface ICounter<T> : ISample
    {
        int Count { get; }
        T Get(int index);
    }

    public interface ICollections<T> : ICounter<T>
    {
        void Add(T item);
    }

    public class Collection<T> : ICollections<T>
    {
        private int counter;
        private T[] Store;

        public Collection()
        {
            counter = 0;
            Store = new T[10];
        }

        public int Count { get { return counter; } }

        public void Add(T item)
        {
            //Store[counter++] = item;
            Store[counter] = item;
            counter++;
        }

        public T Get(int index)
        {
            return Store[index];
        }
    }


    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public Author(int id, string name, string family)
        {
            Id = id;
            Name = name;
            Family = family;
        }
    }



}