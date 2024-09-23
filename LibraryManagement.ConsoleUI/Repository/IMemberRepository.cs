using LibraryManagement.ConsoleUI.Models;

namespace LibraryManagement.ConsoleUI.Repository;

public interface IMemberRepository
{
    List<Member> GetAll();
    Member? GetById(int id);
    Member? Add(Member member);
    Member? Update(Member member);
    Member? Remove(int id);
}
