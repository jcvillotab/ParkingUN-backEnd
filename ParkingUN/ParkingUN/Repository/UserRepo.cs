using ParkingUN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingUN.Repository
{
    public class UserRepo
    {
        public int id { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public long identification { get; set; }
        public string passwordF { get; set; }

        public UserRepo()
        {

        }

        public UserRepo(User user)
        {
            this.id = user.id;
            this.username = user.username;
            this.name = user.name;
            this.surname = user.surname;
            this.email = user.email;
            this.identification = user.identification;
            this.passwordF = user.passwordF;
        }
    }
}