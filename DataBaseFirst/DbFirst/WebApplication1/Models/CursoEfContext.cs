using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class CursoEfContext : DbContext
{
    public CursoEfContext()
    {
    }

    public CursoEfContext(DbContextOptions<CursoEfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Userid> Userids { get; set; }

    public virtual DbSet<Workingexperience> Workingexperiences { get; set; }

    public async Task<Userid> Get(int id)
    {
        var response = await Userids.FirstOrDefaultAsync(x => x.UserId1 == id);
        return response;
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Userid>(entity =>
        {
            entity.HasKey(e => e.UserId1).HasName("PK__userid__1788CC4C795E3C3F");

            entity.ToTable("userid");

            entity.HasIndex(e => e.UserName, "UQ__userid__C9F28456E029071D").IsUnique();

            entity.Property(e => e.UserId1).HasColumnName("UserId");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Workingexperience>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__workinge__3213E83F636420EC");

            entity.ToTable("workingexperience");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Details)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.Environment)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.Workingexperiences)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkingExperience_UserId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
