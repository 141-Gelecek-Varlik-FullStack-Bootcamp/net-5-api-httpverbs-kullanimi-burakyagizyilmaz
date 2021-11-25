using Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GelecekVarlikYonetimi_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
       public static List<User> users = new List<User>
        {
            new User { Name = "Burak", SurName = "Yagizyilmaz", Id = 1, Mail = "yagizyilmazburak@gmail.com", Password = "123456" },
            new User { Name="Ayaz",SurName="Yagizyilmaz",Id=2,Mail="yagizyilmazayaz@gmail.com",Password="654321"}
        };

        [HttpGet()]
        public IActionResult GetUsers()
        {
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserByID(int id)
        {
            if (users.Any(x => x.Id == id))
            {
                User user = users.Single(x => x.Id == id);
                return Ok(user);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                users.Add(user);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            if (users.Any(x => x.Id == id))
            {
                User user = users.Single(x => x.Id == id);
                //DeleteUser()
                return Ok();
            }
            else
            {
                 return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromBody] User userFromClient, int id)
        {
            if (users.Any(x => x.Id == id) && ModelState.IsValid)
            {
                User user = users.Single(x => x.Id == id);
                user.Mail = userFromClient.Mail ?? user.Mail;
                user.SurName = userFromClient.SurName ?? user.SurName;
                user.Password = userFromClient.Password ?? user.Password;
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
