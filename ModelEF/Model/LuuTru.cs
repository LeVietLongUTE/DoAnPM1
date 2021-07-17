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
        [Display(Name = "Mã Lưu Trú")]
        [Required(ErrorMessage = "Mã không được để trống! ")]
        public string MaLT { get; set; }

        [StringLength(8)]
        [Display(Name = "Mã TK Người Nước Ngoài")]
        [Required(ErrorMessage = "Mã không được để trống! ")]
        public string MaTKNNN { get; set; }

        [Required]
        [StringLength(9)]
        [Display(Name = "Mã Tài Khoản Người Dùng")]
        public string MaTKND { get; set; }
        [Display(Name = "Ngày Đến Đăng Kí Lưu Trú")]
        [Required(ErrorMessage = "Ngày đến đăng kí không được để trống! ")]
        public DateTime NDKLT { get; set; }
        [Display(Name = "Ngày Đến Lưu Trú")]
        [Required(ErrorMessage = "Ngày đến lưu trú không được để trống! ")]
        public DateTime? NDLT { get; set; }
        [Display(Name = "Số Phòng")]
        [Required(ErrorMessage = "Số phòng không được để trống! ")]
        public int SoPhong { get; set; }
        [Display(Name = "Ngày Đi Dự Kiến")]
        [Required(ErrorMessage = "Ngày đi dự kiến không được để trống! ")]
        public DateTime NDDK { get; set; }
        [Display(Name = "Ngày Đi Thực Tế")]
        [Required(ErrorMessage = "Ngày đi thực tế không được để trống! ")]
        public DateTime? NDTT { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Trạng Thái")]
        public string TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietLuuTru> ChiTietLuuTrus { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        public virtual NguoiNuocNgoai NguoiNuocNgoai { get; set; }
    }
}
