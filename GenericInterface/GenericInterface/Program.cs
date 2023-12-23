//Generic Interface
using GenericInterface;

Collection<Author> Authors = new Collection<Author>();

Author a1 = new Author(1001, "sara", "brm");
Author a2 = new Author(1002, "bahar", "sabet");
Author a3 = new Author(1003, "sevda", "arash");

Authors.Add(a1);
Authors.Add(a2);
Authors.Add(a3);

for (int i = 0; i < Authors.Count; i++)
{
    Author author = Authors.Get(i);
    Console.WriteLine($" Id : {author.Id}");
    Console.WriteLine($" Name : {author.Name}");
    Console.WriteLine($" Family : {author.Family} \n\n");
}

Collection<int> Set = new Collection<int>();
Set.Add(1);
Set.Add(2);
Set.Add(3);

for (int i = 0; i < Set.Count; i++)
{
    Console.WriteLine($" value : {Set.Get(i)}");
}


Console.ReadKey();

