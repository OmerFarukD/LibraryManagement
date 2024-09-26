namespace LibraryManagement.ConsoleUI.Models;

public sealed class Category : Entity<int>
{
    public Category()
    {

    }

    public Category(int id, string name) : base(id)
    {
        Id = id;
        Name = name;
    }

    public string Name { get; set; }


    public override string ToString()
    {
        return $"Id : {Id}, Name: {Name}";
    }
}
