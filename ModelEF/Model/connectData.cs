using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ModelEF.Model
{
    public partial class connectData : DbContext
    {
        public connectData()
            : base("name=connectData")
        {
        }

        public virtual DbSet<ChiTietLuuTru> ChiTietLuuTru { get; set; }
        public virtual DbSet<LuuTru> LuuTru { get; set; }
        public virtual DbSet<NguoiDung> NguoiDung { get; set; }
        public virtual DbSet<NguoiNuocNgoai> NguoiNuocNgoai { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TKAdmin> TKAdmin { get; set; }
        public virtual DbSet<TKNhanVien> TKNhanVien { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietLuuTru>()
                .Property(e => e.MaCT)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietLuuTru>()
                .Property(e => e.MaLT)
                .IsUnicode(false);

            modelBuilder.Entity<LuuTru>()
                .Property(e => e.MaLT)
                .IsUnicode(false);

            modelBuilder.Entity<LuuTru>()
                .Property(e => e.MaTKNNN)
                .IsUnicode(false);

            modelBuilder.Entity<LuuTru>()
                .Property(e => e.MaTKND)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MaTKND)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MaTKNV)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .HasMany(e => e.LuuTru)
                .WithRequired(e => e.NguoiDung)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguoiDung>()
                .HasMany(e => e.NguoiNuocNgoai)
                .WithRequired(e => e.NguoiDung)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguoiNuocNgoai>()
                .Property(e => e.MaTKNNN)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiNuocNgoai>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiNuocNgoai>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiNuocNgoai>()
                .Property(e => e.Passport)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiNuocNgoai>()
                .Property(e => e.MaTKND)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaTKNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<TKAdmin>()
                .Property(e => e.MaTK)
                .IsUnicode(false);

            modelBuilder.Entity<TKAdmin>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TKNhanVien>()
                .Property(e => e.MaTKNV)
                .IsUnicode(false);

            modelBuilder.Entity<TKNhanVien>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TKNhanVien>()
                .HasOptional(e => e.NhanVien)
                .WithRequired(e => e.TKNhanVien);
        }
    }
}
