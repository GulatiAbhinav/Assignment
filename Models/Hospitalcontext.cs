using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace assignment1.Models
{
    public class Hospitalcontext : DbContext
    {
        public DbSet<Patient> patient { get; set; }
        public DbSet<Doctor> doctor { get; set; }
        public DbSet<Appointment> appointment { get; set; }

        public DbSet<Schedule> sch { get; set; }

    }      
}