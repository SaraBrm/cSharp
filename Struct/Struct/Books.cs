namespace Struct
{
    public struct Books
    {
        public string Title { get; init; }
        public string Author { get; init; }

        //public Books(string title, string author)
        //{
        //    Title = title;
        //    Author = author;
        //}

        //public Books()
        //{
        //    Title = "VB";
        //    Author = "Ditals";
        //}

        //public abstract void Test()   //error
        //{
        //    // ...
        //}

        //~Books();

    }

    public interface IBook
    {
        void F();
    }
    public struct Books2 : IBook
    {
        public void F()
        {
            Console.WriteLine("");
        }
    }
}
