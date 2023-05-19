using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace P03PlayersWebApi.Models;

public partial class VolleyballWebContext : DbContext
{
    public VolleyballWebContext()
    {
    }

    public VolleyballWebContext(DbContextOptions<VolleyballWebContext> options)
        : base(options)
    {
    }

    public virtual DbSet<VolleyballPlayer> VolleyballPlayers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=DefaultConnectionString");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VolleyballPlayer>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
