using LibraryManagement.ConsoleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.ConsoleUI.Repository;

public class MemberRepository : BaseRepository, IMemberRepository 
{
    public Member? Add(Member member)
    {
        throw new NotImplementedException();
    }

    public List<Member> GetAll()
    {
        throw new NotImplementedException();
    }

    public Member? GetById(string id)
    {
        throw new NotImplementedException();
    }

    public Member? Remove(string id)
    {
        throw new NotImplementedException();
    }

    public Member? Update(Member member)
    {
        throw new NotImplementedException();
    }
}
