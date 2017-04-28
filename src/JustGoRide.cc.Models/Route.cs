using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using JustGoRide.cc.Models.Interfaces;


namespace JustGoRide.cc.Models
{
    public class Route : IModificationHistory
    {
        public Route()
        {
            Events = new List<Event>();
        }

        public Guid Id { get; set; }
        [Required]
        public Member Owner { get; set; }
        public Guid OwnerId { get; set; }
        public string Name { get; set; }
        public double DistanceKm { get; set; }
        public double ClimbM { get; set; }
        public string ImageUrl { get; set; }
        public bool Private { get; set; }
        public List<Event> Events { get; set; }

        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
