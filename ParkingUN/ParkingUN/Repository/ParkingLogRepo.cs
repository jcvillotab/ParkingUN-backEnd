using ParkingUN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingUN.Repository
{
    public class ParkingLogRepo
    {
        public int id { get; set; }
        public int idUser { get; set; }
        public int idParking { get; set; }
        public System.DateTime dateStart { get; set; }
        public System.DateTime dateEnd { get; set; }

        public ParkingLogRepo()
        {

        }

        public ParkingLogRepo(Parking_log plog) {
            this.id = plog.id;
            this.idUser = plog.idUser;
            this.idParking = plog.idParking;
            this.dateStart = plog.dateStart;
            this.dateEnd = plog.dateEnd;

        }

    }
}