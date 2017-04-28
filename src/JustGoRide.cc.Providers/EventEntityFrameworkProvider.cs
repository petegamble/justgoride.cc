using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using JustGoRide.cc.Interfaces;
using JustGoRide.cc.Models;
using Microsoft.Win32;

namespace JustGoRide.cc.Providers
{
    public class EventEntityFrameworkProvider : IEventProvider
    {
        private ClubContext _context;

        public EventEntityFrameworkProvider(ClubContext context)
        {
            _context = context; 
        }

        public IEnumerable<Event> GetMemberEventPaticipation(Guid memberId)
        {
            using (_context)
            {
                _context.Database.Log = Console.WriteLine;

                var events = _context.Events.AsNoTracking().Where(e => e.OwnerId == memberId);
                return events;
            }
        }

        public IEnumerable<Event> GetCurrentClubEvents(Guid clubId)
        {
            throw new NotImplementedException();
        }
    }
}

//context.Database.Log = Console.WriteLine;
//              //eagar loading 
//              var user = context.Membership.AsNoTracking().Include(m => m.Events).FirstOrDefault(m => m.Id == memberId);

//              //OR explicit loading
//              user = context.Membership.AsNoTracking().FirstOrDefault(m => m.Id == memberId);
                //context.Entry(user).Collection(m=>m.Events).Load();

//              //OR Lazy loading by making the navigation property virtual -WARNING 

//              //OR projection queries
//              var auser = context.Membership.AsNoTracking().Select(n => new { n.Id, n.UserName, n.Events })
//              .FirstOrDefault(m => m.Id == memberId);

//              return user.Events;