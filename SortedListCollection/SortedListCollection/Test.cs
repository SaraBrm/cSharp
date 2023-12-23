namespace SortedListCollection
{
    public class Test
    {
        public int GetValue(out string courseName)
        {
            courseName = "Math";
            return 15;
        }

        public KeyValuePair<string, int> GetValue2()
        {
            string courseName = "Math";
            int grade = 20;
            return new KeyValuePair<string, int>(courseName, grade);
        }
    }
}
