namespace Paging
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int DepartmentId { get; set; }

        public Employee(int id, string name, string family, int departmentId)
        {
            Id = id;
            Name = name;
            Family = family;
            DepartmentId = departmentId;
        }
    }
}
