using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatumClientApp.Core.Models;

public partial class DbclientContext : DbContext
{
    public DbclientContext()
    {
    }

    public DbclientContext(DbContextOptions<DbclientContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BaseUrl> BaseUrls { get; set; }

    public virtual DbSet<ClientConnection> ClientConnections { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Licence> Licences { get; set; }

    public virtual DbSet<LicenceKey> LicenceKeys { get; set; }

    public virtual DbSet<TbClientRegistration> TbClientRegistrations { get; set; }

    public virtual DbSet<TbClientUpdate> TbClientUpdates { get; set; }

    public virtual DbSet<TbVersion> TbVersions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserCredential> UserCredentials { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=cloud.datuminnovation.com;Database=dbclient; User Id=sa;Password=Datum123!;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BaseUrl>(entity =>
        {
            entity.ToTable("BaseUrl");

            entity.HasIndex(e => e.Pin, "IX_BaseUrl").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Pin).HasMaxLength(50);
            entity.Property(e => e.ReportPath).HasMaxLength(500);
            entity.Property(e => e.ReturnUrl).HasMaxLength(500);
            entity.Property(e => e.Url).HasMaxLength(500);
        });

        modelBuilder.Entity<ClientConnection>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Client).HasMaxLength(100);
            entity.Property(e => e.ConnectionString).HasMaxLength(500);
            entity.Property(e => e.Pin).HasMaxLength(10);
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.ToTable("Company");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.DatabaseName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.ServerIp)
                .HasMaxLength(50)
                .HasColumnName("ServerIP");
            entity.Property(e => e.ServerName).HasMaxLength(50);
        });

        modelBuilder.Entity<Licence>(entity =>
        {
            entity.ToTable("Licence");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActivatedKey).HasMaxLength(20);
            entity.Property(e => e.ActivatedOn).HasColumnType("datetime");
            entity.Property(e => e.ComputerName).HasMaxLength(50);
            entity.Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LicenceKey).HasMaxLength(30);
        });

        modelBuilder.Entity<LicenceKey>(entity =>
        {
            entity.HasIndex(e => e.LicenceKey1, "IX_LicenceKeys").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LicenceKey1)
                .HasMaxLength(30)
                .HasColumnName("LicenceKey");
        });

        modelBuilder.Entity<TbClientRegistration>(entity =>
        {
            entity.ToTable("tbClientRegistration");

            entity.Property(e => e.ClinetName).HasMaxLength(150);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DisplayMessage).HasMaxLength(200);
            entity.Property(e => e.ExpDate).HasColumnType("datetime");
            entity.Property(e => e.MacAddress).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(250);
            entity.Property(e => e.Username).HasMaxLength(50);
            entity.Property(e => e.VatNo).HasMaxLength(50);
        });

        modelBuilder.Entity<TbClientUpdate>(entity =>
        {
            entity.ToTable("tbClientUpdates");

            entity.Property(e => e.ClientName).HasMaxLength(50);
            entity.Property(e => e.Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbVersion>(entity =>
        {
            entity.ToTable("tbVersion");

            entity.Property(e => e.Date).HasColumnType("datetime");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<UserCredential>(entity =>
        {
            entity.ToTable("UserCredential");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
