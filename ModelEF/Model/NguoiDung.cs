namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguoiDung()
        {
            LuuTrus = new HashSet<LuuTru>();
            NguoiNuocNgoais = new HashSet<NguoiNuocNgoai>();
        }

        [Key]
        [StringLength(9)]
        public string MaTKND { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(255)]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [Required]
        [StringLength(3)]
        public string GioiTinh { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string DVKD { get; set; }

        [Required]
        [StringLength(9)]
        public string CCCD { get; set; }

        [Required]
        [StringLength(255)]
        public string QuocTich { get; set; }

        [Required]
        [StringLength(200)]
        public string DiachiTT { get; set; }

        [Required]
        [StringLength(255)]
        public string TenCSKD { get; set; }

        [Required]
        [StringLength(255)]
        public string DiaChiKD { get; set; }

        public string MCKD { get; set; }

        public bool TrangThai { get; set; }

        [StringLength(8)]
        public string MaTKNV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LuuTru> LuuTrus { get; set; }

        public virtual TKNhanVien TKNhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NguoiNuocNgoai> NguoiNuocNgoais { get; set; }
    }
}
