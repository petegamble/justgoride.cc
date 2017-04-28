using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JustGoRide.cc.Services;
using JustGoRide.cc.Services.Interfaces;
using JustGoRide.cc.Web.Models.Http;
using Microsoft.AspNetCore.Mvc;


namespace JustGoRide.cc.Web.Controllers.Api
{
    public class ClubController : Controller
    {
        private IClubService _service; 

        public ClubController(IClubService service)
        {
            _service = service; 
        }

        [HttpGet("api/clubs")]
        public IActionResult Get()
        {
            var clubs = _service.GetClubs(); 
            return Ok(clubs);
        }

        [HttpGet("api/club/{id}")]
        public IActionResult Get(Guid id)
        {
            var club = _service.GetClub(id);
            if (club == null)
            {
				var errorState = new ErrorState{ HttpStatusCode = 400, Message = "Club Not Found", Description = $"There are no clubs with the following ID: {id}"};
                return BadRequest(errorState); 
            }
            return Ok(club);
        }
    }

}
