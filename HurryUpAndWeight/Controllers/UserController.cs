using System;
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
    }
}
