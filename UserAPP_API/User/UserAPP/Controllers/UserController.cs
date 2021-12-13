//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using UserAPP.Models;
using UserAPP.Services;
using System.Text.Json.Serialization;
using System.Text.Json;
//using System.Web.Script.Serialization;

namespace UserAPP.Controllers
{
    public class UserController : Controller
    {
        UserDbContext _context;
        public UserController()
        {
            _context = new UserDbContext();
        }
        public ActionResult Index()
        {
            var user = _context.Users.OrderBy(u => u.FirstName).ToList();
            return View(user);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            ModelState.Remove("Id");

            if (ModelState.IsValid)
            {
                HttpResponseMessage response = GlobalVariables.webApiClient.PostAsJsonAsync("User", user).Result;

                //var userList = response.Content.ReadAsAsync<IEnumerable<User>>().Result;
                //var userList = response.Content.ReadAsAsync<List<User>>().Result;

                if (response.IsSuccessStatusCode)
                {
                    var userList = response.Content.ReadAsAsync<User>().Result;

                    _context.Users.Add(userList);
                    var saved = _context.SaveChanges();

                    if (saved >= 0)
                    {
                        return RedirectToAction("Index");
                    }
                    
                }

            }      
                
            return View();
        }
       
    }
}