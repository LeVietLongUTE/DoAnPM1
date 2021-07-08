namespace ModelEF.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DoAnPM1Context : DbContext
    {
        public DoAnPM1Context()
            : base("name=DoAnPM1Context")
        {
        }

        public virtual DbSet<ChiTietLuuTru> ChiTietLuuTrus { get; set; }
        public virtual DbSet<LuuTru> LuuTrus { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<NguoiNuocNgoai> NguoiNuocNgoais { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TKAdmin> TKAdmins { get; set; }
        public virtual DbSet<TKNhanVien> TKNhanViens { get; set; }

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
                .Property(e => e.MatKhau)
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
                .HasMany(e => e.LuuTrus)
                .WithRequired(e => e.NguoiDung)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguoiDung>()
                .HasMany(e => e.NguoiNuocNgoais)
                .WithRequired(e => e.NguoiDung)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguoiNuocNgoai>()
                .Property(e => e.MaTKNNN)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiNuocNgoai>()
                .Property(e => e.MatKhau)
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
