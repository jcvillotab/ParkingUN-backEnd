﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParkingUN.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ParkingUNEntities1 : DbContext
    {
        public ParkingUNEntities1()
            : base("name=ParkingUNEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Parking> Parkings { get; set; }
        public DbSet<Parking_log> Parking_log { get; set; }
        public DbSet<Parking_User> Parking_User { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
