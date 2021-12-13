using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using UserAPI.Models;

namespace UserAPI.Controllers
{
    public class UserController : ApiController
    {
        //public UserController()
        //{

        //}
        
        //POST api/User
        [ResponseType(typeof(User))]
        public IHttpActionResult PostUser(User user)
        {
            user.Id = Guid.NewGuid().ToString();
            return Ok(user);
        }
    }
}
