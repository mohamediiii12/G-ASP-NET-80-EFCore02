using G_ASP_NET_80_EFCore02.Configurations;
using G_ASP_NET_80_EFCore02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace G_ASP_NET_80_EFCore02.Contexts
{
    public class EventHubDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-V14FACA;Database=EventHub;trusted_connection=true;trustservercertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrganizerProfileConfiguration());
            modelBuilder.ApplyConfiguration(new EventConfiguration());

            modelBuilder.Entity<Badge>(b =>
            {
                b.HasKey(x => x.Id);
                b.Property(x => x.BadgeNumber)
                   .IsRequired();

                b.Property(x => x.IssuedDate)
                   .IsRequired();

                b.Property(x => x.Tier)
                   .IsRequired()
                   .HasConversion<string>()
                   .HasMaxLength(20);
            });
            
        }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }
    }
}
