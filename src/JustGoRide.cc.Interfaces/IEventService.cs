using System;
using System.Collections.Generic;
using JustGoRide.cc.Models;

namespace JustGoRide.cc.Interfaces
{
    public interface IEventService
    {
        List<Event> GetMemberEventParticipation(Guid memberId); 
    }
}
