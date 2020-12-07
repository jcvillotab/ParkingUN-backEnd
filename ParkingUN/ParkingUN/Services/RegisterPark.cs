using ParkingUN.Models;
using ParkingUN.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingUN.Services
{
    public class RegisterPark
    {
        public void registerParking(ParkingLogRepo repo)
        {
            Parking_User space = new Parking_User();
            Parking pk;
            space.id = repo.id;
            space.idParking = repo.idParking;
            space.idUser = repo.idUser;
            space.dateStart = repo.dateStart;
            space.dateEnd = repo.dateEnd;
            try
            {
                using (var db = new ParkingUNEntities1())
                {

                    pk = db.Parkings.Find(repo.idParking);
                    pk.actual = pk.actual + 1;
                    db.SaveChanges();
                    db.Parking_User.Add(space);
                    db.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT [dbo].[Parking_User] ON");
                    db.SaveChanges();
                    db.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT [dbo].[Parking_User] OFF");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            

        }

        public void deleteParking(Parking_User log)
        {
            using (var db = new ParkingUNEntities1())
            {
                Parking pk;
                Parking_log save = new Parking_log();
                save.id = log.id;
                save.idUser = log.idUser;
                save.idParking = log.idParking;
                save.dateStart = log.dateStart;
                save.dateEnd = (DateTime)log.dateEnd;

                pk = db.Parkings.Find(log.idParking);
                pk.actual = pk.actual - 1;
                db.SaveChanges();


                log = db.Parking_User.Find(save.id);
                db.Parking_log.Add(save);
                db.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT [dbo].[Parking_log] ON");
                db.SaveChanges();
                db.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT [dbo].[Parking_log] OFF");

                db.Parking_User.Remove(log);
                db.SaveChanges();
            }
        }
    }
}