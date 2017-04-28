using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using JustGoRide.cc.Models.Interfaces;

namespace JustGoRide.cc.Models
{
    public class Member : IModificationHistory
    {
        public Member()
        {
            Events = new List<Event>();
            Clubs = new List<Club>();
        }

        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string Source { get; set; }
        public string SourceUserId { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public Title Title { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNumber { get; set; }
        public List<Event> Events { get; set; }
        public List<Club> Clubs { get; set; }

        public DateTime DateModified { get; set; }
        public DateTime DateCreated { get; set; }
    }
}