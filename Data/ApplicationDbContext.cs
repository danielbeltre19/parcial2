using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace tarea7.Data
{
    public class ApplicationDbContext : IdentityDbContext<appUser>
    {
         public DbSet<appUser> appUsers {get; set;}
        public DbSet<Treasure> Treasures {get; set;}
        public DbSet<Coordinate> Coordinates {get; protected set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
         protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<appUser>(entityTypeBuilder => {
                entityTypeBuilder.ToTable("usuario");
                entityTypeBuilder.Property(u => u.Uid).HasMaxLength(100).IsRequired();
                entityTypeBuilder.Property(u => u.Name).HasMaxLength(100);
                entityTypeBuilder.Property( u => u.Color).HasMaxLength(8).HasDefaultValue("#ffffff");
            });
    }
    }


    public class appUser : IdentityUser{

        public Guid Uid {get; set;}
        public string Name {get; set;}
        public string Color {get; set;}

    }
     public class Treasure
    {
        public Guid Uid {get; set;}
        public Guid Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public DateTime Date {get; set;}
        public float Weigth {get; set;}
        public string Place {get; set;}
        public float Value {get; set;}
        public Coordinate Coordinates {get; set;}
        public string UrlRef {get; set;}
    }

    public class Coordinate 
    {
        public Guid Id {get; set;}
        public Guid Tid {get; set;}
        public Guid Uid {get; set;}
        public float Lat {get; set;}
        public float Lng {get; set;}
    }

}
