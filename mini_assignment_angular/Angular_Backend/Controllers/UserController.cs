using Angular_Backend.Models;
using Microsoft.AspNetCore.Cors;
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
    [EnableCors("AllowOrigin")]
    public class UserController : ControllerBase
    {

        private readonly IConfiguration _config;
        private readonly UserContext _context;

        public UserController(IConfiguration config,UserContext context)
        {
            _config = config;
            _context = context;
        }

        [HttpPost("CreateUser")]

        public IActionResult Create(Model user)
        {
            if (_context.Users.Where(u=>u.Email==user.Email).FirstOrDefault()!=null)
            {
                return Ok("ALREADY EXISTS");
            }
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok("Success");
        }
    }
}


//https://localhost:44353
