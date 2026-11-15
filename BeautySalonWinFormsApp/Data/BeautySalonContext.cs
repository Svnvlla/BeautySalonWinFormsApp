using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySalonWinFormsApp.Data
{
    public class BeautySalonContext : DbContext
    {
        public DbSet<Service> Services { get; set; }

        public DbSet<Master> Masters { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=BeautySalon.db");
    }
}
