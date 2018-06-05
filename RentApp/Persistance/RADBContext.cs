using Microsoft.AspNet.Identity.EntityFramework;
using RentApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RentApp.Persistance
{
    public class RADBContext : IdentityDbContext<RAIdentityUser>
    {
        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }

        public virtual DbSet<Grading> Gradings { get; set; }
        public virtual DbSet<PriceItem> PriceItems { get; set; }
        public virtual DbSet<PriceList> PriceLists { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<RentApp.Models.Entities.Type> Types { get; set; }
        public virtual DbSet<Vehicle> Vehicles{ get; set; }






        public RADBContext() : base("name=RADB")
        {
        }

        public static RADBContext Create()
        {
            return new RADBContext();
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Service>().HasOptional<ICollection<Grading>>(s=> s.Gradings).WithMany().WillCascadeOnDelete(false);
        //    modelBuilder.Entity<Branch>().HasOptional<ICollection<Reservation>>(s => s.StartReservations).WithMany().WillCascadeOnDelete(false);
        //    modelBuilder.Entity<Branch>().HasOptional<ICollection<Grading>>(s => s.EndReservations).WithMany().WillCascadeOnDelete(false);
        //    modelBuilder.Entity<Service>().HasOptional<ICollection<Grading>>(s => s.Gradings).WithMany().WillCascadeOnDelete(false);
        //    modelBuilder.Entity<Service>().HasOptional<ICollection<Grading>>(s => s.Gradings).WithMany().WillCascadeOnDelete(false);
        //}
    }
}