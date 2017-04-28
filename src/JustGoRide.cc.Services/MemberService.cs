using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustGoRide.cc.Interfaces;
using JustGoRide.cc.Models;

namespace JustGoRide.cc.Services
{
    public class MemberService
    {
        private IMemberProvider _memberProvider; 

        public MemberService(IMemberProvider memberProvider)
        {
            _memberProvider = memberProvider; 
        }

        public void AddMember()
        {
            _memberProvider.AddMember(new Member {Forename = "Dave"});
        }
    }
}
