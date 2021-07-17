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
            LuuTrus = new HashSet<LuuTru>();
        }

        [Key]
        [StringLength(8)]
        [Required(ErrorMessage = "Mã không được để trống! ")]
        public string MaTKNNN { get; set; }

       
        [StringLength(50)]
        [Required(ErrorMessage = "Mật Khẩu không được để trống! ")]
        public string MatKhau { get; set; }

        
        [StringLength(255)]
        [Required(ErrorMessage = "Họ Tên không được để trống! ")]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày Sinh")]
        public DateTime? NgaySinh { get; set; }

        [Required]
        [StringLength(3)]
        [Display(Name = "Giới Tính")]
        public string GioiTinh { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "SĐT không được để trống! ")]
        public string SDT { get; set; }

       
        [StringLength(30)]
        [Required(ErrorMessage = "Email không được để trống! ")]
        public string Email { get; set; }

       
        [StringLength(200)]
        [Required(ErrorMessage = "Địa chỉ không được để trống! ")]
        public string DiachiTT { get; set; }

        
        [StringLength(255)]
        [Display(Name = "Quốc Tịch")]
        [Required(ErrorMessage = "Quốc tịch không được để trống! ")]
        public string QuocTich { get; set; }

     
        [StringLength(8)]
        [Display(Name = "PassPort")]
        [Required(ErrorMessage = "Passport không được để trống! ")]
        public string Passport { get; set; }

        [Required]
        [StringLength(9)]
        public string MaTKND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LuuTru> LuuTrus { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }
    }
}
