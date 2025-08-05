using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBfirstapplication.Models;

public partial class OwnPracticeContext : DbContext
{
    public OwnPracticeContext()
    {
    }

    public OwnPracticeContext(DbContextOptions<OwnPracticeContext> options)
        : base(options)
    {
    }

    

    public virtual DbSet<Employee> Employees { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=DESKTOP-LNSND5B;database=own practice;integrated security=true;trustservercertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Empid).HasName("PK__employee__AF4CE86513A9E9FD");

            entity.ToTable("employee");

            entity.Property(e => e.Empid)
                .ValueGeneratedNever()
                .HasColumnName("empid");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("department");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
