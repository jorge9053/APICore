using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICore.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        // GET api/users
        [HttpGet]
        public IEnumerable<User> Get()
        {
            using (var context = MemoryContext.Instance)
            {
                return context.Users.ToList();
            }
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            using (var context = MemoryContext.Instance)
            {
                return context.Users.Find(id);
            }
        }

        // POST api/users
        [HttpPost]
        public User Create([FromBody]User user)
        {
            using (var context = MemoryContext.Instance)
            {
                context.Users.Add(user);
                context.SaveChanges();
                return user;
            }
        }

        // PUT api/users/5
        [HttpPut()]
        public User Update([FromBody]User user)
        {
            using (var context = MemoryContext.Instance)
            {
                context.Users.Update(user);
                context.SaveChanges();
                return user;
            }
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public void Remove(int id)
        {
            using (var context = MemoryContext.Instance)
            {
                context.Users.Remove(context.Users.Find(id));
                context.SaveChanges();
            }
        }
    }
}
