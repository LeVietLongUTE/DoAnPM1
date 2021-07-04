namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        [StringLength(8)]
        public string MaTKNV { get; set; }

        [Required]
        [StringLength(255)]
        public string TenNV { get; set; }

        public DateTime? NgaySinh { get; set; }

        [Required]
        [StringLength(3)]
        public string GioiTinh { get; set; }

        [Required]
        [StringLength(8)]
        public string CCCD { get; set; }

        [Required]
        [StringLength(30)]
        public string Diachi { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        public virtual TKNhanVien TKNhanVien { get; set; }
    }
}
