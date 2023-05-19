﻿using Microsoft.EntityFrameworkCore;
using P01_HospitalDatabase.Data.Common;
using P01_HospitalDatabase.Data.Models;

namespace P01_HospitalDatabase.Data;

public class HospitalContext : DbContext
{
    public HospitalContext()
    {

    }
    public HospitalContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Visitation> Visitations { get; set; }
    public DbSet<Diagnose> Diagnoses { get; set; }
    public DbSet<Medicament> Medicaments { get; set; }
    public DbSet<PatientMedicament> PatientMedicaments { get; set; }
    public DbSet<Doctor> Doctors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(DbConfig.ConnectionString);
        }
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<PatientMedicament>()
        .HasKey(pm => new {pm.PatientId,pm.MedicamentId});
    }
}