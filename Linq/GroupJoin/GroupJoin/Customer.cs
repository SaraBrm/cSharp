public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public string Mobile { get; set; }

    public Customer(int id, string name, string family, string mobile)
    {
        Id = id;
        Name = name;
        Family = family;
        Mobile = mobile;
    }
}