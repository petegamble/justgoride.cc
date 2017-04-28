using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using JustGoRide.cc.Interfaces;
using JustGoRide.cc.Models;

namespace JustGoRide.cc.Services
{
    public class EventService : IEventService
    {
        private IEventProvider _eventProvider; 
        public EventService(IEventProvider eventProvider)
        {
            _eventProvider = eventProvider; 
        }

        public List<Event> GetMemberEventParticipation(Guid memberId)
        {

            return _eventProvider.GetMemberEventPaticipation(memberId).ToList();

            //var e = new Event()
            //{
            //    Name = "Turkey Burner",
            //    DateCreated = DateTime.Now,
            //    StartDate = DateTime.ParseExact("26/12/2016 08:00", "dd/MM/yyyy HH:mm", CultureInfo.CurrentCulture),
            //    IsDropRide = false,
            //    Description = "Time to burn some turkey"
            //};

            //return new List<Event>() { e }; 
        }

    }
}
