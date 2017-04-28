using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustGoRide.cc.Models;

namespace JustGoRide.cc.Interfaces
{
    public interface IClubProvider
    {
        List<Club> GetClubs();

        Club GetClub(Guid id); 
    }
}
