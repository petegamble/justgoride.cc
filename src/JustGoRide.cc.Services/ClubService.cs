using System;
using System.Collections.Generic;
using JustGoRide.cc.Interfaces;
using JustGoRide.cc.Models;
using JustGoRide.cc.Services.Interfaces;

namespace JustGoRide.cc.Services
{
    public class ClubService : IClubService
    {
        private IClubProvider _provider;

        public ClubService(IClubProvider provider)
        {
            _provider = provider; 
        }

        public List<Club> GetClubs()
        {
            return _provider.GetClubs(); 
        }

        public Club GetClub(Guid id)
        {
            return _provider.GetClub(id); 
        }
    }
}
