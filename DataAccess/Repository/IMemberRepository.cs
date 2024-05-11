using BusinessObject.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        Member Login(string username, string password);

        IEnumerable<Member> GetMembers();
        Member GetMember(int id);
        void UpdateMember(Member member);
        void DeleteMember(int id);
        void InsertMember(Member member);
    }
}
