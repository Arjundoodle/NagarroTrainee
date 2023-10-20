using Angular_Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgreementController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly UserContext _context;

        public AgreementController(IConfiguration config, UserContext newcontext)
        {
            _config = config;
            _context = newcontext;
        }


        [HttpPost("AddAgreement")]

        public IActionResult Addagreement(Agreement agreement)
        {
           
            _context.Agreements.Add(agreement);
            _context.SaveChanges();
            return Ok("Success Agreement added");
        }
    }
}
