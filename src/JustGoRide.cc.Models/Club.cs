using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using JustGoRide.cc.Models.Interfaces;

namespace JustGoRide.cc.Models
{
    public class Club : IModificationHistory
    {
        public Club()
        {
            Membership = new List<Member>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public List<Member> Membership { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
    }
}