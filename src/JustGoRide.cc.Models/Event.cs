using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Management.Instrumentation;
using JustGoRide.cc.Models.Interfaces;

namespace JustGoRide.cc.Models
{
    public class Event : IModificationHistory
    {
        public Event()
        {
            Participants = new List<Member>();
        }

        public Guid Id { get; set; }
        [Required]
        public Member Owner { get; set; }
        public Guid OwnerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ImageUrl { get; set; }
        public EventStatus Status { get; set; }
        public bool IsDropRide { get; set; }
        public bool GuardsRequired { get; set; }
        public Route Route { get; set; }
        public List<Member> Participants { get; set; }

        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
    }
}