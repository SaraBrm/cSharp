namespace Polymorphism
{
    public class Shape
    {// ...

        public virtual void Draw()
        {
            Console.WriteLine("Drawing ...");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
}
