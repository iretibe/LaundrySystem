﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using LaundrySystem.UI.Models;

namespace LaundrySystem.UI.Entities
{
    public partial class LaundrydbContext : DbContext
    {
        public LaundrydbContext()
        {
        }

        public LaundrydbContext(DbContextOptions<LaundrydbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<tblCategory> tblCategory { get; set; }
        public virtual DbSet<tblContact> tblContact { get; set; }
        public virtual DbSet<tblCustomer> tblCustomer { get; set; }
        public virtual DbSet<tblProduct> tblProduct { get; set; }
        public virtual DbSet<tblSale> tblSale { get; set; }
        public virtual DbSet<tblSaleDetail> tblSaleDetail { get; set; }
        public virtual DbSet<tblService> tblService { get; set; }
        public virtual DbSet<tblShoppingCartItem> tblShoppingCartItem { get; set; }
        public virtual DbSet<tblStatus> tblStatus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=chacour.shop;Initial Catalog=LaundryDB;Persist Security Info=True;User ID=sa;Password=Chacour@2021");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");
            });

            modelBuilder.Entity<tblCategory>(entity =>
            {
                entity.Property(e => e.CategoryId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tblContact>(entity =>
            {
                entity.Property(e => e.ContactId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.MessageDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tblCustomer>(entity =>
            {
                entity.Property(e => e.CustomerID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AddedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerNo)
                    .IsUnicode(false)
                    .HasComputedColumnSql("('C'+left(newid(),(4)))");
            });

            modelBuilder.Entity<tblProduct>(entity =>
            {
                entity.HasIndex(e => e.ProductName)
                    .HasName("UQ_Product")
                    .IsUnique();

                entity.Property(e => e.ProductID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AddedDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tblSale>(entity =>
            {
                entity.Property(e => e.SaleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Discount).HasDefaultValueSql("((0))");

                entity.Property(e => e.NetTotal).HasDefaultValueSql("((0))");

                entity.Property(e => e.SaleDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SaleTotal).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tax).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<tblSaleDetail>(entity =>
            {
                entity.Property(e => e.SaleDetailId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.SaleDetailTotal).HasComputedColumnSql("([QtySold]*[SellingPrice])");
            });

            modelBuilder.Entity<tblService>(entity =>
            {
                entity.Property(e => e.ServiceId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AddedDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tblShoppingCartItem>(entity =>
            {
                entity.Property(e => e.ShoppingCartItemID).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tblStatus>(entity =>
            {
                entity.HasIndex(e => e.StatusName)
                    .HasName("UQ_Status")
                    .IsUnique();

                entity.Property(e => e.StatusID).HasDefaultValueSql("(newid())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<LaundrySystem.UI.Models.ProductModel> ProductModel { get; set; }

        public DbSet<LaundrySystem.UI.Models.spSelectSaleDetails> spSelectSaleDetails { get; set; }
    }
}