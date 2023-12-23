using Paging;
List<Employee> Employees = new List<Employee>()
{
    new Employee(1, "Sara", "abbasi", 101),
    new Employee(2, "Sahand", "Roshani", 201),
    new Employee(3, "Ali", "fathi", 100),
    new Employee(4, "Amir", "saeedi", 100),
    new Employee(5, "Roz", "tahmasbi",  101),
    new Employee(6, "Diba", "Alizade", 301),
    new Employee(7, "Negar", "Habibi", 301),
    new Employee(8, "Mohammad", "Njati", 201),
    new Employee(9, "Matin", "Vahidi", 101),
};

// Collection.Skip((PN – 1) * NRP).Take(NRP)

int pageSize = 2;
int pageNumber = 0;
var totalPages = Math.Ceiling((double)Employees.Count() / pageSize);

do
{
    Console.Write($" Please enter page number 1 to {totalPages}: ");
    if (int.TryParse(Console.ReadLine(), out pageNumber))
    {
        if (pageNumber > 0 && pageNumber <= totalPages)
        {
            var result = Employees.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            Console.WriteLine(" {0,-10}{1,-10}{2,-10}{3,-10}", "Id", "Name", "Family", "DepartmentId");
            foreach (var item in result)
            {
                Console.WriteLine(" {0,-10}{1,-10}{2,-10}{3,-10}", item.Id, item.Name, item.Family, item.DepartmentId);
            }
            Console.WriteLine($" Page: {pageNumber}");
        }
        else
        {
            Console.Write($" Please enter page number 1 to {totalPages}: ");
        }
    }
    else
    {
        Console.Write($" Please enter valid page number 1 to {totalPages}: ");
    }
} while (true);

Console.ReadKey();

