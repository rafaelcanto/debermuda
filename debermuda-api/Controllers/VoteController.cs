using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeBermudaApi.Data;
using DeBermudaApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DeBermudaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VoteController : ControllerBase
    {

        private readonly ILogger<VoteController> _logger;

        private readonly VoteContext _context;

        public VoteController(ILogger<VoteController> logger)
        {
            _logger = logger;
            _context = new VoteContext();

        }

        [HttpGet]
        public List<Vote> Get()
        {
            return _context.Votes.ToList();
        }


        [HttpPost]
        public async void Post([FromBody] CreateVote createVote)
        {
            var vote = new Vote() { VoteValue = createVote.Value, CreatedAt = DateTime.Now };

            _context.Votes.Add(vote);
            await _context.SaveChangesAsync();
        }
    }
}
