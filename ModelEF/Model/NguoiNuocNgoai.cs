namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiNuocNgoai")]
    public partial class NguoiNuocNgoai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguoiNuocNgoai()
        {
            LuuTru = new HashSet<LuuTru>();
        }

        [Key]
        [StringLength(8)]
        public string MaTKNNN { get; set; }

        [Required]
        [StringLength(255)]
        public string HoTen { get; set; }

        public DateTime? NgaySinh { get; set; }

        [Required]
        [StringLength(3)]
        public string GioiTinh { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [Required]
        [StringLength(200)]
        public string DiachiTT { get; set; }

        [Required]
        [StringLength(255)]
        public string QuocTich { get; set; }

        [Required]
        [StringLength(8)]
        public string Passport { get; set; }

        [Required]
        [StringLength(8)]
        public string MaTKND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LuuTru> LuuTru { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }
    }
}
