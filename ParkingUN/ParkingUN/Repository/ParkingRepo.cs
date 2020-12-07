using ParkingUN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingUN.Repository
{
    public class ParkingRepo
    {
        public int id { get; set; }
        public string nameP { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public int capacity { get; set; }
        public int actual { get; set; }
        public string state { get; set; }
        public string nearbyPlaces { get; set; }

        public ParkingRepo()
        {

        }

        public ParkingRepo(Parking parking)
        {
            this.id = parking.id;
            this.nameP = parking.nameP;
            this.latitude = parking.latitude;
            this.longitude = parking.longitude;
            this.capacity = parking.capacity;
            this.actual = parking.actual;
            this.state = parking.state;
            this.nearbyPlaces = parking.nearbyPlaces;
        }



    }
}