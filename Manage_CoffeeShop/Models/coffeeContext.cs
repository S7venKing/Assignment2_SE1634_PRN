using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Manage_CoffeeShop.Models
{
    public partial class coffeeContext : DbContext
    {
        public coffeeContext()
        {
        }

        public coffeeContext(DbContextOptions<coffeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Bill> Bills { get; set; } = null!;
        public virtual DbSet<BillInfo> BillInfos { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<CoffeTable> CoffeTables { get; set; } = null!;
        public virtual DbSet<Drink> Drinks { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost,1433;Initial Catalog=coffee;User ID=sa;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__account__9A20D55489ED37B2");

                entity.ToTable("account");

                entity.Property(e => e.Id).HasColumnName("acc_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("acc_name");

                entity.Property(e => e.Password)
                    .HasMaxLength(1000)
                    .HasColumnName("acc_pass");

                entity.Property(e => e.Type).HasColumnName("acc_type");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .HasColumnName("acc_username");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.ToTable("bill");

                entity.Property(e => e.BillId).HasColumnName("bill_id");

                entity.Property(e => e.BillStatus).HasColumnName("bill_status");

                entity.Property(e => e.Datecheckin)
                    .HasColumnType("date")
                    .HasColumnName("datecheckin")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datecheckout)
                    .HasColumnType("date")
                    .HasColumnName("datecheckout");

                entity.Property(e => e.TableId).HasColumnName("table_id");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.TableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__bill__table_id__45F365D3");
            });

            modelBuilder.Entity<BillInfo>(entity =>
            {
                entity.ToTable("bill_info");

                entity.Property(e => e.BillInfoId).HasColumnName("bill_info_id");

                entity.Property(e => e.BillId).HasColumnName("bill_id");

                entity.Property(e => e.DrinkId).HasColumnName("drink_id");

                entity.Property(e => e.DrinkQuantity).HasColumnName("drink_quantity");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.BillInfos)
                    .HasForeignKey(d => d.BillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__bill_info__bill___49C3F6B7");

                entity.HasOne(d => d.Drink)
                    .WithMany(p => p.BillInfos)
                    .HasForeignKey(d => d.DrinkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__bill_info__drink__4AB81AF0");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CateId)
                    .HasName("PK__category__34EAD17345DB2E71");

                entity.ToTable("category");

                entity.Property(e => e.CateId).HasColumnName("cate_id");

                entity.Property(e => e.CateName)
                    .HasMaxLength(100)
                    .HasColumnName("cate_name")
                    .HasDefaultValueSql("(N'No name')");
            });

            modelBuilder.Entity<CoffeTable>(entity =>
            {
                entity.HasKey(e => e.TableId)
                    .HasName("PK__coffe_ta__B21E8F24E46ACA54");

                entity.ToTable("coffe_table");

                entity.Property(e => e.TableId).HasColumnName("table_id");

                entity.Property(e => e.TableName)
                    .HasMaxLength(100)
                    .HasColumnName("table_name");

                entity.Property(e => e.TableStatus).HasColumnName("table_status");
            });

            modelBuilder.Entity<Drink>(entity =>
            {
                entity.ToTable("drink");

                entity.Property(e => e.DrinkId).HasColumnName("drink_id");

                entity.Property(e => e.CateId).HasColumnName("cate_id");

                entity.Property(e => e.DrinkName)
                    .HasMaxLength(100)
                    .HasColumnName("drink_name")
                    .HasDefaultValueSql("(N'No name')");

                entity.Property(e => e.DrinkPrice)
                    .HasColumnType("money")
                    .HasColumnName("drink_price");

                entity.HasOne(d => d.Cate)
                    .WithMany(p => p.Drinks)
                    .HasForeignKey(d => d.CateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__drink__cate_id__412EB0B6");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
