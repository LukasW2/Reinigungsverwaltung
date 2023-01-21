using Microsoft.EntityFrameworkCore;

namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model.Reinigungsverwaltung.Infrastructure;

public class ReinigungsverwaltungContext : DbContext
{
    //       Name der Klasse    Name in der DB
    // public DbSet<CustomService> CustomServices => Set<CustomService>();
    


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
       //            Name der Klasse                 Name vom Value Object (Zeitstempel)
       // modelBuilder.Entity<Host>().OwnsOne(h => h.Description);
       
       modelBuilder.Entity<Hotel>().HasAlternateKey(m => m.Guid);
       modelBuilder.Entity<Hotel>().Property(m => m.Guid).ValueGeneratedOnAdd();

    }
}