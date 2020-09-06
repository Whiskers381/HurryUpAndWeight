﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetworkAPI;
using System.IO;
using Server;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class UserController : ControllerBase
    {
        private readonly UserContext _context;

        public UserController(UserContext context)
        {
            _context = context;
        }

        //GET: User
        [HttpGet]
        [ActionName("CheckConnection")]
        public IActionResult CheckConnection()
        {
            VolatileLogs.Add("CheckConnection");
            return StatusCode(200);
        }

        [HttpGet]
        [ActionName("Logger")]
        public IActionResult Logger()
        {
            return StatusCode(200, VolatileLogs.Get());
        }

        //Post: /User/LogIn
        [ActionName("LogIn")]
        [HttpPost]
        public IActionResult LogIn()
        {
            StreamReader bodyStream = new StreamReader(HttpContext.Request.Body);
            string body = bodyStream.ReadToEndAsync().Result;
            if (UserDatabaseAccess.LogIn(_context, NetworkAPI.User.DeSerializeJson(body)))
            {
                VolatileLogs.Add("LogIn: " + body);
                return StatusCode(200);
            }
            else
            {
                return StatusCode(401);
            }
        }

        [ActionName("Create")]
        [HttpPost]
        public IActionResult Create()
        {
            StreamReader bodyStream = new StreamReader(HttpContext.Request.Body);
            string body = bodyStream.ReadToEndAsync().Result;

            JsonMirrors.User.NameAndPassword nameAndPassword = NetworkAPI.User.DeSerializeJson(body);

            if(UserDatabaseAccess.CreateUser(_context, nameAndPassword.UserName, nameAndPassword.UserPassword))
            {
                VolatileLogs.Add("Create: " + body);
                return StatusCode(201);
            }
            else
            {
                return StatusCode(401);
            }
        }

        //[ActionName("LogIn2")]
        //[HttpGet]
        //public IActionResult LogIn2()
        //{
        //    return StatusCode(200);
        //}


        //    // GET: api/User
        //    [HttpGet]
        //    public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        //    {
        //        return await _context.Users.ToListAsync();
        //    }

        //    // GET: api/User/5
        //    [HttpGet("{id}")]
        //    public async Task<ActionResult<User>> GetUser(string id)
        //    {
        //        var user = await _context.Users.FindAsync(id);

        //        if (user == null)
        //        {
        //            return NotFound();
        //        }

        //        return user;
        //    }

        //    // PUT: api/User/5
        //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
        //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //    [HttpPut("{id}")]
        //    public async Task<IActionResult> PutUser(string id, User user)
        //    {
        //        if (id != user.Name)
        //        {
        //            return BadRequest();
        //        }

        //        _context.Entry(user).State = EntityState.Modified;

        //        try
        //        {
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!UserExists(id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }

        //        return NoContent();
        //    }

        //    // POST: api/User
        //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
        //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //    [HttpPost]
        //    public async Task<ActionResult<User>> PostUser(User user)
        //    {
        //        _context.Users.Add(user);
        //        try
        //        {
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateException)
        //        {
        //            if (UserExists(user.Name))
        //            {
        //                return Conflict();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }

        //        return CreatedAtAction("GetUser", new { id = user.Name }, user);
        //    }

        //    // DELETE: api/User/5
        //    [HttpDelete("{id}")]
        //    public async Task<ActionResult<User>> DeleteUser(string id)
        //    {
        //        var user = await _context.Users.FindAsync(id);
        //        if (user == null)
        //        {
        //            return NotFound();
        //        }

        //        _context.Users.Remove(user);
        //        await _context.SaveChangesAsync();

        //        return user;
        //    }

        //    private bool UserExists(string id)
        //    {
        //        return _context.Users.Any(e => e.Name == id);
        //    }
    }
    }
