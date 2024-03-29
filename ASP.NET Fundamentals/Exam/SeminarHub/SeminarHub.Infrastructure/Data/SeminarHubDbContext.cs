﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SeminarHub.Infrastructure.Data.Models;

namespace SeminarHub.Infrastructure;

public class SeminarHubDbContext : IdentityDbContext
{
    public SeminarHubDbContext(DbContextOptions<SeminarHubDbContext> options)
        : base(options)
    {
    }

    public DbSet<Seminar> Seminars { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<SeminarParticipant> SeminarsParticipants { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<SeminarParticipant>()
            .HasKey(sp => new { sp.SeminarId, sp.ParticipantId });

        builder.Entity<SeminarParticipant>()
            .HasOne(s => s.Seminar)
            .WithMany(s => s.SeminarsParticipants)
            .OnDelete(DeleteBehavior.NoAction);

        builder
           .Entity<Category>()
           .HasData(new Category()
           {
               Id = 1,
               Name = "Technology & Innovation"
           },
           new Category()
           {
               Id = 2,
               Name = "Business & Entrepreneurship"
           },
           new Category()
           {
               Id = 3,
               Name = "Science & Research"
           },
           new Category()
           {
               Id = 4,
               Name = "Arts & Culture"
           });

        base.OnModelCreating(builder);
    }
}