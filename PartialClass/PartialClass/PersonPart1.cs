namespace PartialClass
{
    public partial class Person:Parent
    {
        public string Name { get; set; }
        public string Family { get; set; }

        public Person(string name, string family)
        {
            Name = name;
            Family = family;
        }
    }
}
