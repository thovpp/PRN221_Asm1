using BusinessObject.Object;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Member> GetAll()
        {
            using var context = new Assigment01Prn221Context();
            List<Member> list = context.Members.ToList();
            return list;
        }

        public Member Get(int id)
        {
            using var context = new Assigment01Prn221Context();
            Member member = context.Members.FirstOrDefault(member => member.MemberId == id);
            return member;
        }
        public void AddNew(Member member)
        {
            using var context = new Assigment01Prn221Context();
            context.Members.Add(member);
            context.SaveChanges();
        }
        public void Update(Member member)
        {
            using var context = new Assigment01Prn221Context();
            context.Members.Update(member);
            context.SaveChanges();
        }
        public void Delete(int memberId)
        {
            Member member = Get(memberId);
            using var context = new Assigment01Prn221Context();
            context.Members.Remove(member);
            context.SaveChanges();
        }
        public Member Login(string email, string password)
        {
            Member? member = null;
            try
            {
                IEnumerable<Member> members = GetAll().Append(GetDefaultMember());
                member = members.SingleOrDefault(mb => mb.Email.Equals(email) && mb.Password.Equals(password));
                if (member == null)
                {
                    throw new Exception("Login failed! Please check your email and password!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return member;
        }

        public Member GetDefaultMember()
        {
            Member Default = null;
            using (StreamReader r = new StreamReader("appsettings.json"))
            {
                string json = r.ReadToEnd();
                IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", true, true)
                                        .Build();
                string email = config["Admin:email"];
                string password = config["Admin:password"];
                Default = new Member
                {
                    MemberId = 0,
                    Email = email,
                    CompanyName = "",
                    City = "",
                    Country = "",
                    Password = password,
                };
            }
            return Default;
        }
    }
}
