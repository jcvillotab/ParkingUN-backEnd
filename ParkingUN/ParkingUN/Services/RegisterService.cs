using ParkingUN.Models;
using ParkingUN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingUN.Services
{
    public class RegisterService
    {
        public void registerUser(UserRepo userR)
        {
            User user = new User();
            user.id = userR.id;
            user.username = userR.username;
            user.name = userR.name;
            user.surname = userR.surname;
            user.email = userR.email;
            user.identification = userR.identification;
            user.passwordF = userR.passwordF;

            using (var db = new ParkingUNEntities1())
            {
                db.Users.Add(user);
                db.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT [dbo].[Users] ON");
                db.SaveChanges();
                db.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT [dbo].[Users] OFF");
            }


        }
    }
}