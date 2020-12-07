using ParkingUN.Models;
using ParkingUN.Repository;
using ParkingUN.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace ParkingUN.Controllers
{
    public class UsersController : ApiController
    {
        Models.ParkingUNEntities1 db = new Models.ParkingUNEntities1();

        // GET: api/Users
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Users/5
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetByMail(string mail)
        {

            User user = db.Users.Where(atr => atr.email == mail).FirstOrDefault();
            UserRepo ur;
            if (user == null)
            {
                ur = new UserRepo(db.Users.Where(atr => atr.username == "default").FirstOrDefault());
                return Json(ur);
            }
            else
            {
                ur = new UserRepo(user);
                return Json(ur);
            }

        }


        // GET: api/Users/5
        [System.Web.Http.HttpGet]
        public IHttpActionResult Get(string id)
        {

            User user = db.Users.Where(atr => atr.username == id).FirstOrDefault();
            UserRepo ur;
            if (user == null)
            {
                 ur = new UserRepo(db.Users.Where(atr => atr.username == "default").FirstOrDefault());
                return Json(ur);
            }
            else
            {
                ur = new UserRepo(user);
                return Json(ur);
            }

        }

        [System.Web.Http.HttpPost]
        // POST: api/Users
        public IHttpActionResult Post([FromBody]UserRepo value)
        {
            RegisterService rs = new RegisterService();
            rs.registerUser(value);
            return Ok("Registro Correcto");

        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
