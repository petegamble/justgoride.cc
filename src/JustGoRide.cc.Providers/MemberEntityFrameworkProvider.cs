using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustGoRide.cc.Interfaces;
using JustGoRide.cc.Models;

namespace JustGoRide.cc.Providers
{
    public class MemberEntityFrameworkProvider : IMemberProvider
    {
        private ClubContext _context;

        public MemberEntityFrameworkProvider(ClubContext context)
        {
            _context = context; 
        }

        public MemberEntityFrameworkProvider()
        {
            //TODO; Move this to the application start up 
            Database.SetInitializer(new NullDatabaseInitializer<ClubContext>());
        }

        public void AddMember(Member member)
        {
            using (_context)
            {
                _context.Database.Log = Console.WriteLine;
                _context.Membership.Add(member);
                _context.SaveChanges();
            }
        }

        public Member GetMember(Guid memberId)
        {
            using (_context)
            {
                var member = _context.Membership.FirstOrDefault(m => m.Id == memberId);

                return member; 
            }
        }

        public List<Member> GetClubMembership(Guid clubId)
        {
            using (_context)
            {
                var members = _context.Membership.Where(m => m.Gender == Gender.Male)
                    .Skip(1).Take(1);

                return _context.Clubs.FirstOrDefault(c => c.Id == clubId).Membership;

                //return members.ToList();
            }
        }
    }
}
