using System;
using System.Collections.Generic;
using JustGoRide.cc.Models;

namespace JustGoRide.cc.Services.Interfaces
{
    public interface IClubService
    {
        List<Club> GetClubs();
        Club GetClub(Guid id);
    }
}
