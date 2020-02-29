using asp_react.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_react.Controllers
{
  
    public class UserController:ControllerBase
    {
        [Produces("application/json")]
        [Route("api/[controller]")]
        [EnableCors("ReactPolicy")]
        public IEnumerable<User> GetAll()
        {
            List<User> users1 = new List<User>();
            User user = new User { Id = 1, Age = 22, FirstName = "Luka", LastName = "Radovanovic", Title = "Student" };
            User user1 = new User { Id = 2, Age = 25, FirstName = "Mika", LastName = "Mikovic", Title = "Junior Developer" };
            User user2 = new User { Id = 3, Age = 21, FirstName = "Jova", LastName = "Jovic", Title = "Student" };
            users1.Add(user);users1.Add(user1);users1.Add(user2);
            IEnumerable<User> users = users1.AsEnumerable<User>();
            return users;
        }
    }
}
