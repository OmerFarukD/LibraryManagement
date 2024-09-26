
using System.Runtime.Intrinsics.Arm;

namespace LibraryManagement.ConsoleUI.Models;

public abstract class Entity<TId>
{
    public TId Id { get; set; }

    protected Entity()
    {
      
    }

    protected Entity(TId id) :this()
    {
        Id = id;
    }
}
