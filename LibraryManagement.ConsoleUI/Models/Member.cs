

namespace LibraryManagement.ConsoleUI.Models;

public class Member : Entity<string>
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public int Age { get; set; }
}
