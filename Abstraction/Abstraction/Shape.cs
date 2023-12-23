namespace Abstraction
{
    public abstract class Shape
    {
        public int Side { get; set; }
        public abstract int CalculateArea();

        public void DisplayMessage()
        {
            Console.WriteLine("We are learning abstract class!");
        }
    }

    public class Square : Shape
    {
        public Square(int side)
        {
            Side = side;
        }
        public override int CalculateArea()
        {
            return Side * Side;
        }
    }
}
