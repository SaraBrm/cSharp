using System;

namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValueHolder holder1 = new ValueHolder(13);
            ValueHolder holder2 = new ValueHolder(17);

            var result = holder1 + holder2;
            Console.WriteLine(result);

            var result2 = holder1 - holder2;
            Console.WriteLine(result2);

            var result3 = holder1 * holder2;
            Console.WriteLine(result3);

            var result4 = holder1 / holder2;
            Console.WriteLine(result4);

            if (holder1 == holder2)
                Console.WriteLine("holder1 equals holder2");
            else Console.WriteLine("holder1 is not equals holder2");

            if (holder1 > holder2)
                Console.WriteLine("holder1 greater than holder2");
            else Console.WriteLine("holder1 is not greater than holder2");

            if (holder1 >= holder2)
                Console.WriteLine("holder1 greater than or equals holder2");
            else Console.WriteLine("holder1 is not greater than or equals holder2");
        }
    }


    public class ValueHolder
    {
        public ValueHolder(int value) {
            Value = value;
        }
        public int Value { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }

        public static ValueHolder operator +(ValueHolder leftOp, ValueHolder rightOp) 
        {
            return new ValueHolder(leftOp.Value + rightOp.Value);
        }

        public static ValueHolder operator -(ValueHolder leftOp, ValueHolder rightOp)
        {
            return new ValueHolder(leftOp.Value - rightOp.Value);
        }

        public static ValueHolder operator *(ValueHolder leftOp, ValueHolder rightOp)
        {
            return new ValueHolder(leftOp.Value * rightOp.Value);
        }
        public static ValueHolder operator /(ValueHolder leftOp, ValueHolder rightOp)
        {
            return new ValueHolder(leftOp.Value / rightOp.Value);
        }

        public static bool operator ==(ValueHolder leftOp, ValueHolder rightOp)
        {
            return leftOp.Value == rightOp.Value;
        }

        public static bool operator !=(ValueHolder leftOp, ValueHolder rightOp)
        {
            return leftOp.Value != rightOp.Value;
        }

        public static bool operator >(ValueHolder leftOp, ValueHolder rightOp)
        {
            return leftOp.Value > rightOp.Value;
        }

        public static bool operator <(ValueHolder leftOp, ValueHolder rightOp)
        {
            return leftOp.Value < rightOp.Value;
        }

        public static bool operator >=(ValueHolder leftOp, ValueHolder rightOp)
        {
            return leftOp.Value >= rightOp.Value;
        }

        public static bool operator <=(ValueHolder leftOp, ValueHolder rightOp)
        {
            return leftOp.Value <= rightOp.Value;
        }
    }

}
