using dotnet5_webapps.Data;
using dotnet5_webapps.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet5_webapps.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            //var users = _context.Users.ToList();
            _context = context;
        }

        // GET api/Users
        //[HttpGet]
        //public IList<IEnumerator<AppUser>> GetUsers()
        //{
        //    var users = _context.Users.ToList();
        //    return users;
        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users =  await _context.Users.ToListAsync();
            return users;
        }

        [HttpGet("{id}", Name = "GetUser")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return user;
        }

    }


}
