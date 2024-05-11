using BusinessObject.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepositoy : IMemberRepository
    {
        public void DeleteMember(int id) => MemberDAO.Instance.Delete(id);

        public Member GetMember(int id) => MemberDAO.Instance.Get(id);

        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetAll();

        public void InsertMember(Member member) => MemberDAO.Instance.AddNew(member);

        public Member Login(string username, string password) => MemberDAO.Instance.Login(username, password);

        public void UpdateMember(Member member)
        {
            throw new NotImplementedException();
        }
    }
}
