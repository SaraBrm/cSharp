using System;

namespace ImplicitAndExplicitCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValueHolder holder1=new ValueHolder(123);
            int number=holder1;

            ValueHolder holder2 = 145;

            string str=(string) holder2;
        }
    }

    public class ValueHolder
    {
        public ValueHolder(int value)
        {
            Value=value;
        }
        public int Value { get; set; }

        public static implicit operator int(ValueHolder holder)
        {
            return holder.Value;
        }

        public static implicit operator ValueHolder(int value)
        {
            return new ValueHolder(value);
        }

        public static explicit operator string(ValueHolder holder)
        {
            return holder.Value.ToString();
        }
    }
}
