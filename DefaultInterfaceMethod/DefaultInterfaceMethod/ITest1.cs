namespace DefaultInterfaceMethod
{
    public interface ITest1
    {
        abstract void F1();
        public void F2()
        {
            Console.WriteLine("Im ITest1");
        }
    }

    public class Test1 : ITest1
    {
        public void F1()
        {
            Console.WriteLine("Im Test1");
        }
    }

    public class Test2 : ITest1
    {
        public void F1()
        {
            Console.WriteLine("Im Test2");
        }
    }
}
