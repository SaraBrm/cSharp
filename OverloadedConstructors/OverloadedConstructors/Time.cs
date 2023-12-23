namespace OverloadedConstructors
{
    public class Time
    {
        private int hour;
        private int minute;
        private int second;

        public Time()
        {

        }
        public Time(int h) : this(h, 0, 0)
        {
        }

        public Time(int h, int m) : this(h, m, 0)
        {
        }

        public Time(int h, int m, int s)
        {
            SetTime(h, m, s);
        }

        public void SetTime(int h, int m, int s)
        {
            hour = h >= 0 && h < 24 ? h : 0;
            minute = m >= 0 && m < 60 ? m : 0;
            second = s >= 0 && s < 60 ? s : 0;
        }
        public void Display()
        {
            Console.WriteLine($"{hour}:{minute}:{second}");
        }
    }
}
