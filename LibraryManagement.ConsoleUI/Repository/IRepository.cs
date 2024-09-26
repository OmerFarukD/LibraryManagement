using LibraryManagement.ConsoleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.ConsoleUI.Repository;

public interface IRepository<TEntity,TId>
    where TEntity : Entity<TId>, new()
{
    List<TEntity> GetAll();
    TEntity Add(TEntity created);

    TEntity? GetById(TId id);
    TEntity? Remove(TId id);
}
