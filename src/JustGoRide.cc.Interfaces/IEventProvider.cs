using System;
using System.Collections.Generic;
using JustGoRide.cc.Models;

namespace JustGoRide.cc.Interfaces
{
    public interface IEventProvider
    {
        IEnumerable<Event> GetMemberEventPaticipation(Guid memberId);

        IEnumerable<Event> GetCurrentClubEvents(Guid clubId);
    }
}