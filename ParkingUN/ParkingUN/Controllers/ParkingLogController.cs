using ParkingUN.Repository;
using ParkingUN.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ParkingUN.Controllers
{
    public class ParkingLogController : ApiController
    {
        Models.ParkingUNEntities1 db = new Models.ParkingUNEntities1();

        // GET: api/ParkingLog
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ParkingLog/5
        public string Get(int id, int idPark)
        {
            var response = db.Parking_User.Where(atr => atr.idUser == id && atr.idParking == idPark).FirstOrDefault();
            if(response == null)
            {
                return "Not found " +id.ToString() + idPark.ToString();
            }
            else
            {
                return "Exist";
            }

        }


        // POST: api/ParkingLog
        [System.Web.Http.HttpPost]
        public string Post([FromBody]ParkingLogRepo value)
        {
            RegisterPark rp = new RegisterPark();
            rp.registerParking(value);
            return "Registro Correcto";
        }

        // PUT: api/ParkingLog/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ParkingLog/5
        public string Delete(int id, int idPark)
        {
            RegisterPark rp = new RegisterPark();
            rp.deleteParking(db.Parking_User.Where(atr => atr.idUser == id && atr.idParking == idPark).FirstOrDefault());
            return "Retirado Correctamente";
        }
    }
}
