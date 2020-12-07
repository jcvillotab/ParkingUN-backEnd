using ParkingUN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ParkingUN.Controllers
{
    public class ParkingController : ApiController
    {
        Models.ParkingUNEntities1 db = new Models.ParkingUNEntities1();
        // GET: api/Parking
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Parking/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            ParkingRepo repo = new ParkingRepo(db.Parkings.Where(atr => atr.id == id).FirstOrDefault());
            return Json(repo);
        }

        // POST: api/Parking
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Parking/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Parking/5
        public void Delete(int id)
        {
        }
    }
}
