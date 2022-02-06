﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EMEHospitalWebApp.Data.Party;

namespace EMEHospitalWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EMEHospitalWebApp.Data.Appointment>? Appointment { get; set; }
        public DbSet<PatientData>? Patients { get; set; }
    }
}