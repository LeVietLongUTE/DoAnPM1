namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LuuTru")]
    public partial class LuuTru
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LuuTru()
        {
            ChiTietLuuTrus = new HashSet<ChiTietLuuTru>();
        }

        [Key]
        [StringLength(8)]
        public string MaLT { get; set; }

        [StringLength(8)]
        public string MaTKNNN { get; set; }

        [Required]
        [StringLength(9)]
        public string MaTKND { get; set; }

        [Required]
        [StringLength(100)]
        public string TenCSLT { get; set; }

        [Required]
        [StringLength(100)]
        public string DCLT { get; set; }

        [Column(TypeName = "date")]
        public DateTime NDKLT { get; set; }

        [Column(TypeName = "date")]
        public DateTime NDLT { get; set; }

        public int SoPhong { get; set; }

        [Column(TypeName = "date")]
        public DateTime NDDK { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NDTT { get; set; }

        [Required]
        [StringLength(20)]
        public string TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietLuuTru> ChiTietLuuTrus { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        public virtual NguoiNuocNgoai NguoiNuocNgoai { get; set; }
    }
}
