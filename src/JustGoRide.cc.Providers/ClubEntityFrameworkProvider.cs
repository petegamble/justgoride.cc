using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustGoRide.cc.Interfaces;
using JustGoRide.cc.Models;

namespace JustGoRide.cc.Providers
{
    public class ClubEntityFrameworkProvider : IClubProvider
    {
        private ClubContext _context;

        public ClubEntityFrameworkProvider(ClubContext context)
        {
            _context = context; 
        }

        public List<Club> GetClubs()
        {
            using (_context)
            {
                var clubs = _context.Clubs.AsEnumerable();

                return clubs.ToList();
            }
        }

        public Club GetClub(Guid id)
        {
            using (_context)
            {
                var club = _context.Clubs.FirstOrDefault(c => c.Id == id);

                return club;
            }
        }
    }
}
