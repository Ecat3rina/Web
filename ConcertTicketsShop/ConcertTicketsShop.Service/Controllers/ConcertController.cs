﻿using System.Threading.Tasks;
using ConcertTicketsShop.Domain.Contract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ConcertTicketsShop.Service.Controllers
{
    [Authorize(Roles = "User")]
    [ApiController]
    [Route("api/concerts")]
    public class ConcertController : ControllerBase
    {
        private readonly IConcertService _concertService;
        public ConcertController(IConcertService concertService)
        {
            _concertService = concertService;
        }

        [HttpGet("trending")]
        public async Task<IActionResult> GetTrendingConcerts()
        {
            return Ok(await _concertService.GetTrendingConcerts());
        }
    }
}
