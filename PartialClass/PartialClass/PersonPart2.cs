namespace PartialClass
{
    public partial class Person:IPerson
    {
        public void Introduce()
        {
            Console.WriteLine($"my name is {Name} and family is {Family}");
        }

        public void Speak()
        {
            Console.WriteLine("Salam");
        }
    }
}
