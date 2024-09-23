
using System.Runtime.Intrinsics.Arm;

namespace LibraryManagement.ConsoleUI.Models;

public abstract class Entity
{
    public int Id { get; set; }

    protected Entity()
    {
      
    }

    protected Entity(int id) :this()
    {
        Id = id;
    }
}
