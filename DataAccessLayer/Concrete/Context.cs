using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//bağlantı adresimizi tutacak method
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-6ORT1G3; database=PersonelControlSystemDB; integrated security=true;");
        }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Personel> Personels { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Shift> Shifts { get; set; }

        public DbSet<User> Users { get; set; }
    }

}
